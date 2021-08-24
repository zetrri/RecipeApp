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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            if (BackEnd.ClassSql.status(textBox_username.Text.ToString(), textBox_password.Text.ToString(), textBox_server.Text.ToString(), textBox_database.Text.ToString()))
            {
                labelSetStatus.Text = "Connected";
                labelSetStatus.ForeColor = Color.Green;
            }
            else{ labelSetStatus.Text = "Error";
                labelSetStatus.ForeColor = Color.Red;
            }
        }
    }
}
