using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalRecipeApp.Forms
{
    public partial class FormFoodlist : Form
    {
        BackEnd.ClassRecipes classRecipes = new BackEnd.ClassRecipes();
        List<ComboBox> comboBoxes = new List<ComboBox>();
        List<TextBox> textBoxes = new List<TextBox>();
        List<BackEnd.RecipeModel> Recipes = new List<BackEnd.RecipeModel>();
        BackEnd.ClassGeneral general = new BackEnd.ClassGeneral();
        List<BackEnd.IngModel> ingredients = new List<BackEnd.IngModel>();
        

        public FormFoodlist()
        {
            InitializeComponent();
            combineComboBox();
            Recipes = classRecipes.get_Recipes();
            update_list();
            
            
        }

        //private List<BackEnd.RecipeModel> get_recipes()
        //{
        //    //Ingrediens ingrediens = new Ingrediens();
        //    List<BackEnd.RecipeModel> mylist = new List<BackEnd.RecipeModel>();
        //    mylist = classRecipes.get_Recipes();

        //    return mylist;
        //}

        private void update_list()
        {
        
            //List<BackEnd.RecipeModel> mylist = new List<BackEnd.RecipeModel>();
            //List<ComboBox> comboBoxes = new List<ComboBox>();
            //comboBoxes = combineComboBox();
            //mylist = get_recipes();
            foreach(var box in comboBoxes)
            {
                foreach(var item in Recipes)
                {
                    box.Items.Add(item.Name);
                }
            }
        }

        private void combineComboBox()
        {
            
            comboBoxes.Add(comboBox_monday);
            comboBoxes.Add(comboBox_tuesday);
            comboBoxes.Add(comboBox_wednesday);
            comboBoxes.Add(comboBox_thursday);
            comboBoxes.Add(comboBox_friday);
            comboBoxes.Add(comboBox_saturday);
            comboBoxes.Add(comboBox_sunday);
            //return comboBoxes;
            textBoxes.Add(textBox_AddUnknownAmount);
            textBoxes.Add(textBox_addUnknownName);
            textBoxes.Add(textBox_AddUnknownUnit);
            textBoxes.Add(textBox_ingredient_amount);
        }
        

        private void buildStatList(List<BackEnd.RecipeModel> SelectedRecipes)
        {
            int antal_portioner = 0;
            foreach (var item in SelectedRecipes)
            {
                antal_portioner += item.portioner;
            }
            labelCountAmountPort.Text = antal_portioner.ToString();
            labelCountAmountDays.Text = (antal_portioner / 4).ToString();


        }

        private List<BackEnd.RecipeModel> BuildmenyList()
        {
            List<BackEnd.RecipeModel> SelectedRecipes = new List<BackEnd.RecipeModel>();
            SelectedRecipes.Clear();

            //List<String> MenuItems = new List<string>(); Om namnen behövs
            foreach (var box in comboBoxes)
            {
                if (!(box.SelectedIndex == -1))
                {
                    string current = box.SelectedItem.ToString();
                    //MenuItems.Add(current); Om namnen behövs
                    SelectedRecipes.Add(Recipes.Find(x => x.Name == current));
                }

            }
            return SelectedRecipes;
        }

        private void random()
        {

            Random rand = new Random();
            List<BackEnd.RecipeModel> RandomRecipes = classRecipes.get_Recipes();
            foreach (var box in comboBoxes)
            {
                int index = rand.Next(0, RandomRecipes.Count());
                string choosed = RandomRecipes.ElementAt(index).Name.ToString();
                RandomRecipes.RemoveAt(index);
                box.Text = choosed;
            }
            
        }

        private void comboBox_monday_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<BackEnd.RecipeModel> SelectedRecipes = new List<BackEnd.RecipeModel>();
            SelectedRecipes = BuildmenyList();
            buildStatList(SelectedRecipes);
        }

        private void button_Create_menu_Click(object sender, EventArgs e)
        {
            general.WriteToFile(ingredients);
            if (checkBox_Firebase.Checked)
            {
                if (!String.IsNullOrWhiteSpace(textBox_Firebase.Text.ToString()))
                {
                    var fire = new BackEnd.FireBaseClass();
                    var awaiter = fire.sendtofirebase(textBox_Firebase.Text.ToString(),ingredients).GetAwaiter();
                    _ = awaiter.IsCompleted;
                }
            }
        }

        private void ShowEditableListView(List<BackEnd.RecipeModel> selected)
        {
            ingredients.Clear();
            listView_ingredients.Items.Clear();
            foreach(var recipe in selected) 
            {
                foreach (var item in recipe.ingrediens)
                {
                    BackEnd.IngModel oneingredient = new BackEnd.IngModel();
                    if (ingredients.Find(x=> x.Name == item.Name.ToString() && x.Enhet == item.Enhet.ToString()) == null)
                    {
                        oneingredient.Name = item.Name.ToString();
                        oneingredient.Antal = decimal.Parse(item.Antal.ToString());
                        oneingredient.Enhet = item.Enhet.ToString();
                        ingredients.Add(oneingredient);
                    }
                    else
                    {
                        var current = ingredients.Find(x => x.Name == item.Name.ToString() && x.Enhet == item.Enhet.ToString());
                        ingredients.Remove(current);
                        current.Antal = decimal.Add(current.Antal, item.Antal);
                        ingredients.Add(current);
                    }

                    
                }
                
            }
            foreach (var item in ingredients)
            {
                var tobeadded = new ListViewItem(new[] { item.Name.ToString(), item.Antal.ToString(), item.Enhet.ToString() });
                listView_ingredients.Items.Add(tobeadded);
            }
           
            listView_ingredients.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView_ingredients.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }

        private void button_rand_Click(object sender, EventArgs e)
        {
            random();
        }
        private List<String> getSelectedItem()
        {
            
                var selected = listView_ingredients.SelectedItems[0];
                List<string> lista= new List<string> { selected.SubItems[0].Text, selected.SubItems[1].Text, selected.SubItems[2].Text };
                return lista;
            
            
        }
        private void listView_ingredients_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*if (listView_ingredients.SelectedItems.Count != 0) 
            { 
            var selected = listView_ingredients.SelectedItems[0];
            Console.WriteLine(selected);
            textBox_ingredient_amount.Text = selected.SubItems[1].Text;
            }*/
            if (listView_ingredients.SelectedItems.Count != 0) 
            {
                var listofingredients = getSelectedItem();
                textBox_ingredient_amount.Text = listofingredients[1];
            }
   
        }

        public void ChangeAmountOfIngredient(List<string> listofingredients,string amount)
        {
            //if (listView_ingredients.SelectedItems.Count != 0)
            //{
                //var listofingredients = getSelectedItem();
                ingredients.Find(x=> x.Name.ToLower() == listofingredients[0].ToLower()).Antal = decimal.Parse(amount);

                var tobeadded = new ListViewItem(new[] { listofingredients[0], amount, listofingredients[2] });
                var element = listView_ingredients.FindItemWithText(listofingredients[0]);
                int index = listView_ingredients.Items.IndexOf(element);
                listView_ingredients.Items.Remove(element);
                //listView_ingredients.Items.Add(tobeadded);
                listView_ingredients.Items.Insert(index, tobeadded);
            //}
        }

        private void button_changeamount_Click(object sender, EventArgs e)
        {
            if (listView_ingredients.SelectedItems.Count != 0)
            {
                ChangeAmountOfIngredient(getSelectedItem(), textBox_ingredient_amount.Text.ToString());

            }
        }

        private void button_check_Click(object sender, EventArgs e)
        {

            var selected = BuildmenyList();
            if (selected.Count>0)
            {
                MessageBox.Show(selected.Count().ToString());
                ShowEditableListView(selected);
                tableLayoutPanel_EditMenu.Visible = true;
                button_Create_menu.Enabled = true;
            }
            
           // general.WriteToFile(selected);
        }

        public void removeIngredient(string element)
        {
            listView_ingredients.Items.Remove( listView_ingredients.SelectedItems[0]);
            ingredients.Remove(ingredients.Find(x=>x.Name == element));
        }

        private void buttonRemoveIngredient_Click(object sender, EventArgs e)
        {
            if (listView_ingredients.SelectedItems.Count != 0)
            {
                List<string> selected = getSelectedItem();
                removeIngredient(selected.First().ToString());
            }
            
        }

        public void addUknownItem(List<String> toBeAdded)
        {
            if (ingredients.Find(x => x.Name.ToLower() == toBeAdded.First().ToLower())==null) 
            {
                BackEnd.IngModel addThese = new BackEnd.IngModel();
                addThese.Name = toBeAdded[0];
                addThese.Antal = decimal.Parse(toBeAdded[1]);
                addThese.Enhet = toBeAdded[2];
                ingredients.Add(addThese);
                var tobeaddedlist = new ListViewItem(new[] { toBeAdded[0], toBeAdded[1], toBeAdded[2] });
                listView_ingredients.Items.Add(tobeaddedlist);

            }
            else
            {
                ingredients.Find(x=>x.Name.ToLower() == toBeAdded.First().ToLower()).Antal = decimal.Parse(toBeAdded[1]);
                ChangeAmountOfIngredient(toBeAdded, textBox_AddUnknownAmount.Text.ToString());
                
            }


        }

        private void clearall() 
        {
            foreach(var box in textBoxes)
            {
                box.Clear();
            }
        }
        private void button_add_unknown_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(textBox_addUnknownName.Text.ToString()) || string.IsNullOrWhiteSpace(textBox_AddUnknownAmount.Text.ToString()) || string.IsNullOrWhiteSpace(textBox_AddUnknownUnit.Text.ToString())))
            {
                List<String> toBeAdded = new List<String> { textBox_addUnknownName.Text.ToString(), textBox_AddUnknownAmount.Text.ToString(), textBox_AddUnknownUnit.Text.ToString() };
                addUknownItem(toBeAdded);
                clearall();
            }
            else MessageBox.Show("alla fält måste vara ifyllda");
            

            
        }
    }
}
