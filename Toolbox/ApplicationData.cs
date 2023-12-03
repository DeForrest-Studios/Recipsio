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
    }
}
