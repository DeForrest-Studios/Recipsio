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
        public Toolbox Manager;

        public MainForm()
        {
            InitializeComponent();
            Manager = new Toolbox(this);
            Manager.Generate_User_Directories();
            Manager.Load_Files(ref RecipeList);
            RecipeIngredients.SelectionBullet = true;
            RecipeDirections.SelectionBullet = true;
            KeyPreview = true;
        }

        private void CreateNew_Click(object Sender, EventArgs E)
        {
            Manager.Clear_Content_Boxes();
            CurrentRecipe = "";
            RecipeList.SelectedItem = null;
        }
        private void Save_Click(object Sender, EventArgs E)
        {
            if (Manager.Is_Valid_Recipe())
            {
                if (Manager.Save_Recipe(RecipeName.Text, this) == "New")
                {
                    RecipeList.Items.Add(RecipeName.Text);
                }
            }
        }
        private void Delete_Click(object Sender, EventArgs E)
        {
            if (CurrentRecipe == null) { return; }
            CurrentRecipe = RecipeList.SelectedItem.ToString()!;
            Manager.Delete_Recipe(CurrentRecipe);
            Manager.Clear_Content_Boxes();
            RecipeList.Items.Remove(CurrentRecipe);
            RecipeList.SelectedItem = null;
        }
        private void Time_MouseClick(object Sender, MouseEventArgs MouseEvent)
        {
            Label Label = (Label)Sender;

            if (MouseEvent.Button == MouseButtons.Left)
            {
                GroupBox LabelGroupBox = (GroupBox)Label.Parent;
                RichTextBox Input = new();

                Input.KeyDown += new KeyEventHandler(Input_Time_KeyDown);

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
        private void Control_MouseClick(object Sender, MouseEventArgs MouseEvent)
        {
            if (ActiveControl is RichTextBox)
            {
                RichTextBox RTC = (RichTextBox)ActiveControl;
                ActiveControl = RecipeList;
                RecipeList.Focus();
            }
        }
        private void RecipeList_SelectedValueChanged(object Sender, EventArgs Event)
        {
            if (RecipeList.SelectedItem == null) return;

            Manager.Clear_Content_Boxes();

            CurrentRecipe = RecipeList.SelectedItem.ToString()!;

            string[] Lines = Manager.Load_File(CurrentRecipe);

            string DataState;
            Control? FoundControl = null;

            for (int Index = 0; Index < Lines.Length; Index++)
            {
                if (Lines[Index][0] == ':')
                {
                    DataState = Lines[Index][1..];
                    FoundControl = Controls.Find(DataState, true)[0];
                }
                else if (Index == (Lines.Length - 1))
                {
                    FoundControl!.Text += Lines[Index];
                }
                else
                {
                    FoundControl!.Text += Lines[Index] + "\n";
                }
            }
            RecipeIngredients.Text = RecipeIngredients.Text[0..(RecipeIngredients.Text.Length - 1)];
        }
        private void RichText_KeyDown(object Sender, KeyEventArgs KeyEvent)
        {
            RichTextBox RichTextBox = (RichTextBox)Sender;

            if (KeyEvent.Control && KeyEvent.KeyCode == Keys.B)
            {
                RichTextBox.SelectionBullet = true;
            }
        }
        private void RecipeManager_KeyDown(object Sender, KeyEventArgs KeyEvent)
        {
            if (KeyEvent.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
        private void Input_Time_KeyDown(object? Sender, KeyEventArgs KeyEvent)
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
        private void Time_Leave(object Sender, EventArgs E)
        {
            RichTextBox Control = (RichTextBox)Sender;
            Controls.Remove(Control);
        }

        private void Options_Click(object Sender, EventArgs E)
        {
            Dictionary<string, Type> FormMap = new()
            {
                { "Images", typeof(ImagesForm) },
                { "Tags", typeof(TagsForm) },
                { "Ingredients", typeof(IngredientsForm) },
                { "Settings", typeof(SettingsForm) },
                { "Help", typeof(HelpForm) },
            };

            ToolStripItem ItemClicked = (ToolStripItem)Sender;
            _ = FormMap.TryGetValue(ItemClicked.Text, out Type? FormType);
            Form NewForm = (Form)Activator.CreateInstance(FormType!)!;
            NewForm.ShowDialog();
        }
        public void Search_Leave(object sender, EventArgs e)
        {
            if (Search.Text == "")
            {
                Search.Text = "Search...";
            }
        }

        public void Search_Enter(object sender, EventArgs e)
        {
            if (Search.Text == "Search...")
            {
                Search.Text = "";
            }
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {

        }
    }
    public partial class Toolbox
    {
        public MainForm MF;
        public Toolbox(MainForm MFPassed) => MF = MFPassed;
    }
}