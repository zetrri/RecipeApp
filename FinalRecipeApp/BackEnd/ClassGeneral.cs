using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using MySql.Data.MySqlClient;

namespace FinalRecipeApp.BackEnd
{
    public class ClassGeneral
    {

        public void WriteToFile(List<IngModel> IngredientsTotal)
        {
            
                using (TextWriter textwriter = new StreamWriter("Matlista.csv",false)) 
            {
                textwriter.WriteLine($"Recept:");
                //List<IngModel> IngredientsTotal = new List<IngModel>();
                //foreach(var recipe in SelectedRecipes)
                //{
                //textwriter.WriteLine(recipe.Name.ToString());
                //textwriter.WriteLine($" ");
                //foreach (var ingredients in SelectedRecipes)
                //{

                //    var temp = IngredientsTotal.Find(x => x.Name == ingredients.Name);
                //    if ((IngredientsTotal.Find(x => x.Name == ingredients.Name)) != null)
                //    {
                //        IngredientsTotal.Remove(temp);

                //        temp.Antal = decimal.Add(temp.Antal, ingredients.Antal);
                //        IngredientsTotal.Add(temp);
                //        System.Console.WriteLine("here");
                //    }
                //    else
                //    {
                //        IngredientsTotal.Add(ingredients);
                //    }
                //    // }

                //    //textwriter.WriteLine($" ");
                //}
                foreach (var ingredients in IngredientsTotal)
                {
                    textwriter.WriteLine($"{ingredients.Name.ToString()};{ingredients.Antal.ToString()};{ingredients.Enhet.ToString()}")
                    ;
                }
                if (BackEnd.ClassSql.conn_status == true)
                {
                    var cmd = new MySqlCommand();
                    cmd.Connection = BackEnd.ClassSql.auth;

                    cmd.CommandText = "DROP TABLE IF EXISTS List";
                    cmd.ExecuteNonQuery();


                    cmd.CommandText = @"CREATE TABLE List(id INTEGER PRIMARY KEY AUTO_INCREMENT,
                    Namn TEXT, Antal TEXT)";
                    cmd.ExecuteNonQuery();
                    foreach (var ingredients in IngredientsTotal)
                    {
                        cmd.CommandText = $"INSERT INTO List(Namn, Antal) VALUES('{ingredients.Name.ToString()}','{ingredients.Antal.ToString() + " " + ingredients.Enhet.ToString()}')";
                        Console.WriteLine(cmd.CommandText.ToString());
                        cmd.ExecuteNonQuery();

                    }
                }
            }
            
            Process.Start("Matlista.csv");
        }
    }
}
