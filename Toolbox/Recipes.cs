using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Recipsio
{
    public partial class Toolbox
    {
        public static string Build_File_Formatted_Recipe(MainForm MF)
        {
            return $":Name\n{MF.Header.TotalTimeValue.Text}\n" +
                   $":Author\n{MF.Header.TotalTimeValue.Text}\n" +
                   $":PrepTime\n{MF.Header.TotalTimeValue.Text.Split(" ")[0]}:{MF.Header.TotalTimeValue.Text.Split(" ")[0]}:{MF.Header.TotalTimeValue.Text.Split(" ")[0]}\n" +
                   $":CookTime\n{MF.Header.TotalTimeValue.Text.Split(" ")[0]}:{MF.Header.TotalTimeValue.Text.Split(" ")[0]}:{MF.Header.TotalTimeValue.Text.Split(" ")[0]}\n" +
                   $":Description\n{MF.Information.RecipeDescription.Text}\n" +
                   $":Ingredients\n{string.Join("|", MF.Information.RecipeIngredients.Items.Cast<string>())}\n" +
                   $":Directions\n{string.Join("|", MF.Information.RecipeDirections.Items.Cast<string>())}";
        }
        public void Load_Recipe(string CurrentRecipe)
        {
            RecipeFile = $"{RecipsioRecipesFolder}\\{CurrentRecipe.Replace(" ", "-")}.recipe";

            string[] Lines = File.ReadAllLines(RecipeFile);

            string DataState = "";
            for (int Index = 0; Index < Lines.Length; Index++)
            {
                if (Lines[Index][0] == ':')
                {
                    DataState = Lines[Index][1..];
                    continue;
                }

                if (DataState == "Name")
                {
                    MF.Header.TotalTimeValue.Text = Lines[Index];
                }
                else if (DataState == "Author")
                {
                    MF.Header.TotalTimeValue.Text = Lines[Index];
                }
                else if (DataState == "PrepTime")
                {
                    string[] Times = Lines[Index].Split(":");
                    MF.Header.TotalTimeValue.Text = $"{Times[0]} Days";
                    MF.Header.TotalTimeValue.Text = $"{Times[1]} Hours";
                    MF.Header.TotalTimeValue.Text = $"{Times[2]} Minutes";
                }
                else if (DataState == "CookTime")
                {
                    string[] Times = Lines[Index].Split(":");
                    MF.Header.TotalTimeValue.Text = $"{Times[0]} Days";
                    MF.Header.TotalTimeValue.Text = $"{Times[1]} Hours";
                    MF.Header.TotalTimeValue.Text = $"{Times[2]} Minutes";
                }
                else if (DataState == "Description")
                {
                    MF.Header.TotalTimeValue.Text = Lines[Index];
                }
                else if (DataState == "Ingredients")
                {
                    List<string> Ingredients = Lines[Index].Split('|').ToList();
                    foreach (string Ingredient in Ingredients)
                    {
                        MF.Information.RecipeIngredients.Items.Add(Ingredient);
                    }
                }
                else if (DataState == "Directions")
                {
                    List<string> Directions = Lines[Index].Split('|').ToList();
                    foreach (string Direction in Directions)
                    {
                        MF.Information.RecipeDirections.Items.Add(Direction);
                    }
                }
            }
            Update_Times();
        }
        public void Load_Recipes(ref ListBox RecipeList)
        {
            foreach (string RecipeFile in Directory.GetFiles(RecipsioRecipesFolder))
            {
                Debug.WriteLine(RecipeFile);
                string RecipeFileString = Path.GetRelativePath(RecipsioRecipesFolder, RecipeFile).Replace("-", " ").Replace(".recipe", "");

                RecipeList.Items.Add(RecipeFileString);
            }
        }
        public string Save_Recipe(string RecipeName, MainForm MF)
        {
            if (File.Exists(RecipsioRecipesFolder))
            {
                DialogResult Result = Send_Message_Box("Would you like to rewrite the recipe?",
                                                       "Recipe exists",
                                                       MessageBoxButtons.YesNo);
                if (Result == DialogResult.Yes)
                {
                    RecipeFile = $"{RecipsioRecipesFolder}\\{MF.CurrentRecipe!.Replace(" ", "-")}.recipe";
                    File.WriteAllText(RecipeFile!, Build_File_Formatted_Recipe(MF));
                    return "Old";
                }
            }
            else
            {
                RecipeFile = $"{RecipsioRecipesFolder}\\{RecipeName.Replace(" ", "-")}.recipe";
                File.WriteAllText(RecipeFile, Build_File_Formatted_Recipe(MF));
                return "New";
            }
            return "Failure";
        }

        public void Delete_Recipe(string CurrentRecipe)
        {
            RecipeFile = $"{RecipsioRecipesFolder}\\{CurrentRecipe.Replace(" ", "-")}.recipe";
            if (File.Exists(RecipeFile))
            {
                DialogResult Result = Send_Message_Box("Are you sure you would like to delete this recipe?",
                                                       "Delete Recipe",
                                                       MessageBoxButtons.YesNo);
                if (Result == DialogResult.Yes)
                {
                    File.Delete(RecipeFile);
                }
            }
            else
            {
                MessageBox.Show("Recipe not found", "Error");
            }
        }
    }
}