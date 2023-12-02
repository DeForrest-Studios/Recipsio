using System.Diagnostics;
using System.Windows.Forms;

namespace Recipsio
{
    public partial class ApplicationIngredientsForm : Form
    {
        public MainForm MF;
        public Toolbox TB;
        public ApplicationIngredientsForm(MainForm MF, Toolbox TB)
        {
            this.MF = MF;
            this.TB = TB;
            InitializeComponent();
            KeyPreview = true;

            foreach (Ingredient I in TB.Ingredients.Values)
            {
                IngredientsList.Items.Add(I.Name);
            }

        }
        private void Form_KeyDown(object Sender, KeyEventArgs KeyEvent)
        {
            if (KeyEvent.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void AddIngredients_Click(object sender, System.EventArgs e)
        {
            if (IngredientInput.Text != "")
            {
                if (TB.Ingredients.ContainsKey(IngredientInput.Text))
                {
                    TB.Send_Message_Box("Ingredient already exists.", "");
                }
                else
                {
                    Ingredient NewIngredient = new Ingredient(IngredientInput.Text);
                    TB.Ingredients.Add(NewIngredient.Name, NewIngredient);
                    IngredientsList.Items.Add(NewIngredient.Name);
                    IngredientInput.Clear();
                    TB.Save_Ingredient(NewIngredient.Name, NewIngredient.Cost);
                }
            }
        }

        private void RemoveIngredient_Click(object sender, System.EventArgs e)
        {
            if (IngredientsList.SelectedItem != null)
            {
                string Ingredient = IngredientsList.SelectedItem.ToString()!;
                TB.Ingredients.Remove(Ingredient);
                IngredientsList.Items.Remove(Ingredient);
                TB.Remove_Saved_Ingredient(Ingredient);
            }
        }
    }
}
