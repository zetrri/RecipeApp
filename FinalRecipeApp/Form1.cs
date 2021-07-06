using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalRecipeApp
{
    public partial class Form1 : Form
    {
        Button currentbutton = new Button();
        String OnClickcolor = "#4E4E68";
        String OffClickcolor = "#333351";
        private Form activeform;
        bool mouseDown;
        Point offset;
        public Form1()
        {
            InitializeComponent();
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentbutton != (Button)btnSender)
                {
                    DisableButton();
                    currentbutton = (Button)btnSender;
                    currentbutton.BackColor = ColorTranslator.FromHtml(OnClickcolor);
                }
            }

        }
        private void DisableButton()
        {
            foreach(Control previuosBtn in panelSidePanel.Controls)
            {
                if (previuosBtn.GetType() == typeof(Button))
                {
                    previuosBtn.BackColor = ColorTranslator.FromHtml(OffClickcolor);
                }
            }
        }

        private void OpenChildForm(Form childform, object btnsender) 
        {
            if (activeform != null)
            {
                activeform.Close();
            }
            ActivateButton(btnsender);
            activeform = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            this.panelDestopPanel.Controls.Add(childform);
            this.panelDestopPanel.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }
        private void button_recept_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormRecipe(), sender);
        }

        private void buttonIngred_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormIngred(), sender);
        }

        private void buttonCreateWeek_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormFoodlist(), sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void panel_TitleRecipe_MouseDown(object sender, MouseEventArgs e)
        {
            {
                offset.X = e.X;
                offset.Y = e.Y;
                mouseDown = true;
            }
        }

        private void panel_TitleRecipe_MouseMove(object sender, MouseEventArgs e)
        {
            {
                if (mouseDown == true)
                {
                    Point currentScreenPos = PointToScreen(e.Location);
                    Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
                }
            }
        }

        private void panel_TitleRecipe_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    
}
