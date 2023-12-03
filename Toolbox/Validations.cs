using Microsoft.Identity.Client;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Recipsio
{
    public partial class Toolbox
    {
        public List<dynamic> RecipeFields = new();
        public string Is_Valid_Ingredient(RecipeIngredientForm RIF)
        {
            List<string> EmptyFields = new();
            if (RIF.MeasurementAmount.Text == "")
            {
                EmptyFields.Add("Measurement Amount");
            }
            if (RIF.MeasurementChoice.SelectedItem == null)
            {
                EmptyFields.Add("Measurement Type");
            }
            if (RIF.IngredientChoice.SelectedItem == null)
            {
                EmptyFields.Add("Ingedient");
            }
            return string.Join(", ", EmptyFields);
        }
        public bool Is_Valid_Recipe()
        {
            RecipeFields = new List<dynamic>
            {
                MF.RecipeName,
                MF.RecipeAuthor,
                MF.PrepTime,
                MF.CookTime,
                MF.RecipeDescription,
                MF.RecipeIngredients,
                MF.RecipeDirections,
            };

            List<string> EmptyFieldTags = new();

            foreach (dynamic Control in RecipeFields)
            {
                if (Control is RichTextBox RTC)
                {
                    if (RTC.Text == "")
                    {
                        EmptyFieldTags.Add(RTC.Tag.ToString()!);
                    }
                }
                if (Control is GroupBox GB)
                {
                    int Sum = 0;
                    foreach (Control C in GB.Controls)
                    {
                        if (C.Text.Split(" ")[0] != "0")
                        {
                            Sum++;
                        }
                    }
                    if (Sum == 0)
                    {
                        EmptyFieldTags.Add(GB.Tag.ToString()!);
                    }
                }
                if (Control is ListBox LB)
                {
                    if (LB.Controls.Count == 0)
                    {
                        EmptyFieldTags.Add(LB.Tag.ToString()!);
                    }
                }
            }

            if (EmptyFieldTags.Count != 0)
            {
                Send_Message_Box(string.Join(", ", EmptyFieldTags) + " seem to be unfulfilled.", "Found Unfulfilled Fields");
                return false;
            }

            return true;
        }
    }
}