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
    public partial class RecipeInformation : UserControl
    {
        public MainForm? MF;
        public Toolbox? TB;
        public RecipeInformation()
        {
            InitializeComponent();
        }
        private void Add_Recipe_Ingredient_Click(object Sender, EventArgs E)
        {
            RecipeIngredientForm AIF = new(MF!, TB!);
            AIF.ShowDialog(this);
        }
        private void Remove_Ingredient_Click(object Sender, EventArgs E)
        {
            if (RecipeIngredients.SelectedItem != null)
            {
                RecipeIngredients.Items.Remove(RecipeIngredients.SelectedItem);
            }
        }
        private void Add_Recipe_Description_Click(object Sender, EventArgs e)
        {
            RecipeDirectionForm RDF = new(MF!, TB!);
            RDF.ShowDialog(this);
        }
        private void Remove_Recipe_Description_Click(object Sender, EventArgs e)
        {
            if (RecipeDirections.SelectedItem != null)
            {
                RecipeDirections.Items.Remove(RecipeDirections.SelectedItem);
            }
        }
    }
}
