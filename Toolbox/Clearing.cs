using System.Windows.Forms;

namespace RecipeManager
{
   public partial class Toolbox
    {
        public void Clear_Times(GroupBox GroupBox)
        {
            foreach (Control Control in GroupBox.Controls)
            {
                Label TimeLabel = (Label)Control;
                Control.Text = $"0 {TimeLabel.Tag}";
            }
        }
        public void Clear_Content_Boxes()
        {
            MF.RecipeName.Text = "";
            Clear_Times(MF.PrepTimeGroup);
            Clear_Times(MF.CookTimeGroup);
            MF.RecipeDescription.Text = "";
            MF.RecipeIngredients.Text = "";
            MF.RecipeDirections.Text = "";
        }
    }
}
