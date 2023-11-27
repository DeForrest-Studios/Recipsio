using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Recipsio
{
    public partial class Toolbox
    {
        public string? RecipeFile;
        public static readonly string RecipsioFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Recipsio");
        public static readonly string RecipsioRecipesFolder = Path.Combine(RecipsioFolder, "Recipes");

        public void Generate_User_Directories()
        {
            Directory.CreateDirectory(RecipsioFolder);
            Directory.CreateDirectory(RecipsioRecipesFolder);
        }

        public void Load_Files(ref ListBox RecipeList)
        {
            foreach (string RecipeFile in Directory.GetFiles(RecipsioRecipesFolder))
            {
                Debug.WriteLine(RecipeFile);
                string RecipeFileString = Path.GetRelativePath(RecipsioRecipesFolder, RecipeFile).Replace("-", " ").Replace(".recipe", "");

                RecipeList.Items.Add(RecipeFileString);
            }
        }

        public string[] Load_File(string CurrentRecipe)
        {
            RecipeFile = $"{RecipsioRecipesFolder}\\{CurrentRecipe.Replace(" ", "-")}.recipe";

            return File.ReadAllLines(RecipeFile);
        }
        public static string Build_File_Formatted_String(MainForm RM)
        {
            string NameString = $":RecipeName\n{RM.RecipeName.Text}";

            string DescriptionString = $":RecipeDescription\n{RM.RecipeDescription.Text}";

            string FormattedIngredients = ":RecipeIngredients\n" + string.Join("~", RM.RecipeIngredients.Text);

            string FormattedDirections = ":RecipeDirections\n" + string.Join("~", RM.RecipeDirections.Text);

            return $"{NameString}\n{DescriptionString}\n{FormattedIngredients}\n{FormattedDirections}";
        }

        public string Save_Recipe(string RecipeName, MainForm RM)
        {
            if (File.Exists(RecipsioRecipesFolder))
            {
                DialogResult Result = Send_Message_Box("Would you like to rewrite the recipe?",
                                                       "Recipe exists",
                                                       MessageBoxButtons.YesNo);
                if (Result == DialogResult.Yes)
                {
                    RecipeFile = $"{RecipsioRecipesFolder}\\{RM.CurrentRecipe!.Replace(" ", "-")}.recipe";
                    File.WriteAllText(RecipeFile!, Build_File_Formatted_String(RM));
                    return "Old";
                }
            }
            else
            {
                RecipeFile = $"{RecipsioRecipesFolder}\\{RecipeName.Replace(" ", "-")}.recipe";
                File.WriteAllText(RecipeFile, Build_File_Formatted_String(RM));
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
