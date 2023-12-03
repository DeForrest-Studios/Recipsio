using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Recipsio
{
    public partial class Toolbox
    {
        public static string Build_File_Formatted_Recipe(MainForm RM)
        {
            string NameString = $":Name\n{RM.RecipeName.Text}";

            string AuthorString = $":Author\n{RM.RecipeAuthor.Text}";

            string DescriptionString = $":Description\n{RM.RecipeDescription.Text}";

            return $"{NameString}\n{AuthorString}\n{DescriptionString}";
        }
        public string[] Load_Recipe(string CurrentRecipe)
        {
            RecipeFile = $"{RecipsioRecipesFolder}\\{CurrentRecipe.Replace(" ", "-")}.recipe";

            return File.ReadAllLines(RecipeFile);
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
                    File.WriteAllText(RecipeFile!, Build_File_Formatted_Recipe(RM));
                    return "Old";
                }
            }
            else
            {
                RecipeFile = $"{RecipsioRecipesFolder}\\{RecipeName.Replace(" ", "-")}.recipe";
                File.WriteAllText(RecipeFile, Build_File_Formatted_Recipe(RM));
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