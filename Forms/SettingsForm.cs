using System.Diagnostics;
using System.Windows.Forms;

namespace Recipsio
{
    public partial class SettingsForm : Form
    {
        public MainForm MF;
        public Toolbox TB;
        public SettingsForm(MainForm MF, Toolbox TB)
        {
            this.MF = MF;
            this.TB = TB;
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
