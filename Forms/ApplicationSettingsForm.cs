using System.Diagnostics;
using System.Windows.Forms;

namespace Recipsio
{
    public partial class ApplicationSettingsForm : Form
    {
        public MainForm MF;
        public Toolbox TB;
        public ApplicationSettingsForm(MainForm MF, Toolbox TB)
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

        private void Load_Application_Settings(object sender, System.EventArgs e)
        {
        }
        private void Load_Editor_Settings(object sender, System.EventArgs e)
        {
            EditorSettings ES = new(MF, TB);
            SettingsLayout.Controls.Add(ES, 1, 0);
            SettingsLayout.SetRowSpan(ES, SettingsLayout.RowCount);
        }
    }
}
