using System.Windows.Forms;

namespace Recipsio
{
   public partial class Toolbox
    {
        public void Clear_Times(GroupBox GB)
        {
            foreach (Control Control in GB.Controls)
            {
                Label TimeLabel = (Label)Control;
                Control.Text = $"0 {TimeLabel.Tag}";
            }
        }
        public void Clear_Content_Boxes()
        {
            MF.Header.RecipeName.Text = "";
            MF.Header.RecipeAuthor.Text = "";
            Clear_Times(MF.Header.PrepTimeBox);
            Clear_Times(MF.Header.CookTimeBox);
            MF.Header.TotalTimeValue.Text = "0 Days 0 Hours 0 Minutes";
            MF.Information.RecipeDescription.Text = "";
            MF.Information.RecipeIngredients.Items.Clear();
        }
    }
}
