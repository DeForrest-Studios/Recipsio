﻿using System.Windows.Forms;

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
            MF.RecipeName.Text = "";
            MF.RecipeAuthor.Text = "";
            Clear_Times(MF.PrepTime);
            Clear_Times(MF.CookTime);
            MF.TotalTimeValue.Text = "0 Days 0 Hours 0 Minutes";
            MF.RecipeDescription.Text = "";
            MF.RecipeIngredients.Items.Clear();
        }
    }
}
