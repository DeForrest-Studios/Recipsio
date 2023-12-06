using System.Windows.Forms;
using System.Collections.Generic;

namespace Recipsio
{
    public partial class Toolbox
    {
        public MainForm MF;
        public Toolbox(MainForm MFPassed) => MF = MFPassed;

        public List<Control> Get_All_Controls(Control PassedControl, List<string> Exclusions)
        {
            List<Control> AllControls = new();

            foreach (Control C in PassedControl.Controls)
            {
                if (!Exclusions.Contains(C.Name))
                {
                    AllControls.Add(C);
                    if (C.HasChildren)
                    {
                        foreach (Control InnerControl in Get_All_Controls(C, Exclusions))
                        {
                            if (!Exclusions.Contains(C.Name))
                            {
                                AllControls.Add(InnerControl);
                            }
                        }
                    }
                }

            }

            return AllControls;
        }

    }
}