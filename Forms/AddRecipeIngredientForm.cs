using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace Recipsio
{
    public partial class AddRecipeIngredientForm : Form
    {
        public MainForm MF;
        public Toolbox TB;

        public AddRecipeIngredientForm(MainForm MF, Toolbox TB)
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
        public string Is_Valid_Ingredient()
        {
            List<string> EmptyFields = new();
            if (MeasurementAmount.Text == "")
            {
                EmptyFields.Add("Measurement Amount");
            }
            if (MeasurementChoice.SelectedItem == null)
            {
                EmptyFields.Add("Measurement Type");
            }
            if (IngredientChoice.SelectedItem == null)
            {
                EmptyFields.Add("Ingedient");
            }
            return string.Join(", ", EmptyFields);

        }
        private void Add_Recipe_Ingredient_Click(object sender, System.EventArgs e)
        {
            string ErrorMessage = Is_Valid_Ingredient();
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
