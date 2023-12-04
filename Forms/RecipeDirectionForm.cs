using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Recipsio
{
    public partial class RecipeDirectionForm : Form
    {
        public MainForm MF;
        public Toolbox TB;
        public RecipeDirectionForm(MainForm MF, Toolbox TB)
        {
            this.MF = MF;
            this.TB = TB;
            InitializeComponent();
            KeyPreview = true;
        }
        private void Form_KeyDown(object Sender, KeyEventArgs KE)
        {
            if (KE.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void Submit_Recipe_Direction_Click(object Sender, EventArgs E)
        {
            if (RecipeDirection.Text != "")
            {
                MF.RecipeDirections.Items.Add(RecipeDirection.Text);
                Close();
            }
            else
            {
                TB.Send_Message_Box("You cannot submit an empty description", "Empty Direction");
            }
        }
    }
}
