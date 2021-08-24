
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
            this.button_check = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.listView_ingredients = new System.Windows.Forms.ListView();
            this.columnHeader_nameIng = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_amount_ing = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_unit_ing = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel_EditMenu = new System.Windows.Forms.TableLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button_changeamount = new System.Windows.Forms.Button();
            this.buttonRemoveIngredient = new System.Windows.Forms.Button();
            this.textBox_ingredient_amount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_AddUnknownAmount = new System.Windows.Forms.TextBox();
            this.button_add_unknown = new System.Windows.Forms.Button();
            this.textBox_AddUnknownUnit = new System.Windows.Forms.TextBox();
            this.textBox_addUnknownName = new System.Windows.Forms.TextBox();
            this.button_rand = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelAmountDays = new System.Windows.Forms.Label();
            this.labelAmountPort = new System.Windows.Forms.Label();
            this.labelCountAmountPort = new System.Windows.Forms.Label();
            this.labelCountAmountDays = new System.Windows.Forms.Label();
            this.label_stats = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBox_monday = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox_tuesday = new System.Windows.Forms.ComboBox();
            this.comboBox_wednesday = new System.Windows.Forms.ComboBox();
            this.comboBox_thursday = new System.Windows.Forms.ComboBox();
            this.comboBox_friday = new System.Windows.Forms.ComboBox();
            this.comboBox_saturday = new System.Windows.Forms.ComboBox();
            this.comboBox_sunday = new System.Windows.Forms.ComboBox();
            this.button_Create_menu = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel_EditMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(113)))));
            this.panel1.Controls.Add(this.button_check);
            this.panel1.Controls.Add(this.tableLayoutPanel3);
            this.panel1.Controls.Add(this.button_rand);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.button_Create_menu);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1217, 751);
            this.panel1.TabIndex = 0;
            // 
            // button_check
            // 
            this.button_check.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(81)))));
            this.button_check.FlatAppearance.BorderSize = 0;
            this.button_check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_check.Font = new System.Drawing.Font("Yu Gothic Medium", 11F, System.Drawing.FontStyle.Bold);
            this.button_check.ForeColor = System.Drawing.SystemColors.Control;
            this.button_check.Location = new System.Drawing.Point(293, 140);
            this.button_check.Margin = new System.Windows.Forms.Padding(2);
            this.button_check.Name = "button_check";
            this.button_check.Size = new System.Drawing.Size(181, 61);
            this.button_check.TabIndex = 11;
            this.button_check.Text = "Kontrollera";
            this.button_check.UseVisualStyleBackColor = false;
            this.button_check.Click += new System.EventHandler(this.button_check_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.listView_ingredients, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel_EditMenu, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(560, 6);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(654, 742);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // listView_ingredients
            // 
            this.listView_ingredients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_nameIng,
            this.columnHeader_amount_ing,
            this.columnHeader_unit_ing});
            this.listView_ingredients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_ingredients.HideSelection = false;
            this.listView_ingredients.Location = new System.Drawing.Point(330, 2);
            this.listView_ingredients.Margin = new System.Windows.Forms.Padding(3, 2, 1, 2);
            this.listView_ingredients.MultiSelect = false;
            this.listView_ingredients.Name = "listView_ingredients";
            this.listView_ingredients.Size = new System.Drawing.Size(323, 738);
            this.listView_ingredients.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView_ingredients.TabIndex = 3;
            this.listView_ingredients.UseCompatibleStateImageBehavior = false;
            this.listView_ingredients.View = System.Windows.Forms.View.Details;
            this.listView_ingredients.SelectedIndexChanged += new System.EventHandler(this.listView_ingredients_SelectedIndexChanged);
            // 
            // columnHeader_nameIng
            // 
            this.columnHeader_nameIng.Text = "Namn";
            // 
            // columnHeader_amount_ing
            // 
            this.columnHeader_amount_ing.Text = "Antal";
            // 
            // columnHeader_unit_ing
            // 
            this.columnHeader_unit_ing.Text = "Enhet";
            // 
            // tableLayoutPanel_EditMenu
            // 
            this.tableLayoutPanel_EditMenu.ColumnCount = 2;
            this.tableLayoutPanel_EditMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_EditMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_EditMenu.Controls.Add(this.label11, 0, 4);
            this.tableLayoutPanel_EditMenu.Controls.Add(this.label10, 0, 3);
            this.tableLayoutPanel_EditMenu.Controls.Add(this.label9, 0, 2);
            this.tableLayoutPanel_EditMenu.Controls.Add(this.button_changeamount, 1, 1);
            this.tableLayoutPanel_EditMenu.Controls.Add(this.buttonRemoveIngredient, 0, 1);
            this.tableLayoutPanel_EditMenu.Controls.Add(this.textBox_ingredient_amount, 1, 0);
            this.tableLayoutPanel_EditMenu.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel_EditMenu.Controls.Add(this.textBox_AddUnknownAmount, 1, 3);
            this.tableLayoutPanel_EditMenu.Controls.Add(this.button_add_unknown, 1, 5);
            this.tableLayoutPanel_EditMenu.Controls.Add(this.textBox_AddUnknownUnit, 1, 4);
            this.tableLayoutPanel_EditMenu.Controls.Add(this.textBox_addUnknownName, 1, 2);
            this.tableLayoutPanel_EditMenu.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel_EditMenu.Name = "tableLayoutPanel_EditMenu";
            this.tableLayoutPanel_EditMenu.RowCount = 6;
            this.tableLayoutPanel_EditMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel_EditMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel_EditMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel_EditMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel_EditMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel_EditMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel_EditMenu.Size = new System.Drawing.Size(321, 401);
            this.tableLayoutPanel_EditMenu.TabIndex = 4;
            this.tableLayoutPanel_EditMenu.Visible = false;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Yu Gothic Medium", 14F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(38, 281);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 31);
            this.label11.TabIndex = 21;
            this.label11.Text = "Enhet";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Yu Gothic Medium", 14F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(42, 215);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 31);
            this.label10.TabIndex = 19;
            this.label10.Text = "Antal";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(17, 139);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 52);
            this.label9.TabIndex = 17;
            this.label9.Text = "Lägg till annan vara";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_changeamount
            // 
            this.button_changeamount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(81)))));
            this.button_changeamount.FlatAppearance.BorderSize = 0;
            this.button_changeamount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_changeamount.Font = new System.Drawing.Font("Yu Gothic Medium", 11F, System.Drawing.FontStyle.Bold);
            this.button_changeamount.ForeColor = System.Drawing.SystemColors.Control;
            this.button_changeamount.Location = new System.Drawing.Point(162, 68);
            this.button_changeamount.Margin = new System.Windows.Forms.Padding(2);
            this.button_changeamount.Name = "button_changeamount";
            this.button_changeamount.Size = new System.Drawing.Size(157, 61);
            this.button_changeamount.TabIndex = 15;
            this.button_changeamount.Text = "Ändra antal";
            this.button_changeamount.UseVisualStyleBackColor = false;
            this.button_changeamount.Click += new System.EventHandler(this.button_changeamount_Click);
            // 
            // buttonRemoveIngredient
            // 
            this.buttonRemoveIngredient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(81)))));
            this.buttonRemoveIngredient.FlatAppearance.BorderSize = 0;
            this.buttonRemoveIngredient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoveIngredient.Font = new System.Drawing.Font("Yu Gothic Medium", 11F, System.Drawing.FontStyle.Bold);
            this.buttonRemoveIngredient.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonRemoveIngredient.Location = new System.Drawing.Point(2, 68);
            this.buttonRemoveIngredient.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRemoveIngredient.Name = "buttonRemoveIngredient";
            this.buttonRemoveIngredient.Size = new System.Drawing.Size(156, 61);
            this.buttonRemoveIngredient.TabIndex = 14;
            this.buttonRemoveIngredient.Text = "Ta bort ingrediens";
            this.buttonRemoveIngredient.UseVisualStyleBackColor = false;
            this.buttonRemoveIngredient.Click += new System.EventHandler(this.buttonRemoveIngredient_Click);
            // 
            // textBox_ingredient_amount
            // 
            this.textBox_ingredient_amount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_ingredient_amount.Location = new System.Drawing.Point(162, 22);
            this.textBox_ingredient_amount.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_ingredient_amount.Name = "textBox_ingredient_amount";
            this.textBox_ingredient_amount.Size = new System.Drawing.Size(157, 22);
            this.textBox_ingredient_amount.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic Medium", 14F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(42, 17);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 31);
            this.label8.TabIndex = 11;
            this.label8.Text = "Antal";
            // 
            // textBox_AddUnknownAmount
            // 
            this.textBox_AddUnknownAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_AddUnknownAmount.Location = new System.Drawing.Point(162, 220);
            this.textBox_AddUnknownAmount.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_AddUnknownAmount.Name = "textBox_AddUnknownAmount";
            this.textBox_AddUnknownAmount.Size = new System.Drawing.Size(157, 22);
            this.textBox_AddUnknownAmount.TabIndex = 18;
            // 
            // button_add_unknown
            // 
            this.button_add_unknown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(81)))));
            this.button_add_unknown.FlatAppearance.BorderSize = 0;
            this.button_add_unknown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add_unknown.Font = new System.Drawing.Font("Yu Gothic Medium", 11F, System.Drawing.FontStyle.Bold);
            this.button_add_unknown.ForeColor = System.Drawing.SystemColors.Control;
            this.button_add_unknown.Location = new System.Drawing.Point(162, 332);
            this.button_add_unknown.Margin = new System.Windows.Forms.Padding(2);
            this.button_add_unknown.Name = "button_add_unknown";
            this.button_add_unknown.Size = new System.Drawing.Size(157, 61);
            this.button_add_unknown.TabIndex = 20;
            this.button_add_unknown.Text = "Lägg till";
            this.button_add_unknown.UseVisualStyleBackColor = false;
            this.button_add_unknown.Click += new System.EventHandler(this.button_add_unknown_Click);
            // 
            // textBox_AddUnknownUnit
            // 
            this.textBox_AddUnknownUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_AddUnknownUnit.Location = new System.Drawing.Point(162, 286);
            this.textBox_AddUnknownUnit.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_AddUnknownUnit.Name = "textBox_AddUnknownUnit";
            this.textBox_AddUnknownUnit.Size = new System.Drawing.Size(157, 22);
            this.textBox_AddUnknownUnit.TabIndex = 22;
            // 
            // textBox_addUnknownName
            // 
            this.textBox_addUnknownName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_addUnknownName.Location = new System.Drawing.Point(162, 154);
            this.textBox_addUnknownName.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_addUnknownName.Name = "textBox_addUnknownName";
            this.textBox_addUnknownName.Size = new System.Drawing.Size(157, 22);
            this.textBox_addUnknownName.TabIndex = 23;
            // 
            // button_rand
            // 
            this.button_rand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(81)))));
            this.button_rand.FlatAppearance.BorderSize = 0;
            this.button_rand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_rand.Font = new System.Drawing.Font("Yu Gothic Medium", 11F, System.Drawing.FontStyle.Bold);
            this.button_rand.ForeColor = System.Drawing.SystemColors.Control;
            this.button_rand.Location = new System.Drawing.Point(293, 212);
            this.button_rand.Margin = new System.Windows.Forms.Padding(2);
            this.button_rand.Name = "button_rand";
            this.button_rand.Size = new System.Drawing.Size(181, 61);
            this.button_rand.TabIndex = 10;
            this.button_rand.Text = "Randomisera";
            this.button_rand.UseVisualStyleBackColor = false;
            this.button_rand.Click += new System.EventHandler(this.button_rand_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(81)))));
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Controls.Add(this.label_stats);
            this.panel2.Location = new System.Drawing.Point(293, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(262, 132);
            this.panel2.TabIndex = 9;
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 31);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(245, 103);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // labelAmountDays
            // 
            this.labelAmountDays.AutoSize = true;
            this.labelAmountDays.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAmountDays.Font = new System.Drawing.Font("Yu Gothic Medium", 10F, System.Drawing.FontStyle.Bold);
            this.labelAmountDays.ForeColor = System.Drawing.SystemColors.Control;
            this.labelAmountDays.Location = new System.Drawing.Point(2, 51);
            this.labelAmountDays.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAmountDays.Name = "labelAmountDays";
            this.labelAmountDays.Size = new System.Drawing.Size(182, 52);
            this.labelAmountDays.TabIndex = 6;
            this.labelAmountDays.Text = "Antal Dagar:";
            // 
            // labelAmountPort
            // 
            this.labelAmountPort.AutoSize = true;
            this.labelAmountPort.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelAmountPort.Font = new System.Drawing.Font("Yu Gothic Medium", 10F, System.Drawing.FontStyle.Bold);
            this.labelAmountPort.ForeColor = System.Drawing.SystemColors.Control;
            this.labelAmountPort.Location = new System.Drawing.Point(2, 0);
            this.labelAmountPort.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAmountPort.Name = "labelAmountPort";
            this.labelAmountPort.Size = new System.Drawing.Size(149, 51);
            this.labelAmountPort.TabIndex = 6;
            this.labelAmountPort.Text = "Antal portioner:";
            // 
            // labelCountAmountPort
            // 
            this.labelCountAmountPort.AutoSize = true;
            this.labelCountAmountPort.Font = new System.Drawing.Font("Yu Gothic Medium", 10F, System.Drawing.FontStyle.Bold);
            this.labelCountAmountPort.ForeColor = System.Drawing.SystemColors.Control;
            this.labelCountAmountPort.Location = new System.Drawing.Point(188, 0);
            this.labelCountAmountPort.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCountAmountPort.Name = "labelCountAmountPort";
            this.labelCountAmountPort.Size = new System.Drawing.Size(20, 22);
            this.labelCountAmountPort.TabIndex = 6;
            this.labelCountAmountPort.Text = "0";
            // 
            // labelCountAmountDays
            // 
            this.labelCountAmountDays.AutoSize = true;
            this.labelCountAmountDays.Font = new System.Drawing.Font("Yu Gothic Medium", 10F, System.Drawing.FontStyle.Bold);
            this.labelCountAmountDays.ForeColor = System.Drawing.SystemColors.Control;
            this.labelCountAmountDays.Location = new System.Drawing.Point(188, 51);
            this.labelCountAmountDays.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCountAmountDays.Name = "labelCountAmountDays";
            this.labelCountAmountDays.Size = new System.Drawing.Size(20, 22);
            this.labelCountAmountDays.TabIndex = 6;
            this.labelCountAmountDays.Text = "0";
            // 
            // label_stats
            // 
            this.label_stats.AutoSize = true;
            this.label_stats.Font = new System.Drawing.Font("Yu Gothic Medium", 14F, System.Drawing.FontStyle.Bold);
            this.label_stats.ForeColor = System.Drawing.SystemColors.Control;
            this.label_stats.Location = new System.Drawing.Point(3, 2);
            this.label_stats.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_stats.Name = "label_stats";
            this.label_stats.Size = new System.Drawing.Size(119, 31);
            this.label_stats.TabIndex = 6;
            this.label_stats.Text = "Statestik";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
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
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(250, 751);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // comboBox_monday
            // 
            this.comboBox_monday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_monday.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_monday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_monday.FormattingEnabled = true;
            this.comboBox_monday.Location = new System.Drawing.Point(2, 55);
            this.comboBox_monday.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_monday.Name = "comboBox_monday";
            this.comboBox_monday.Size = new System.Drawing.Size(246, 24);
            this.comboBox_monday.TabIndex = 8;
            this.comboBox_monday.SelectedIndexChanged += new System.EventHandler(this.comboBox_monday_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic Medium", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(70, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Måndag";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic Medium", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(78, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tisdag";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic Medium", 14F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(73, 223);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Onsdag";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic Medium", 14F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(71, 329);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 31);
            this.label4.TabIndex = 6;
            this.label4.Text = "Torsdag";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic Medium", 14F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(77, 435);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 31);
            this.label5.TabIndex = 6;
            this.label5.Text = "Fredag";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic Medium", 14F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(77, 541);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 31);
            this.label6.TabIndex = 6;
            this.label6.Text = "Lördag";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic Medium", 14F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(74, 647);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 31);
            this.label7.TabIndex = 6;
            this.label7.Text = "Söndag";
            // 
            // comboBox_tuesday
            // 
            this.comboBox_tuesday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_tuesday.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_tuesday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_tuesday.FormattingEnabled = true;
            this.comboBox_tuesday.Location = new System.Drawing.Point(2, 161);
            this.comboBox_tuesday.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_tuesday.Name = "comboBox_tuesday";
            this.comboBox_tuesday.Size = new System.Drawing.Size(246, 24);
            this.comboBox_tuesday.TabIndex = 8;
            this.comboBox_tuesday.SelectedIndexChanged += new System.EventHandler(this.comboBox_monday_SelectedIndexChanged);
            // 
            // comboBox_wednesday
            // 
            this.comboBox_wednesday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_wednesday.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_wednesday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_wednesday.FormattingEnabled = true;
            this.comboBox_wednesday.Location = new System.Drawing.Point(2, 267);
            this.comboBox_wednesday.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_wednesday.Name = "comboBox_wednesday";
            this.comboBox_wednesday.Size = new System.Drawing.Size(246, 24);
            this.comboBox_wednesday.TabIndex = 8;
            this.comboBox_wednesday.SelectedIndexChanged += new System.EventHandler(this.comboBox_monday_SelectedIndexChanged);
            // 
            // comboBox_thursday
            // 
            this.comboBox_thursday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_thursday.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_thursday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_thursday.FormattingEnabled = true;
            this.comboBox_thursday.Location = new System.Drawing.Point(2, 373);
            this.comboBox_thursday.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_thursday.Name = "comboBox_thursday";
            this.comboBox_thursday.Size = new System.Drawing.Size(246, 24);
            this.comboBox_thursday.TabIndex = 8;
            this.comboBox_thursday.SelectedIndexChanged += new System.EventHandler(this.comboBox_monday_SelectedIndexChanged);
            // 
            // comboBox_friday
            // 
            this.comboBox_friday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_friday.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_friday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_friday.FormattingEnabled = true;
            this.comboBox_friday.Location = new System.Drawing.Point(2, 479);
            this.comboBox_friday.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_friday.Name = "comboBox_friday";
            this.comboBox_friday.Size = new System.Drawing.Size(246, 24);
            this.comboBox_friday.TabIndex = 8;
            this.comboBox_friday.SelectedIndexChanged += new System.EventHandler(this.comboBox_monday_SelectedIndexChanged);
            // 
            // comboBox_saturday
            // 
            this.comboBox_saturday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_saturday.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_saturday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_saturday.FormattingEnabled = true;
            this.comboBox_saturday.Location = new System.Drawing.Point(2, 585);
            this.comboBox_saturday.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_saturday.Name = "comboBox_saturday";
            this.comboBox_saturday.Size = new System.Drawing.Size(246, 24);
            this.comboBox_saturday.TabIndex = 8;
            this.comboBox_saturday.SelectedIndexChanged += new System.EventHandler(this.comboBox_monday_SelectedIndexChanged);
            // 
            // comboBox_sunday
            // 
            this.comboBox_sunday.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox_sunday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_sunday.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_sunday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_sunday.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F);
            this.comboBox_sunday.ForeColor = System.Drawing.SystemColors.ControlText;
            this.comboBox_sunday.Location = new System.Drawing.Point(0, 689);
            this.comboBox_sunday.Margin = new System.Windows.Forms.Padding(0);
            this.comboBox_sunday.Name = "comboBox_sunday";
            this.comboBox_sunday.Size = new System.Drawing.Size(250, 25);
            this.comboBox_sunday.Sorted = true;
            this.comboBox_sunday.TabIndex = 8;
            this.comboBox_sunday.SelectedIndexChanged += new System.EventHandler(this.comboBox_monday_SelectedIndexChanged);
            // 
            // button_Create_menu
            // 
            this.button_Create_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(81)))));
            this.button_Create_menu.Enabled = false;
            this.button_Create_menu.FlatAppearance.BorderSize = 0;
            this.button_Create_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Create_menu.Font = new System.Drawing.Font("Yu Gothic Medium", 11F, System.Drawing.FontStyle.Bold);
            this.button_Create_menu.ForeColor = System.Drawing.SystemColors.Control;
            this.button_Create_menu.Location = new System.Drawing.Point(293, 290);
            this.button_Create_menu.Margin = new System.Windows.Forms.Padding(2);
            this.button_Create_menu.Name = "button_Create_menu";
            this.button_Create_menu.Size = new System.Drawing.Size(181, 61);
            this.button_Create_menu.TabIndex = 4;
            this.button_Create_menu.Text = "Skapa meny";
            this.button_Create_menu.UseVisualStyleBackColor = false;
            this.button_Create_menu.Click += new System.EventHandler(this.button_Create_menu_Click);
            // 
            // FormFoodlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 801);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormFoodlist";
            this.Text = "FormFoodlist";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel_EditMenu.ResumeLayout(false);
            this.tableLayoutPanel_EditMenu.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
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
        private System.Windows.Forms.Button button_rand;
        private System.Windows.Forms.ListView listView_ingredients;
        private System.Windows.Forms.ColumnHeader columnHeader_nameIng;
        private System.Windows.Forms.ColumnHeader columnHeader_amount_ing;
        private System.Windows.Forms.ColumnHeader columnHeader_unit_ing;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_EditMenu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button_changeamount;
        private System.Windows.Forms.Button buttonRemoveIngredient;
        private System.Windows.Forms.TextBox textBox_ingredient_amount;
        private System.Windows.Forms.TextBox textBox_AddUnknownAmount;
        private System.Windows.Forms.Button button_add_unknown;
        private System.Windows.Forms.TextBox textBox_AddUnknownUnit;
        private System.Windows.Forms.TextBox textBox_addUnknownName;
        private System.Windows.Forms.Button button_check;
    }
}