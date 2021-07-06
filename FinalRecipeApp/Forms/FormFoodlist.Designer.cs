
namespace FinalRecipeApp.Forms
{
    partial class FormFoodlist
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Create_menu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox_monday = new System.Windows.Forms.ComboBox();
            this.comboBox_tuesday = new System.Windows.Forms.ComboBox();
            this.comboBox_wednesday = new System.Windows.Forms.ComboBox();
            this.comboBox_thursday = new System.Windows.Forms.ComboBox();
            this.comboBox_friday = new System.Windows.Forms.ComboBox();
            this.comboBox_saturday = new System.Windows.Forms.ComboBox();
            this.comboBox_sunday = new System.Windows.Forms.ComboBox();
            this.label_stats = new System.Windows.Forms.Label();
            this.labelAmountPort = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelAmountDays = new System.Windows.Forms.Label();
            this.labelCountAmountPort = new System.Windows.Forms.Label();
            this.labelCountAmountDays = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(113)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.button_Create_menu);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1673, 1126);
            this.panel1.TabIndex = 0;
            // 
            // button_Create_menu
            // 
            this.button_Create_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(81)))));
            this.button_Create_menu.FlatAppearance.BorderSize = 0;
            this.button_Create_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Create_menu.Font = new System.Drawing.Font("Yu Gothic Medium", 11F, System.Drawing.FontStyle.Bold);
            this.button_Create_menu.ForeColor = System.Drawing.SystemColors.Control;
            this.button_Create_menu.Location = new System.Drawing.Point(403, 211);
            this.button_Create_menu.Name = "button_Create_menu";
            this.button_Create_menu.Size = new System.Drawing.Size(249, 91);
            this.button_Create_menu.TabIndex = 4;
            this.button_Create_menu.Text = "Skapa meny";
            this.button_Create_menu.UseVisualStyleBackColor = false;
            this.button_Create_menu.Click += new System.EventHandler(this.button_Create_menu_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic Medium", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(98, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 43);
            this.label1.TabIndex = 6;
            this.label1.Text = "Måndag";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.comboBox_monday, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.comboBox_tuesday, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.comboBox_wednesday, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.comboBox_thursday, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.comboBox_friday, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.comboBox_saturday, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.comboBox_sunday, 0, 13);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 14;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142856F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142856F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142856F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142856F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142856F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142856F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142856F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142856F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142856F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142856F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142856F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142856F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142856F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142856F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(344, 1126);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic Medium", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(108, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 43);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tisdag";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic Medium", 14F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(102, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 43);
            this.label3.TabIndex = 6;
            this.label3.Text = "Onsdag";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic Medium", 14F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(99, 498);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 43);
            this.label4.TabIndex = 6;
            this.label4.Text = "Torsdag";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic Medium", 14F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(108, 658);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 43);
            this.label5.TabIndex = 6;
            this.label5.Text = "Fredag";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic Medium", 14F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(107, 818);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 43);
            this.label6.TabIndex = 6;
            this.label6.Text = "Lördag";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic Medium", 14F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(103, 978);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 43);
            this.label7.TabIndex = 6;
            this.label7.Text = "Söndag";
            // 
            // comboBox_monday
            // 
            this.comboBox_monday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_monday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_monday.FormattingEnabled = true;
            this.comboBox_monday.Location = new System.Drawing.Point(3, 83);
            this.comboBox_monday.Name = "comboBox_monday";
            this.comboBox_monday.Size = new System.Drawing.Size(338, 32);
            this.comboBox_monday.TabIndex = 8;
            this.comboBox_monday.SelectedIndexChanged += new System.EventHandler(this.comboBox_monday_SelectedIndexChanged);
            // 
            // comboBox_tuesday
            // 
            this.comboBox_tuesday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_tuesday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_tuesday.FormattingEnabled = true;
            this.comboBox_tuesday.Location = new System.Drawing.Point(3, 243);
            this.comboBox_tuesday.Name = "comboBox_tuesday";
            this.comboBox_tuesday.Size = new System.Drawing.Size(338, 32);
            this.comboBox_tuesday.TabIndex = 8;
            this.comboBox_tuesday.SelectedIndexChanged += new System.EventHandler(this.comboBox_monday_SelectedIndexChanged);
            // 
            // comboBox_wednesday
            // 
            this.comboBox_wednesday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_wednesday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_wednesday.FormattingEnabled = true;
            this.comboBox_wednesday.Location = new System.Drawing.Point(3, 403);
            this.comboBox_wednesday.Name = "comboBox_wednesday";
            this.comboBox_wednesday.Size = new System.Drawing.Size(338, 32);
            this.comboBox_wednesday.TabIndex = 8;
            this.comboBox_wednesday.SelectedIndexChanged += new System.EventHandler(this.comboBox_monday_SelectedIndexChanged);
            // 
            // comboBox_thursday
            // 
            this.comboBox_thursday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_thursday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_thursday.FormattingEnabled = true;
            this.comboBox_thursday.Location = new System.Drawing.Point(3, 563);
            this.comboBox_thursday.Name = "comboBox_thursday";
            this.comboBox_thursday.Size = new System.Drawing.Size(338, 32);
            this.comboBox_thursday.TabIndex = 8;
            this.comboBox_thursday.SelectedIndexChanged += new System.EventHandler(this.comboBox_monday_SelectedIndexChanged);
            // 
            // comboBox_friday
            // 
            this.comboBox_friday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_friday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_friday.FormattingEnabled = true;
            this.comboBox_friday.Location = new System.Drawing.Point(3, 723);
            this.comboBox_friday.Name = "comboBox_friday";
            this.comboBox_friday.Size = new System.Drawing.Size(338, 32);
            this.comboBox_friday.TabIndex = 8;
            this.comboBox_friday.SelectedIndexChanged += new System.EventHandler(this.comboBox_monday_SelectedIndexChanged);
            // 
            // comboBox_saturday
            // 
            this.comboBox_saturday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_saturday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_saturday.FormattingEnabled = true;
            this.comboBox_saturday.Location = new System.Drawing.Point(3, 883);
            this.comboBox_saturday.Name = "comboBox_saturday";
            this.comboBox_saturday.Size = new System.Drawing.Size(338, 32);
            this.comboBox_saturday.TabIndex = 8;
            this.comboBox_saturday.SelectedIndexChanged += new System.EventHandler(this.comboBox_monday_SelectedIndexChanged);
            // 
            // comboBox_sunday
            // 
            this.comboBox_sunday.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox_sunday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_sunday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_sunday.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F);
            this.comboBox_sunday.ForeColor = System.Drawing.SystemColors.ControlText;
            this.comboBox_sunday.Location = new System.Drawing.Point(0, 1040);
            this.comboBox_sunday.Margin = new System.Windows.Forms.Padding(0);
            this.comboBox_sunday.Name = "comboBox_sunday";
            this.comboBox_sunday.Size = new System.Drawing.Size(344, 32);
            this.comboBox_sunday.Sorted = true;
            this.comboBox_sunday.TabIndex = 8;
            this.comboBox_sunday.SelectedIndexChanged += new System.EventHandler(this.comboBox_monday_SelectedIndexChanged);
            // 
            // label_stats
            // 
            this.label_stats.AutoSize = true;
            this.label_stats.Font = new System.Drawing.Font("Yu Gothic Medium", 14F, System.Drawing.FontStyle.Bold);
            this.label_stats.ForeColor = System.Drawing.SystemColors.Control;
            this.label_stats.Location = new System.Drawing.Point(4, 3);
            this.label_stats.Name = "label_stats";
            this.label_stats.Size = new System.Drawing.Size(165, 43);
            this.label_stats.TabIndex = 6;
            this.label_stats.Text = "Statestik";
            // 
            // labelAmountPort
            // 
            this.labelAmountPort.AutoSize = true;
            this.labelAmountPort.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelAmountPort.Font = new System.Drawing.Font("Yu Gothic Medium", 10F, System.Drawing.FontStyle.Bold);
            this.labelAmountPort.ForeColor = System.Drawing.SystemColors.Control;
            this.labelAmountPort.Location = new System.Drawing.Point(3, 0);
            this.labelAmountPort.Name = "labelAmountPort";
            this.labelAmountPort.Size = new System.Drawing.Size(200, 77);
            this.labelAmountPort.TabIndex = 6;
            this.labelAmountPort.Text = "Antal portioner:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.26113F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.73887F));
            this.tableLayoutPanel2.Controls.Add(this.labelAmountDays, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelAmountPort, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelCountAmountPort, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelCountAmountDays, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 46);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(337, 154);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // labelAmountDays
            // 
            this.labelAmountDays.AutoSize = true;
            this.labelAmountDays.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAmountDays.Font = new System.Drawing.Font("Yu Gothic Medium", 10F, System.Drawing.FontStyle.Bold);
            this.labelAmountDays.ForeColor = System.Drawing.SystemColors.Control;
            this.labelAmountDays.Location = new System.Drawing.Point(3, 77);
            this.labelAmountDays.Name = "labelAmountDays";
            this.labelAmountDays.Size = new System.Drawing.Size(251, 77);
            this.labelAmountDays.TabIndex = 6;
            this.labelAmountDays.Text = "Antal Dagar:";
            // 
            // labelCountAmountPort
            // 
            this.labelCountAmountPort.AutoSize = true;
            this.labelCountAmountPort.Font = new System.Drawing.Font("Yu Gothic Medium", 10F, System.Drawing.FontStyle.Bold);
            this.labelCountAmountPort.ForeColor = System.Drawing.SystemColors.Control;
            this.labelCountAmountPort.Location = new System.Drawing.Point(260, 0);
            this.labelCountAmountPort.Name = "labelCountAmountPort";
            this.labelCountAmountPort.Size = new System.Drawing.Size(28, 31);
            this.labelCountAmountPort.TabIndex = 6;
            this.labelCountAmountPort.Text = "0";
            // 
            // labelCountAmountDays
            // 
            this.labelCountAmountDays.AutoSize = true;
            this.labelCountAmountDays.Font = new System.Drawing.Font("Yu Gothic Medium", 10F, System.Drawing.FontStyle.Bold);
            this.labelCountAmountDays.ForeColor = System.Drawing.SystemColors.Control;
            this.labelCountAmountDays.Location = new System.Drawing.Point(260, 77);
            this.labelCountAmountDays.Name = "labelCountAmountDays";
            this.labelCountAmountDays.Size = new System.Drawing.Size(28, 31);
            this.labelCountAmountDays.TabIndex = 6;
            this.labelCountAmountDays.Text = "0";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(81)))));
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Controls.Add(this.label_stats);
            this.panel2.Location = new System.Drawing.Point(403, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(360, 198);
            this.panel2.TabIndex = 9;
            // 
            // FormFoodlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1755, 1201);
            this.Controls.Add(this.panel1);
            this.Name = "FormFoodlist";
            this.Text = "FormFoodlist";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_Create_menu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox_monday;
        private System.Windows.Forms.ComboBox comboBox_tuesday;
        private System.Windows.Forms.ComboBox comboBox_wednesday;
        private System.Windows.Forms.ComboBox comboBox_thursday;
        private System.Windows.Forms.ComboBox comboBox_friday;
        private System.Windows.Forms.ComboBox comboBox_saturday;
        private System.Windows.Forms.ComboBox comboBox_sunday;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label labelAmountDays;
        private System.Windows.Forms.Label labelAmountPort;
        private System.Windows.Forms.Label labelCountAmountPort;
        private System.Windows.Forms.Label labelCountAmountDays;
        private System.Windows.Forms.Label label_stats;
        private System.Windows.Forms.Panel panel2;
    }
}