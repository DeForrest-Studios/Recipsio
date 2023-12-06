using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            List<string> Exclusions = new()
            { "DescriptionLabel",
              "IngredientsLabel",
              "DirectionsLabel",
              "MainToolStrip",
            };

            MF.Font = new Font("Arial", (float)FontSizeControl.Value);

            foreach (Control C in TB.Get_All_Controls(MF, Exclusions))
            {
                C.Font = new Font("Arial", (float)FontSizeControl.Value);
                Debug.WriteLine($"{C.Name}: {C.Font.Size}");
            }
        }
    }
}
