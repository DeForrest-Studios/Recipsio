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
            InitializeComponent();
            TB = new Toolbox(this);

            foreach (Control C in TB.Get_All_Controls(this, null!))
            {
                C.AutoSize = true;
            }
            Header.MF = this;
            Header.TB = TB;
            Information.MF = this;
            Information.TB = TB;
            Tools.MF = this;
            Tools.TB = TB;
            TB.Generate_User_Directories();
            TB.Load_Recipes(ref RecipeList);
            TB.Load_Ingredients();
            KeyPreview = true;

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

            //TB.Load_Recipe(CurrentRecipe);
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
    }
}