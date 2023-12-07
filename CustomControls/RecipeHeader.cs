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
    public partial class RecipeHeader : UserControl
    {
        public MainForm? MF;
        public Toolbox? TB;

        public RecipeHeader()
        {
            InitializeComponent();
        }
        private void Time_Mouse_Click(object Sender, MouseEventArgs ME)
        {
            Label Label = (Label)Sender;

            if (ME.Button == MouseButtons.Left)
            {
                TableLayoutPanel LabelGroupBox = (TableLayoutPanel)Label.Parent;
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
    }
}
