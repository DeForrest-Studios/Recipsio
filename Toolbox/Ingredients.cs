using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Recipsio
{
    public partial class Toolbox
    {
        public Dictionary<string, Ingredient> Ingredients = new();

        public void Load_Ingredients()
        {
            foreach (string Line in File.ReadLines(RecipsioIngredientsFile))
            {
                string[] IngredientData = Line.Split("~");
                Ingredient LoadedIngredient = new(IngredientData[0], Convert.ToDouble(IngredientData[1]));
                Ingredients.Add(LoadedIngredient.Name, LoadedIngredient);
            }
        }

        public void Save_Ingredient(string IngredientName, double IngredientCost)
        {
            File.AppendAllText(RecipsioIngredientsFile, $"{IngredientName}~{IngredientCost}");
        }

        public void Remove_Saved_Ingredient(string IngredientName)
        {
            List<string> FileContent = File.ReadLines(RecipsioIngredientsFile!).ToList();
            for (int Index =  0; Index < FileContent.Count; Index++)
            {
                if (FileContent[Index].StartsWith(IngredientName))
                {
                    FileContent.RemoveAt(Index);
                    File.WriteAllLines(RecipsioIngredientsFile, FileContent);
                    break;
                }
            }
        }
    }

    public class Ingredient
    {
        public string Name;
        public double Cost;
        public Ingredient(string Name, double Cost = 0.00)
        {
            this.Name = Name;
            this.Cost = Cost;
        }
    }
}