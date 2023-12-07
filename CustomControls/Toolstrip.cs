using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recipsio
{
    public partial class Toolstrip : UserControl
    {
        public MainForm? MF;
        public Toolbox? TB;
        public Toolstrip()
        {
            InitializeComponent();
        }
        private void Create_New_Recipe_Click(object Sender, EventArgs E)
        {
            TB.Clear_Content_Boxes();
            MF.CurrentRecipe = "";
            MF.RecipeList.SelectedItem = null;
        }
        private void Save_Recipe_Click(object Sender, EventArgs E)
        {
            if (TB.Is_Valid_Recipe())
            {
                if (TB.Save_Recipe(RecipeName.Text, MF) == "New")
                {
                    MF.RecipeList.Items.Add(RecipeName.Text);
                }
            }
        }
        private void Delete_Recipe_Click(object Sender, EventArgs E)
        {
            if (MF.CurrentRecipe == null) { return; }
            MF.CurrentRecipe = MF.RecipeList.SelectedItem.ToString()!;
            TB.Delete_Recipe(MF.CurrentRecipe);
            TB.Clear_Content_Boxes();
            MF.RecipeList.Items.Remove(MF.CurrentRecipe);
            MF.RecipeList.SelectedItem = null;
        }
        private void Options_Click(object Sender, EventArgs E)
        {
            Dictionary<string, Type> FormMap = new()
            {
                { "Images", typeof(ApplicationImagesForm) },
                { "Tags", typeof(ApplicationTagsForm) },
                { "Ingredients", typeof(ApplicationIngredientsForm) },
                { "Settings", typeof(ApplicationSettingsForm) },
                { "Help", typeof(ApplicationHelpForm) },
            };

            ToolStripItem ItemClicked = (ToolStripItem)Sender;
            _ = FormMap.TryGetValue(ItemClicked.Text, out Type? FormType);
            Form NewForm = (Form)Activator.CreateInstance(FormType!, this, TB)!;
            NewForm.ShowDialog();
        }
    }
}
