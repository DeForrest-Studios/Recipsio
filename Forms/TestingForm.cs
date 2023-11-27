using System.Diagnostics;
using System.Windows.Forms;

namespace Recipsio
{
    public partial class TestingForm : Form
    {
        public TestingForm()
        {
            InitializeComponent();
            KeyPreview = true;
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
