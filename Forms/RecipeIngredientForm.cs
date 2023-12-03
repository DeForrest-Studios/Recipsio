using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace Recipsio
{
    public partial class RecipeIngredientForm : Form
    {
        public MainForm MF;
        public Toolbox TB;

        public RecipeIngredientForm(MainForm MF, Toolbox TB)
        {
            this.MF = MF;
            this.TB = TB;

            InitializeComponent();
            KeyPreview = true;

            MeasurementChoice.DropDownWidth = 140;

            foreach (Ingredient Ingredient in TB.Ingredients.Values)
            {
                IngredientChoice.Items.Add(Ingredient.Name);
            }
        }
        private void Form_KeyDown(object Sender, KeyEventArgs KeyEvent)
        {
            if (KeyEvent.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
        private void Add_Recipe_Ingredient_Click(object sender, System.EventArgs e)
        {
            string ErrorMessage = TB.Is_Valid_Ingredient(this);
            if (ErrorMessage == "")
            {
                Ingredient ChosenIngredient = TB.Ingredients[IngredientChoice.SelectedItem.ToString()!];
                MF.RecipeIngredients.Items.Add($"{MeasurementAmount.Text} {MeasurementChoice.Text} ~ {ChosenIngredient.Name}");
                Close();
            }
            else
            {
                TB.Send_Message_Box($"Required fields: {ErrorMessage}", "Invalid Ingredient");
            }
            

        }
    }
}
