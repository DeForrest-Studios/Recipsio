using System.Diagnostics;
using System.Windows.Forms;

namespace Recipsio
{
    public partial class AddIngredientForm : Form
    {
        public AddIngredientForm()
        {
            InitializeComponent();
            KeyPreview = true;

            MeasurementChoice.DropDownWidth = 140;
        }
        private void Form_KeyDown(object Sender, KeyEventArgs KeyEvent)
        {
            if (KeyEvent.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}
