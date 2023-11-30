using System.Collections.Generic;
using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace Recipsio
{
    public partial class Toolbox
    {
        public List<Control> AllControls = new();
        public Dictionary<string, Control> ControlToTagMap = new();
        private void GetAllControls(Control Control, List<Control> ControlList)
        {
            ControlList.Add(Control);

            foreach (Control ChildControl in Control.Controls)
            {
                GetAllControls(ChildControl, ControlList);
            }
        }

        public void Generate_Controls_To_Tags()
        {
            GetAllControls(MF, AllControls);

            foreach (Control Control in AllControls)
            {
                if (Control != null && Control.Tag != null)
                {
                    ControlToTagMap.Add(Control.Tag.ToString()!, Control);
                }
            }
            
            foreach (KeyValuePair<string, Control> ControlToTag in ControlToTagMap)
            {
                Debug.WriteLine(ControlToTag);
            }
        }
    }
}