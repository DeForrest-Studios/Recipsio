using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Recipsio
{
    public partial class MainForm : Form
    {
        public string? CurrentRecipe;
        public Toolbox Manager;

        public MainForm()
        {
            InitializeComponent();
            Manager = new Toolbox(this);
            Manager.Generate_User_Directories();
            Manager.Load_Recipes(ref RecipeList);
            Manager.Load_Ingredients();
            KeyPreview = true;
        }

        private void Create_New__Recipe_Click(object Sender, EventArgs Eventvent)
        {
            Manager.Clear_Content_Boxes();
            CurrentRecipe = "";
            RecipeList.SelectedItem = null;
        }
        private void Save_Recipe_Click(object Sender, EventArgs Eventvent)
        {
            if (Manager.Is_Valid_Recipe())
            {
                if (Manager.Save_Recipe(RecipeName.Text, this) == "New")
                {
                    RecipeList.Items.Add(RecipeName.Text);
                }
            }
        }
        private void Delete_Recipe_Click(object Sender, EventArgs Event)
        {
            if (CurrentRecipe == null) { return; }
            CurrentRecipe = RecipeList.SelectedItem.ToString()!;
            Manager.Delete_Recipe(CurrentRecipe);
            Manager.Clear_Content_Boxes();
            RecipeList.Items.Remove(CurrentRecipe);
            RecipeList.SelectedItem = null;
        }
        private void Time_Mouse_Click(object Sender, MouseEventArgs MouseEvent)
        {
            Label Label = (Label)Sender;

            if (MouseEvent.Button == MouseButtons.Left)
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
        private void Control_Mouse_Click(object Sender, MouseEventArgs MouseEvent)
        {
            if (ActiveControl is RichTextBox)
            {
                RichTextBox RTC = (RichTextBox)ActiveControl;
                ActiveControl = RecipeList;
                RecipeList.Focus();
            }
        }
        private void RecipeList_Selected_Value_Changed(object Sender, EventArgs Eventvent)
        {
            if (RecipeList.SelectedItem == null) return;

            Manager.Clear_Content_Boxes();

            CurrentRecipe = RecipeList.SelectedItem.ToString()!;

            Manager.Load_Recipe(CurrentRecipe);
        }
        private void RichTextBox_Key_Down(object Sender, KeyEventArgs KeyEvent)
        {
            RichTextBox RichTextBox = (RichTextBox)Sender;

            if (KeyEvent.Control && KeyEvent.KeyCode == Keys.B)
            {
                RichTextBox.SelectionBullet = true;
            }
        }
        private void Recipsio_Key_Down(object Sender, KeyEventArgs KeyEvent)
        {
            if (KeyEvent.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
        private void Input_Time_Key_Down(object? Sender, KeyEventArgs KeyEvent)
        {
            RichTextBox Input;
            Label InputTimeLabel;
            if (KeyEvent.KeyCode == Keys.Enter)
            {
                KeyEvent.SuppressKeyPress = true;
                Input = (RichTextBox)Sender!;
                InputTimeLabel = (Label)Controls.Find(Input.Tag.ToString(), true)[0];
                InputTimeLabel.Text = $"{Input.Text} {InputTimeLabel.Tag}";
                Manager.Update_Times();
                Controls.Remove(Input);

            }
        }
        private void Time_Leave(object Sender, EventArgs Event)
        {
            RichTextBox Control = (RichTextBox)Sender;
            Controls.Remove(Control);
        }

        private void Options_Click(object Sender, EventArgs Event)
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
            Form NewForm = (Form)Activator.CreateInstance(FormType!, this, Manager)!;
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
        private void Add_Ingredient_Click(object Sender, EventArgs Event)
        {
            RecipeIngredientForm AIF = new(this, Manager);
            AIF.ShowDialog(this);
        }
        private void Remove_Ingredient_Click(object Sender, EventArgs Event)
        {
            if (RecipeIngredients.SelectedItem != null)
            {
                RecipeIngredients.Items.Remove(RecipeIngredients.SelectedItem);
            }
        }
    }
    public partial class Toolbox
    {
        public MainForm MF;
        public Toolbox(MainForm MFPassed) => MF = MFPassed;

    }
}