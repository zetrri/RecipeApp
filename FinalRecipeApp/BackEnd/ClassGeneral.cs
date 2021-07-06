using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace FinalRecipeApp.BackEnd
{
    public class ClassGeneral
    {

        public void WriteToFile(List<RecipeModel> SelectedRecipes)
        {
            using (TextWriter textwriter = new StreamWriter("Matlista.csv",false)) 
            {
                textwriter.WriteLine($"Recept:");
                List<IngModel> IngredientsTotal = new List<IngModel>();
                foreach(var recipe in SelectedRecipes)
                {
                    textwriter.WriteLine(recipe.Name.ToString());
                    //textwriter.WriteLine($" ");
                    foreach (var ingredients in recipe.ingrediens)
                    {
                        
                        var temp = IngredientsTotal.Find(x => x.Name == ingredients.Name);
                        if ((IngredientsTotal.Find(x => x.Name == ingredients.Name)) != null ) 
                        {
                            IngredientsTotal.Remove(temp);
                            temp.Antal += ingredients.Antal;
                            IngredientsTotal.Add(temp);
                            System.Console.WriteLine("here");
                        }
                        else
                        {
                            IngredientsTotal.Add(ingredients);
                        }
                    }
                    
                    //textwriter.WriteLine($" ");
                }
                foreach (var ingredients in IngredientsTotal)
                {
                    textwriter.WriteLine($"{ingredients.Name.ToString()};{ingredients.Antal.ToString()};{ingredients.Enhet.ToString()}")
                    ;
                }
            }
            Process.Start("Matlista.csv");
        }
    }
}
