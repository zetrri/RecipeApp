using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;
using System.IO;
using System.Globalization;

namespace FinalRecipeApp.BackEnd
{
    class ClassRecipes
    {


        public List<RecipeModel> get_Recipes()
        {


            if (File.Exists("recept.xml"))
            {


                XElement recept = XElement.Load("recept.xml");
                List<RecipeModel> mylist = new List<RecipeModel>();

                foreach (var item in recept.Descendants("receptnamn"))
                {
                    List<IngModel> inglist = new List<IngModel>();
                    var Parent = item.Parent;
                    var adding = new RecipeModel()
                    {
                        Name = item.Value.ToString(),

                    };
                    var temp = Parent.Descendants("portioner").First().Value.ToString();
                    adding.portioner = Int32.Parse(temp);
                    adding.tagg = Parent.Descendants("taggar").Descendants("tagg").First().Value.ToString();
                    foreach (var item2 in Parent.Descendants("ingredienser").Elements())
                    {
                        var ingrediens = new IngModel();

                        ingrediens.Name = item2.Element("namn").Value.ToString();

                        ingrediens.Antal = System.Convert.ToDecimal(item2.Element("antal").Value.ToString());
                        ingrediens.Enhet = item2.Element("enhet").Value.ToString();

                        inglist.Add(ingrediens);

                    }
                    adding.ingrediens = inglist;
                    mylist.Add(adding);
                }
                mylist.Sort(new NameComparer2());

                return mylist;
            }
            List<RecipeModel> mylist1 = new List<RecipeModel>();
            return mylist1;
        }

        public bool add_recipe(string name, int port, List<string> tagg, List<IngModel> ingredienser)
        {



            if (!File.Exists("recept.xml"))
            {
                var startelement = new XElement("recepten");
                startelement.Save("recept.xml");
            }

            var doc = XDocument.Load("recept.xml");


            var newElement = new XElement("recept",
                new XElement("receptnamn", name),
                new XElement("portioner", port),
                new XElement("taggar"),
                new XElement("ingredienser"));
            foreach (var tags in tagg)
            {
                newElement.Element("taggar").Add(new XElement("tagg", tags));
            }
            foreach (var item in ingredienser.AsEnumerable())
            {
                newElement.Element("ingredienser").Add(new XElement("ingrediens", new XElement("namn", item.Name),
                    new XElement("antal", item.Antal),
                    new XElement("enhet", item.Enhet)));
            }
            doc.Element("recepten").Add(newElement);
            doc.Save("recept.xml");
            return true;

        }
        public void remove_recipe(string name)
        {
            XElement root = XElement.Load("recept.xml");
            foreach (var item in root.Elements("recept").Elements("receptnamn"))
            {
                if (item.Value == name)
                {
                    item.Parent.Remove();
                }
            }
            root.Descendants().Where(e => string.IsNullOrEmpty(e.Value)).Remove();
            root.Save("recept.xml");
        }


        public List<IngModel> ingredientsinRecipe(string recipe)
        {

            List<RecipeModel> recipes = get_Recipes();
            RecipeModel choosedrecipe = recipes.Find(x => x.Name == recipe);
            return choosedrecipe.ingrediens;
        }

        public RecipeModel GetRecipe(string name)
        {
            List<RecipeModel> recipes = get_Recipes();
            return recipes.Find(x => x.Name == name);

        }

    }


    public class NameComparer2 : IComparer<RecipeModel>
    {

        public int Compare(RecipeModel x, RecipeModel y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }

}
