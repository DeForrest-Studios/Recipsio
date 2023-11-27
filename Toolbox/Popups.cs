using System.Windows.Forms;

namespace Recipsio
{
    public partial class Toolbox
    {
        public DialogResult Send_Message_Box(string Message, string Title, MessageBoxButtons Type = MessageBoxButtons.OK)
        {
            DialogResult ClearResult = MessageBox.Show(Message, Title, Type);
            return ClearResult;
        }
    }
}