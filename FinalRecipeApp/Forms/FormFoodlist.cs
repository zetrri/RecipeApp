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
        List<BackEnd.RecipeModel> Recipes = new List<BackEnd.RecipeModel>();
        BackEnd.ClassGeneral general = new BackEnd.ClassGeneral();

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

        private void comboBox_monday_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<BackEnd.RecipeModel> SelectedRecipes = new List<BackEnd.RecipeModel>();
            SelectedRecipes = BuildmenyList();
            buildStatList(SelectedRecipes);
        }

        private void button_Create_menu_Click(object sender, EventArgs e)
        {
            general.WriteToFile(BuildmenyList());
        }
    }
}
