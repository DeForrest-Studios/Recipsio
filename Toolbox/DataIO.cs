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
        public static readonly string RecipsioImagesFolder = Path.Combine(RecipsioFolder, "Images");
        public static readonly string RecipsioUserSettingsFile = Path.Combine(RecipsioFolder, "Settings.recipsio");
        public static readonly string RecipsioIngredientsFile = Path.Combine(RecipsioFolder, "Ingredients.recipsio");
        public static readonly string RecipsioTagsFile = Path.Combine(RecipsioFolder, "Tags.recipsio");

        public void Generate_User_Directories()
        {
            Directory.CreateDirectory(RecipsioFolder);
            Directory.CreateDirectory(RecipsioRecipesFolder);
            if (!File.Exists(RecipsioUserSettingsFile))
            {
                File.WriteAllText(RecipsioUserSettingsFile, "");
            }
            if (!File.Exists(RecipsioIngredientsFile))
            {
                File.WriteAllText(RecipsioIngredientsFile, "");
            }
            if (!File.Exists(RecipsioTagsFile))
            {
                File.WriteAllText(RecipsioTagsFile, "");
            }
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
            string NameString = $":Name\n{RM.RecipeName.Text}";

            string AuthorString = $":Author\n{RM.RecipeAuthor.Text}";

            string DescriptionString = $":Description\n{RM.RecipeDescription.Text}";

            return $"{NameString}\n{AuthorString}\n{DescriptionString}";
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
