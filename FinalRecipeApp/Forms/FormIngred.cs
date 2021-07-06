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
    public partial class FormIngred : Form
    {
        
        BackEnd.Ingrediens ingrediens = new BackEnd.Ingrediens();
        public FormIngred()
        {
            InitializeComponent();
            init_columns();
            update_list();
        }

        public void init_columns()
        {
            listView_ingredienser.GridLines = true;
            listView_ingredienser.View = View.Details;
            listView_ingredienser.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView_ingredienser.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private List<BackEnd.IngModel> get_ingrediens()
        {
            //Ingrediens ingrediens = new Ingrediens();
            List<BackEnd.IngModel> mylist = new List<BackEnd.IngModel>();
            mylist = ingrediens.get_indregients();

            return mylist;
        }
        private void update_list()
        {
            listView_ingredienser.Items.Clear();
            List<BackEnd.IngModel> mylist = new List<BackEnd.IngModel>();
            mylist = get_ingrediens();
            var toinfolist = new ListViewItem();
            foreach(var item in mylist)
            {
                toinfolist = new ListViewItem(new[] { item.Name.ToString(), item.Enhet.ToString(), item.typ.ToString() });
                listView_ingredienser.Items.Add(toinfolist);
            }
            init_columns();
            
        }

        private void button_Delete_ing_Click(object sender, EventArgs e)
        {

            var selected = listView_ingredienser.SelectedIndices;
            for (int i = 0; i < selected.Count; i++)
            {
                var removethis = listView_ingredienser.Items[selected[i]].Text.ToString();
                ingrediens.remove_ing(removethis);
            }
            update_list();
            
            //MessageBox.Show(listView_ingredienser.Items[listView_ingredienser.SelectedIndices[0]].Text.ToString());
        }

        private void button_add_ing_Click(object sender, EventArgs e)
        {
            tableLayoutPanel_addNewIngred.Visible = true;
        }

        private void button_done_Click(object sender, EventArgs e)
        {
            if (!(String.IsNullOrWhiteSpace(textBox_ingredient_name.Text) || String.IsNullOrWhiteSpace(textBox_ingredient_unit.Text) || String.IsNullOrWhiteSpace(textBox_ingredient_type.Text)))
            {
                if (!(ingrediens.add_ing(textBox_ingredient_name.Text.ToString(), textBox_ingredient_unit.Text.ToString(), textBox_ingredient_type.Text.ToString())))
                {
                    MessageBox.Show("indregiens already in list");
                }
                update_list();
            }
            else MessageBox.Show("All fields must be filled");
        }
    }
}
