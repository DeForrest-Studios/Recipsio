using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Recipsio
{
    public partial class MainForm : Form
    {
        public string? CurrentRecipe;
        public Toolbox TB;

        public MainForm()
        {
            TB = new Toolbox(this);

            foreach (Control C in TB.Get_All_Controls(this, null!))
            {
                C.AutoSize = true;
            }

            InitializeComponent();
            TB.Generate_User_Directories();
            TB.Load_Recipes(ref RecipeList);
            TB.Load_Ingredients();
            KeyPreview = true;

        }

        private void Create_New_Recipe_Click(object Sender, EventArgs E)
        {
            TB.Clear_Content_Boxes();
            CurrentRecipe = "";
            RecipeList.SelectedItem = null;
        }
        private void Save_Recipe_Click(object Sender, EventArgs E)
        {
            if (TB.Is_Valid_Recipe())
            {
                if (TB.Save_Recipe(RecipeName.Text, this) == "New")
                {
                    RecipeList.Items.Add(RecipeName.Text);
                }
            }
        }
        private void Delete_Recipe_Click(object Sender, EventArgs E)
        {
            if (CurrentRecipe == null) { return; }
            CurrentRecipe = RecipeList.SelectedItem.ToString()!;
            TB.Delete_Recipe(CurrentRecipe);
            TB.Clear_Content_Boxes();
            RecipeList.Items.Remove(CurrentRecipe);
            RecipeList.SelectedItem = null;
        }
        private void Time_Mouse_Click(object Sender, MouseEventArgs ME)
        {
            Label Label = (Label)Sender;

            if (ME.Button == MouseButtons.Left)
            {
                GroupBox LabelGroupBox = (GroupBox)Label.Parent;
                RichTextBox Input = new();

                Input.KeyDown += new KeyEventHandler(Input_Time_Key_Down);

                int InputX = RecipeHeaderLayout.Location.X + LabelGroupBox.Location.X + Label.Left + 16;
                int InputY = RecipeHeaderLayout.Location.Y + LabelGroupBox.Bottom + 5;

                Point InputLocation = new(InputX, InputY);

                Input.Location = InputLocation;
                Input.Multiline = false;
                Input.Size = new(30, 20);
                Input.Tag = Label.Name;
                Input.Leave += Time_Leave!;

                Controls.Add(Input);

                Input.Focus();
                Input.BringToFront();
            }
        }
        private void Control_Mouse_Click(object Sender, MouseEventArgs ME)
        {
            if (ActiveControl is RichTextBox)
            {
                RichTextBox RTC = (RichTextBox)ActiveControl;
                ActiveControl = RecipeList;
                RecipeList.Focus();
            }
        }
        private void RecipeList_Selected_Value_Changed(object Sender, EventArgs E)
        {
            if (RecipeList.SelectedItem == null) return;

            TB.Clear_Content_Boxes();

            CurrentRecipe = RecipeList.SelectedItem.ToString()!;

            TB.Load_Recipe(CurrentRecipe);
        }
        private void RichTextBox_Key_Down(object Sender, KeyEventArgs KE)
        {
            RichTextBox RichTextBox = (RichTextBox)Sender;

            if (KE.Control && KE.KeyCode == Keys.B)
            {
                RichTextBox.SelectionBullet = true;
            }
        }
        private void Recipsio_Key_Down(object Sender, KeyEventArgs KE)
        {
            if (KE.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
        private void Input_Time_Key_Down(object? Sender, KeyEventArgs KE)
        {
            RichTextBox Input;
            Label InputTimeLabel;
            if (KE.KeyCode == Keys.Enter)
            {
                KE.SuppressKeyPress = true;
                Input = (RichTextBox)Sender!;
                InputTimeLabel = (Label)Controls.Find(Input.Tag.ToString(), true)[0];
                InputTimeLabel.Text = $"{Input.Text} {InputTimeLabel.Tag}";
                TB.Update_Times();
                Controls.Remove(Input);

            }
        }
        private void Time_Leave(object Sender, EventArgs E)
        {
            RichTextBox Control = (RichTextBox)Sender;
            Controls.Remove(Control);
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
        private void Search_Leave(object Sender, EventArgs E)
        {
            if (Search.Text == "")
            {
                Search.Text = "Search...";
            }
        }

        private void Search_Enter(object Sender, EventArgs E)
        {
            if (Search.Text == "Search...")
            {
                Search.Text = "";
            }
        }

        private void Search_Text_Changed(object Sender, EventArgs E)
        {

        }
        private void Add_Recipe_Ingredient_Click(object Sender, EventArgs E)
        {
            RecipeIngredientForm AIF = new(this, TB);
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
            RecipeDirectionForm RDF = new(this, TB);
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