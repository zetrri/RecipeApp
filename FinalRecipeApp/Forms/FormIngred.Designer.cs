
namespace FinalRecipeApp.Forms
{
    partial class FormIngred
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelWhole = new System.Windows.Forms.Panel();
            this.button_close = new System.Windows.Forms.Button();
            this.listView_ingredienser = new System.Windows.Forms.ListView();
            this.columnHeader_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_enhet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_typ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel_addNewIngred = new System.Windows.Forms.TableLayoutPanel();
            this.button_done = new System.Windows.Forms.Button();
            this.textBox_ingredient_type = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_ingredient_unit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_ingredient_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_add_ing = new System.Windows.Forms.Button();
            this.button_Delete_ing = new System.Windows.Forms.Button();
            this.panelWhole.SuspendLayout();
            this.tableLayoutPanel_addNewIngred.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelWhole
            // 
            this.panelWhole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(113)))));
            this.panelWhole.Controls.Add(this.button_close);
            this.panelWhole.Controls.Add(this.listView_ingredienser);
            this.panelWhole.Controls.Add(this.tableLayoutPanel_addNewIngred);
            this.panelWhole.Controls.Add(this.button_add_ing);
            this.panelWhole.Controls.Add(this.button_Delete_ing);
            this.panelWhole.Location = new System.Drawing.Point(0, 0);
            this.panelWhole.Name = "panelWhole";
            this.panelWhole.Size = new System.Drawing.Size(1673, 1126);
            this.panelWhole.TabIndex = 0;
            // 
            // button_close
            // 
            this.button_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(81)))));
            this.button_close.FlatAppearance.BorderSize = 0;
            this.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_close.Font = new System.Drawing.Font("Yu Gothic Medium", 11F, System.Drawing.FontStyle.Bold);
            this.button_close.ForeColor = System.Drawing.SystemColors.Control;
            this.button_close.Location = new System.Drawing.Point(1422, 1032);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(249, 92);
            this.button_close.TabIndex = 12;
            this.button_close.Text = "Stäng";
            this.button_close.UseVisualStyleBackColor = false;
            this.button_close.Visible = false;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // listView_ingredienser
            // 
            this.listView_ingredienser.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_Name,
            this.columnHeader_enhet,
            this.columnHeader_typ});
            this.listView_ingredienser.Dock = System.Windows.Forms.DockStyle.Left;
            this.listView_ingredienser.HideSelection = false;
            this.listView_ingredienser.Location = new System.Drawing.Point(0, 0);
            this.listView_ingredienser.Name = "listView_ingredienser";
            this.listView_ingredienser.Size = new System.Drawing.Size(569, 1126);
            this.listView_ingredienser.TabIndex = 11;
            this.listView_ingredienser.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader_Name
            // 
            this.columnHeader_Name.Text = "Name";
            // 
            // columnHeader_enhet
            // 
            this.columnHeader_enhet.Text = "Unit";
            // 
            // columnHeader_typ
            // 
            this.columnHeader_typ.Text = "Type";
            // 
            // tableLayoutPanel_addNewIngred
            // 
            this.tableLayoutPanel_addNewIngred.ColumnCount = 1;
            this.tableLayoutPanel_addNewIngred.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_addNewIngred.Controls.Add(this.button_done, 0, 6);
            this.tableLayoutPanel_addNewIngred.Controls.Add(this.textBox_ingredient_type, 0, 5);
            this.tableLayoutPanel_addNewIngred.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel_addNewIngred.Controls.Add(this.textBox_ingredient_unit, 0, 3);
            this.tableLayoutPanel_addNewIngred.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel_addNewIngred.Controls.Add(this.textBox_ingredient_name, 0, 1);
            this.tableLayoutPanel_addNewIngred.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel_addNewIngred.Location = new System.Drawing.Point(584, 196);
            this.tableLayoutPanel_addNewIngred.Name = "tableLayoutPanel_addNewIngred";
            this.tableLayoutPanel_addNewIngred.RowCount = 8;
            this.tableLayoutPanel_addNewIngred.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel_addNewIngred.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel_addNewIngred.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel_addNewIngred.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel_addNewIngred.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel_addNewIngred.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel_addNewIngred.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel_addNewIngred.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel_addNewIngred.Size = new System.Drawing.Size(252, 806);
            this.tableLayoutPanel_addNewIngred.TabIndex = 10;
            this.tableLayoutPanel_addNewIngred.Visible = false;
            // 
            // button_done
            // 
            this.button_done.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(81)))));
            this.button_done.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_done.FlatAppearance.BorderSize = 0;
            this.button_done.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_done.Font = new System.Drawing.Font("Yu Gothic Medium", 11F, System.Drawing.FontStyle.Bold);
            this.button_done.ForeColor = System.Drawing.SystemColors.Control;
            this.button_done.Location = new System.Drawing.Point(3, 603);
            this.button_done.Name = "button_done";
            this.button_done.Size = new System.Drawing.Size(246, 94);
            this.button_done.TabIndex = 7;
            this.button_done.Text = "Done";
            this.button_done.UseVisualStyleBackColor = false;
            this.button_done.Click += new System.EventHandler(this.button_done_Click);
            // 
            // textBox_ingredient_type
            // 
            this.textBox_ingredient_type.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_ingredient_type.Location = new System.Drawing.Point(3, 503);
            this.textBox_ingredient_type.Name = "textBox_ingredient_type";
            this.textBox_ingredient_type.Size = new System.Drawing.Size(246, 29);
            this.textBox_ingredient_type.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(87, 434);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 32);
            this.label4.TabIndex = 5;
            this.label4.Text = "Type";
            // 
            // textBox_ingredient_unit
            // 
            this.textBox_ingredient_unit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_ingredient_unit.Location = new System.Drawing.Point(3, 303);
            this.textBox_ingredient_unit.Name = "textBox_ingredient_unit";
            this.textBox_ingredient_unit.Size = new System.Drawing.Size(246, 29);
            this.textBox_ingredient_unit.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(93, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Unit";
            // 
            // textBox_ingredient_name
            // 
            this.textBox_ingredient_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_ingredient_name.Location = new System.Drawing.Point(3, 103);
            this.textBox_ingredient_name.Name = "textBox_ingredient_name";
            this.textBox_ingredient_name.Size = new System.Drawing.Size(246, 29);
            this.textBox_ingredient_name.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(55, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingredient";
            // 
            // button_add_ing
            // 
            this.button_add_ing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(81)))));
            this.button_add_ing.FlatAppearance.BorderSize = 0;
            this.button_add_ing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add_ing.Font = new System.Drawing.Font("Yu Gothic Medium", 11F, System.Drawing.FontStyle.Bold);
            this.button_add_ing.ForeColor = System.Drawing.SystemColors.Control;
            this.button_add_ing.Location = new System.Drawing.Point(587, 100);
            this.button_add_ing.Name = "button_add_ing";
            this.button_add_ing.Size = new System.Drawing.Size(249, 92);
            this.button_add_ing.TabIndex = 3;
            this.button_add_ing.Text = "Add ingredient";
            this.button_add_ing.UseVisualStyleBackColor = false;
            this.button_add_ing.Click += new System.EventHandler(this.button_add_ing_Click);
            // 
            // button_Delete_ing
            // 
            this.button_Delete_ing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(81)))));
            this.button_Delete_ing.FlatAppearance.BorderSize = 0;
            this.button_Delete_ing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Delete_ing.Font = new System.Drawing.Font("Yu Gothic Medium", 11F, System.Drawing.FontStyle.Bold);
            this.button_Delete_ing.ForeColor = System.Drawing.SystemColors.Control;
            this.button_Delete_ing.Location = new System.Drawing.Point(587, 2);
            this.button_Delete_ing.Name = "button_Delete_ing";
            this.button_Delete_ing.Size = new System.Drawing.Size(252, 94);
            this.button_Delete_ing.TabIndex = 3;
            this.button_Delete_ing.Text = "Remove ingredient";
            this.button_Delete_ing.UseVisualStyleBackColor = false;
            this.button_Delete_ing.Click += new System.EventHandler(this.button_Delete_ing_Click);
            // 
            // FormIngred
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1686, 1140);
            this.Controls.Add(this.panelWhole);
            this.Name = "FormIngred";
            this.Text = "FormIngred";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormIngred_FormClosing);
            this.panelWhole.ResumeLayout(false);
            this.tableLayoutPanel_addNewIngred.ResumeLayout(false);
            this.tableLayoutPanel_addNewIngred.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelWhole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Delete_ing;
        private System.Windows.Forms.Button button_add_ing;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_addNewIngred;
        private System.Windows.Forms.TextBox textBox_ingredient_type;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_ingredient_unit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_ingredient_name;
        private System.Windows.Forms.Button button_done;
        private System.Windows.Forms.ListView listView_ingredienser;
        private System.Windows.Forms.ColumnHeader columnHeader_Name;
        private System.Windows.Forms.ColumnHeader columnHeader_enhet;
        private System.Windows.Forms.ColumnHeader columnHeader_typ;
        private System.Windows.Forms.Button button_close;
    }
}