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
    public partial class FormRecipe : Form
    {
        BackEnd.ClassRecipes recipes = new BackEnd.ClassRecipes();
        List<BackEnd.IngModel> ingredienslist = new List<BackEnd.IngModel>();
        List<BackEnd.IngModel> newrecipeinglist = new List<BackEnd.IngModel>();
        BackEnd.IngModel valdingrediens = new BackEnd.IngModel();
        BackEnd.Ingrediens ingrediens = new BackEnd.Ingrediens();
        BackEnd.ClassRecipes classRecipes = new BackEnd.ClassRecipes();
        List<string> taggar = new List<string>();
        public FormRecipe()
        {
            InitializeComponent();
            update_list();
            init_column();
            init_list();

        }

        private List<BackEnd.RecipeModel> get_recipes()
        {
            //Ingrediens ingrediens = new Ingrediens();
            List<BackEnd.RecipeModel> mylist = new List<BackEnd.RecipeModel>();
            mylist = recipes.get_Recipes();

            return mylist;
        }
        private void update_list()
        {
            listBox_recipes.Items.Clear();
            List<BackEnd.RecipeModel> mylist = new List<BackEnd.RecipeModel>();
            mylist = get_recipes();
            foreach (var item in mylist)
            {
                listBox_recipes.Items.Add(item.Name);
            }
        }

        private void init_list() 
        {
            ingredienslist = ingrediens.get_indregients();
            foreach (var item in ingredienslist)
            {
                comboBox1.Items.Add(item.Name);
            }
        }

        private void init_column()
        {

            listView_ing.GridLines = true;
            listView_ing.View = View.Details;
            listView_ing.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView_ing.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listView_info.GridLines = true;
            listView_info.View = View.Details;
            listView_info.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView_info.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listView_selected_ingredienses.GridLines = true;
            listView_selected_ingredienses.View = View.Details;
            listView_selected_ingredienses.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView_selected_ingredienses.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            //listView_tags.GridLines = true;
            //listView_tags.View = View.Details;
            //listView_tags.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            //listView_tags.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (panel_hidden.Visible == false) panel_hidden.Visible = true;
            else panel_hidden.Visible = false;
        }

        private void listBox_recipes_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView_ing.Items.Clear();
            listView_info.Items.Clear();
            List<BackEnd.RecipeModel> mylist = new List<BackEnd.RecipeModel>();
            string selected = listBox_recipes.SelectedItem.ToString();
            mylist = get_recipes();
            var temp = mylist.Find(x => x.Name == selected);
            var toinfo = new ListViewItem(new[] { temp.Name.ToString(), temp.portioner.ToString(), temp.tagg.ToString() });
            listView_info.Items.Add(toinfo);
            //MessageBox.Show(valdingrediens.Name.ToString() + valdingrediens.portioner.ToString() + valdingrediens.tagg);
            foreach (var item in temp.ingrediens.AsEnumerable())
            {
                var tobeadded = new ListViewItem(new[] { item.Name.ToString(), item.Antal.ToString(), item.Enhet.ToString() });
                listView_ing.Items.Add(tobeadded);
            }
            listView_ing.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView_ing.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listView_info.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView_info.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            if (listBox_recipes.SelectedIndex != -1)
            {
                BackEnd.ClassRecipes classRecipes = new BackEnd.ClassRecipes();
                classRecipes.remove_recipe(listBox_recipes.SelectedItem.ToString());
                update_list();
            }
            else
            {
                MessageBox.Show("Ett recept måste vara valt");
            }
        }

        private void button_add_ing_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(textBox_recipename.Text.ToString()) || string.IsNullOrWhiteSpace(textBox_amount_port.Text.ToString())))
            {
                tableLayoutPanel_adding.Visible = true;
                listView_selected_ingredienses.Visible = true;
            }
            else MessageBox.Show("Rutan"+'"'+"namn"+'"'+" och "+'"'+"Portioner"+'"'+" måste vara ifyllda");
                
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            valdingrediens = ingredienslist.Find(x => x.Name == comboBox1.SelectedItem.ToString());
            
        }

        private void button_add_ingrediens_Click(object sender, EventArgs e)
        {
            valdingrediens.Antal = Double.Parse(textBox_antal.Text.ToString());
            var tobeadded = new ListViewItem(new[] { valdingrediens.Name.ToString(), valdingrediens.Antal.ToString(), valdingrediens.Enhet.ToString() });
            listView_selected_ingredienses.Items.Add(tobeadded);
            newrecipeinglist.Add(valdingrediens);
        }

        private void button_Done_Click(object sender, EventArgs e)
        {
            classRecipes.add_recipe(textBox_recipename.Text.ToString(), Int32.Parse(textBox_amount_port.Text.ToString()), taggar, newrecipeinglist);
            clearall();
            update_list();
        }
        private void clearall()
        {
            listView_selected_ingredienses.Clear();
            listView_tags.Items.Clear();
            textBox_amount_port.Clear();
            textBox_antal.Clear();
            textBox_recipename.Clear();
            textBox_tags.Clear();
        }

        private void button_add_tagg_Click(object sender, EventArgs e)
        {
            {
                var tobeadded = new ListViewItem(new[] { textBox_tags.Text.ToString() });
                listView_tags.Items.Add(textBox_tags.Text.ToString());
                taggar.Add(textBox_tags.Text.ToString());
                textBox_tags.Clear();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
