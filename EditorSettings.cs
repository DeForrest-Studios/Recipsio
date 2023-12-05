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
    public partial class EditorSettings : UserControl
    {
        public MainForm MF;
        public Toolbox TB;
        public EditorSettings(MainForm MF, Toolbox TB)
        {
            this.MF = MF;
            this.TB = TB;
            InitializeComponent();
            FontSizeControl.Value = Convert.ToDecimal(MF.Font.Size);
        }

        private void Font_Size_Changed(object sender, EventArgs e)
        {
            MF.Font = new Font("Arial", (float)FontSizeControl.Value);
        }
    }
}
