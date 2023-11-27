using System.Collections.Generic;
using System.Windows.Forms;

namespace Recipsio
{
    public partial class Toolbox
    {
        public bool Is_Valid_Recipe()
        {
            List<string> EmptyFieldTags = new();

            foreach (Control RecipeManagerControl in MF.Controls)
            {
                if (RecipeManagerControl is GroupBox GroupBox)
                {
                    foreach (Control GroupBoxControl in GroupBox.Controls)
                    {
                        if (GroupBoxControl is RichTextBox GroupBoxRichTextBox)
                        {
                            if (GroupBoxRichTextBox.Text == "")
                            {
                                EmptyFieldTags.Add(GroupBoxRichTextBox.Tag.ToString()!);
                            }
                        }
                    }
                }
            }

            if (EmptyFieldTags.Count != 0)
            {
                Send_Message_Box(string.Join(", ", EmptyFieldTags) + " are required fields", "Found Empty Fields");
                return false;
            }

            return true;
        }
    }
}