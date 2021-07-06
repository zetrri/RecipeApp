using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;

namespace FinalRecipeApp.BackEnd
{
    public class Ingrediens
    {

        public List<IngModel> get_indregients()
        {
            XElement ingrediens = XElement.Load("ingredienser.xml");
            List<IngModel> mylist = new List<IngModel>();
            foreach (var item in ingrediens.Descendants("namn"))
            {

                var adding = new IngModel();
                //{ 
                //    Name = item.Value.ToString()
                //};
                adding.Name = item.Value.ToString();
                adding.Enhet = item.Parent.Descendants("enhet").First().Value.ToString();
                adding.typ = item.Parent.Descendants("typ").First().Value.ToString();

                mylist.Add(adding);
            }
            mylist.Sort(new NameComparer());

            return mylist;
        }

        public bool add_ing(string name, string unit, string type)
        {

            try
            {
                XDocument ingrediens = XDocument.Load("ingredienser.xml");
                if ((ingrediens.Descendants("ingrediens").Elements("namn").Where(x => x.Value == name).Any()))
                {
                    return false;
                }
                var root = new XElement("ingrediens",
                new XElement("namn", name),
                new XElement("enhet", unit),
                new XElement("typ", type));
                ingrediens.Element("ingredienser").Add(root);
                ingrediens.Save("ingredienser.xml");


            }
            catch
            {
                var root = new XElement("ingredienser",
                                new XElement("ingrediens",
                                new XElement("namn", name),
                                new XElement("enhet", unit),
                                new XElement("typ", type)));
                root.Save("ingredienser.xml");
            }
            return true;
        }
        public void remove_ing(string name)
        {
            XDocument root = XDocument.Load("ingredienser.xml");
            foreach (var item in root.Descendants())
            {
                if (item.Value == name)
                {
                    item.RemoveAll();
                }

            }
            root.Descendants().Where(e => string.IsNullOrEmpty(e.Value)).Remove();
            root.Save("ingredienser.xml");

        }
        public class NameComparer : IComparer<IngModel>
        {

            public int Compare(IngModel x, IngModel y)
            {
                return x.Name.CompareTo(y.Name);
            }
        }
    }
}
