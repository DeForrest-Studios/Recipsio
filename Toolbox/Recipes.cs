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
            return $":Name\n{MF.RecipeName.Text}\n" +
                   $":Author\n{MF.RecipeAuthor.Text}\n" +
                   $":PrepTime\n{MF.PrepHours.Text.Split(" ")[0]}:{MF.PrepMinutes.Text.Split(" ")[0]}:{MF.PrepDays.Text.Split(" ")[0]}\n" +
                   $":CookTime\n{MF.CookDays.Text.Split(" ")[0]}:{MF.CookHours.Text.Split(" ")[0]}:{MF.CookMinutes.Text.Split(" ")[0]}\n" +
                   $":Description\n{MF.RecipeDescription.Text}\n" +
                   $":Ingredients\n{string.Join("|", MF.RecipeIngredients.Items.Cast<string>())}\n" +
                   $":Directions\n{string.Join("|", MF.RecipeDirections.Items.Cast<string>())}";
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
                    MF.RecipeName.Text = Lines[Index];
                }
                else if (DataState == "Author")
                {
                    MF.RecipeAuthor.Text = Lines[Index];
                }
                else if (DataState == "PrepTime")
                {
                    string[] Times = Lines[Index].Split(":");
                    MF.PrepHours.Text = $"{Times[0]} Days";
                    MF.PrepMinutes.Text = $"{Times[1]} Hours";
                    MF.PrepDays.Text = $"{Times[2]} Minutes";
                }
                else if (DataState == "CookTime")
                {
                    string[] Times = Lines[Index].Split(":");
                    MF.CookDays.Text = $"{Times[0]} Days";
                    MF.CookHours.Text = $"{Times[1]} Hours";
                    MF.CookMinutes.Text = $"{Times[2]} Minutes";
                }
                else if (DataState == "Description")
                {
                    MF.RecipeDescription.Text = Lines[Index];
                }
                else if (DataState == "Ingredients")
                {
                    List<string> Ingredients = Lines[Index].Split('|').ToList();
                    foreach (string Ingredient in Ingredients)
                    {
                        MF.RecipeIngredients.Items.Add(Ingredient);
                    }
                }
                else if (DataState == "Directions")
                {
                    List<string> Directions = Lines[Index].Split('|').ToList();
                    foreach (string Direction in Directions)
                    {
                        MF.RecipeDirections.Items.Add(Direction);
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