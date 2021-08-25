
namespace FinalRecipeApp.Forms
{
    partial class FormRecipe
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
            this.tableLayoutPanel_buttonrow = new System.Windows.Forms.TableLayoutPanel();
            this.button_remove = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.button_addnewing = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.listView_ing = new System.Windows.Forms.ListView();
            this.columnHeader_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_unit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.listView_info = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listBox_recipes = new System.Windows.Forms.ListBox();
            this.panel_hidden = new System.Windows.Forms.Panel();
            this.listView_tags = new System.Windows.Forms.ListBox();
            this.listView_selected_ingredienses = new System.Windows.Forms.ListView();
            this.columnHeader_nameIng = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_amount_ing = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_unit_ing = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel_recipenameTag = new System.Windows.Forms.TableLayoutPanel();
            this.button_add_ing = new System.Windows.Forms.Button();
            this.button_add_tagg = new System.Windows.Forms.Button();
            this.textBox_tags = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_amount_port = new System.Windows.Forms.TextBox();
            this.labelRecipeName = new System.Windows.Forms.Label();
            this.textBox_recipename = new System.Windows.Forms.TextBox();
            this.label_AmountPort = new System.Windows.Forms.Label();
            this.tableLayoutPanel_adding = new System.Windows.Forms.TableLayoutPanel();
            this.button_remove_ing = new System.Windows.Forms.Button();
            this.button_Done = new System.Windows.Forms.Button();
            this.button_add_ingrediens = new System.Windows.Forms.Button();
            this.textBox_antal = new System.Windows.Forms.TextBox();
            this.label_ingred = new System.Windows.Forms.Label();
            this.label_antal_ing = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label_currentunit = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel_buttonrow.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel_hidden.SuspendLayout();
            this.tableLayoutPanel_recipenameTag.SuspendLayout();
            this.tableLayoutPanel_adding.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(113)))));
            this.panel1.Controls.Add(this.tableLayoutPanel_buttonrow);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.panel_hidden);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1673, 1126);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel_buttonrow
            // 
            this.tableLayoutPanel_buttonrow.ColumnCount = 4;
            this.tableLayoutPanel_buttonrow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_buttonrow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_buttonrow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_buttonrow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_buttonrow.Controls.Add(this.button_remove, 1, 0);
            this.tableLayoutPanel_buttonrow.Controls.Add(this.button_add, 0, 0);
            this.tableLayoutPanel_buttonrow.Controls.Add(this.button_addnewing, 2, 0);
            this.tableLayoutPanel_buttonrow.Controls.Add(this.button_edit, 3, 0);
            this.tableLayoutPanel_buttonrow.Location = new System.Drawing.Point(0, 736);
            this.tableLayoutPanel_buttonrow.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel_buttonrow.Name = "tableLayoutPanel_buttonrow";
            this.tableLayoutPanel_buttonrow.RowCount = 1;
            this.tableLayoutPanel_buttonrow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_buttonrow.Size = new System.Drawing.Size(901, 99);
            this.tableLayoutPanel_buttonrow.TabIndex = 2;
            // 
            // button_remove
            // 
            this.button_remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(81)))));
            this.button_remove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_remove.Font = new System.Drawing.Font("Yu Gothic Medium", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_remove.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_remove.Location = new System.Drawing.Point(229, 3);
            this.button_remove.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(217, 93);
            this.button_remove.TabIndex = 0;
            this.button_remove.Text = "Remove Recipe";
            this.button_remove.UseVisualStyleBackColor = false;
            this.button_remove.Click += new System.EventHandler(this.button_remove_Click);
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(81)))));
            this.button_add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Font = new System.Drawing.Font("Yu Gothic Medium", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_add.Location = new System.Drawing.Point(4, 3);
            this.button_add.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(217, 93);
            this.button_add.TabIndex = 0;
            this.button_add.Text = "Add recipe";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_addnewing
            // 
            this.button_addnewing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(81)))));
            this.button_addnewing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_addnewing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_addnewing.Font = new System.Drawing.Font("Yu Gothic Medium", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addnewing.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_addnewing.Location = new System.Drawing.Point(454, 3);
            this.button_addnewing.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_addnewing.Name = "button_addnewing";
            this.button_addnewing.Size = new System.Drawing.Size(217, 93);
            this.button_addnewing.TabIndex = 0;
            this.button_addnewing.Text = "Add ingredient";
            this.button_addnewing.UseVisualStyleBackColor = false;
            this.button_addnewing.Click += new System.EventHandler(this.button_addnewing_Click);
            // 
            // button_edit
            // 
            this.button_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(81)))));
            this.button_edit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_edit.Font = new System.Drawing.Font("Yu Gothic Medium", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_edit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_edit.Location = new System.Drawing.Point(679, 3);
            this.button_edit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(218, 93);
            this.button_edit.TabIndex = 0;
            this.button_edit.Text = "Edit Recipe";
            this.button_edit.UseVisualStyleBackColor = false;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.listView_ing, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 3);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(908, 732);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // listView_ing
            // 
            this.listView_ing.BackColor = System.Drawing.SystemColors.Control;
            this.listView_ing.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_name,
            this.columnHeader_amount,
            this.columnHeader_unit});
            this.listView_ing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_ing.GridLines = true;
            this.listView_ing.HideSelection = false;
            this.listView_ing.Location = new System.Drawing.Point(458, 3);
            this.listView_ing.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listView_ing.Name = "listView_ing";
            this.listView_ing.Size = new System.Drawing.Size(446, 726);
            this.listView_ing.TabIndex = 0;
            this.listView_ing.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader_name
            // 
            this.columnHeader_name.Text = "Name";
            // 
            // columnHeader_amount
            // 
            this.columnHeader_amount.Text = "Amount";
            // 
            // columnHeader_unit
            // 
            this.columnHeader_unit.Text = "Unit";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.listView_info, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.listBox_recipes, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(454, 732);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // listView_info
            // 
            this.listView_info.BackColor = System.Drawing.SystemColors.Control;
            this.listView_info.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView_info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_info.GridLines = true;
            this.listView_info.HideSelection = false;
            this.listView_info.Location = new System.Drawing.Point(4, 552);
            this.listView_info.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listView_info.Name = "listView_info";
            this.listView_info.Size = new System.Drawing.Size(446, 177);
            this.listView_info.TabIndex = 0;
            this.listView_info.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Portions";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Type";
            // 
            // listBox_recipes
            // 
            this.listBox_recipes.BackColor = System.Drawing.SystemColors.Control;
            this.listBox_recipes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_recipes.FormattingEnabled = true;
            this.listBox_recipes.ItemHeight = 24;
            this.listBox_recipes.Location = new System.Drawing.Point(4, 3);
            this.listBox_recipes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listBox_recipes.Name = "listBox_recipes";
            this.listBox_recipes.Size = new System.Drawing.Size(446, 543);
            this.listBox_recipes.TabIndex = 0;
            this.listBox_recipes.SelectedIndexChanged += new System.EventHandler(this.listBox_recipes_SelectedIndexChanged);
            // 
            // panel_hidden
            // 
            this.panel_hidden.Controls.Add(this.listView_tags);
            this.panel_hidden.Controls.Add(this.listView_selected_ingredienses);
            this.panel_hidden.Controls.Add(this.tableLayoutPanel_recipenameTag);
            this.panel_hidden.Controls.Add(this.tableLayoutPanel_adding);
            this.panel_hidden.Location = new System.Drawing.Point(908, 3);
            this.panel_hidden.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel_hidden.Name = "panel_hidden";
            this.panel_hidden.Size = new System.Drawing.Size(766, 832);
            this.panel_hidden.TabIndex = 0;
            this.panel_hidden.Visible = false;
            // 
            // listView_tags
            // 
            this.listView_tags.FormattingEnabled = true;
            this.listView_tags.ItemHeight = 24;
            this.listView_tags.Location = new System.Drawing.Point(6, 537);
            this.listView_tags.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listView_tags.Name = "listView_tags";
            this.listView_tags.Size = new System.Drawing.Size(352, 292);
            this.listView_tags.TabIndex = 3;
            // 
            // listView_selected_ingredienses
            // 
            this.listView_selected_ingredienses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_nameIng,
            this.columnHeader_amount_ing,
            this.columnHeader_unit_ing});
            this.listView_selected_ingredienses.HideSelection = false;
            this.listView_selected_ingredienses.Location = new System.Drawing.Point(364, 468);
            this.listView_selected_ingredienses.Margin = new System.Windows.Forms.Padding(4, 3, 1, 3);
            this.listView_selected_ingredienses.Name = "listView_selected_ingredienses";
            this.listView_selected_ingredienses.Size = new System.Drawing.Size(388, 362);
            this.listView_selected_ingredienses.TabIndex = 2;
            this.listView_selected_ingredienses.UseCompatibleStateImageBehavior = false;
            this.listView_selected_ingredienses.Visible = false;
            // 
            // columnHeader_nameIng
            // 
            this.columnHeader_nameIng.Text = "Name";
            // 
            // columnHeader_amount_ing
            // 
            this.columnHeader_amount_ing.Text = "Amount";
            // 
            // columnHeader_unit_ing
            // 
            this.columnHeader_unit_ing.Text = "Unit";
            // 
            // tableLayoutPanel_recipenameTag
            // 
            this.tableLayoutPanel_recipenameTag.ColumnCount = 1;
            this.tableLayoutPanel_recipenameTag.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_recipenameTag.Controls.Add(this.button_add_ing, 0, 7);
            this.tableLayoutPanel_recipenameTag.Controls.Add(this.button_add_tagg, 0, 6);
            this.tableLayoutPanel_recipenameTag.Controls.Add(this.textBox_tags, 0, 5);
            this.tableLayoutPanel_recipenameTag.Controls.Add(this.label1, 0, 4);
            this.tableLayoutPanel_recipenameTag.Controls.Add(this.textBox_amount_port, 0, 3);
            this.tableLayoutPanel_recipenameTag.Controls.Add(this.labelRecipeName, 0, 0);
            this.tableLayoutPanel_recipenameTag.Controls.Add(this.textBox_recipename, 0, 1);
            this.tableLayoutPanel_recipenameTag.Controls.Add(this.label_AmountPort, 0, 2);
            this.tableLayoutPanel_recipenameTag.Location = new System.Drawing.Point(4, 3);
            this.tableLayoutPanel_recipenameTag.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel_recipenameTag.Name = "tableLayoutPanel_recipenameTag";
            this.tableLayoutPanel_recipenameTag.RowCount = 8;
            this.tableLayoutPanel_recipenameTag.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel_recipenameTag.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel_recipenameTag.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel_recipenameTag.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel_recipenameTag.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel_recipenameTag.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel_recipenameTag.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel_recipenameTag.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel_recipenameTag.Size = new System.Drawing.Size(356, 531);
            this.tableLayoutPanel_recipenameTag.TabIndex = 0;
            // 
            // button_add_ing
            // 
            this.button_add_ing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(81)))));
            this.button_add_ing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_add_ing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add_ing.Font = new System.Drawing.Font("Yu Gothic Medium", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add_ing.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_add_ing.Location = new System.Drawing.Point(4, 465);
            this.button_add_ing.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_add_ing.Name = "button_add_ing";
            this.button_add_ing.Size = new System.Drawing.Size(348, 63);
            this.button_add_ing.TabIndex = 6;
            this.button_add_ing.Text = "Add ingredients";
            this.button_add_ing.UseVisualStyleBackColor = false;
            this.button_add_ing.Click += new System.EventHandler(this.button_add_ing_Click);
            // 
            // button_add_tagg
            // 
            this.button_add_tagg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(81)))));
            this.button_add_tagg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_add_tagg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add_tagg.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add_tagg.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_add_tagg.Location = new System.Drawing.Point(4, 399);
            this.button_add_tagg.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_add_tagg.Name = "button_add_tagg";
            this.button_add_tagg.Size = new System.Drawing.Size(348, 60);
            this.button_add_tagg.TabIndex = 5;
            this.button_add_tagg.Text = "Add Tag";
            this.button_add_tagg.UseVisualStyleBackColor = false;
            this.button_add_tagg.Click += new System.EventHandler(this.button_add_tagg_Click);
            // 
            // textBox_tags
            // 
            this.textBox_tags.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_tags.Location = new System.Drawing.Point(4, 333);
            this.textBox_tags.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_tags.Name = "textBox_tags";
            this.textBox_tags.Size = new System.Drawing.Size(348, 29);
            this.textBox_tags.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(146, 279);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tag";
            // 
            // textBox_amount_port
            // 
            this.textBox_amount_port.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_amount_port.Location = new System.Drawing.Point(4, 201);
            this.textBox_amount_port.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_amount_port.Name = "textBox_amount_port";
            this.textBox_amount_port.Size = new System.Drawing.Size(348, 29);
            this.textBox_amount_port.TabIndex = 2;
            // 
            // labelRecipeName
            // 
            this.labelRecipeName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelRecipeName.AutoSize = true;
            this.labelRecipeName.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold);
            this.labelRecipeName.ForeColor = System.Drawing.SystemColors.Control;
            this.labelRecipeName.Location = new System.Drawing.Point(78, 15);
            this.labelRecipeName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRecipeName.Name = "labelRecipeName";
            this.labelRecipeName.Size = new System.Drawing.Size(200, 36);
            this.labelRecipeName.TabIndex = 0;
            this.labelRecipeName.Text = "Recipe Name";
            // 
            // textBox_recipename
            // 
            this.textBox_recipename.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_recipename.Location = new System.Drawing.Point(4, 69);
            this.textBox_recipename.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_recipename.Name = "textBox_recipename";
            this.textBox_recipename.Size = new System.Drawing.Size(348, 29);
            this.textBox_recipename.TabIndex = 1;
            // 
            // label_AmountPort
            // 
            this.label_AmountPort.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_AmountPort.AutoSize = true;
            this.label_AmountPort.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold);
            this.label_AmountPort.ForeColor = System.Drawing.SystemColors.Control;
            this.label_AmountPort.Location = new System.Drawing.Point(38, 147);
            this.label_AmountPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_AmountPort.Name = "label_AmountPort";
            this.label_AmountPort.Size = new System.Drawing.Size(280, 36);
            this.label_AmountPort.TabIndex = 0;
            this.label_AmountPort.Text = "Amount of portions";
            // 
            // tableLayoutPanel_adding
            // 
            this.tableLayoutPanel_adding.ColumnCount = 1;
            this.tableLayoutPanel_adding.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_adding.Controls.Add(this.button_remove_ing, 0, 6);
            this.tableLayoutPanel_adding.Controls.Add(this.button_Done, 0, 5);
            this.tableLayoutPanel_adding.Controls.Add(this.button_add_ingrediens, 0, 4);
            this.tableLayoutPanel_adding.Controls.Add(this.label_ingred, 0, 0);
            this.tableLayoutPanel_adding.Controls.Add(this.label_antal_ing, 0, 2);
            this.tableLayoutPanel_adding.Controls.Add(this.comboBox1, 0, 1);
            this.tableLayoutPanel_adding.Controls.Add(this.tableLayoutPanel3, 0, 3);
            this.tableLayoutPanel_adding.Location = new System.Drawing.Point(364, 3);
            this.tableLayoutPanel_adding.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel_adding.Name = "tableLayoutPanel_adding";
            this.tableLayoutPanel_adding.RowCount = 7;
            this.tableLayoutPanel_adding.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel_adding.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel_adding.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel_adding.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel_adding.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel_adding.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel_adding.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel_adding.Size = new System.Drawing.Size(386, 459);
            this.tableLayoutPanel_adding.TabIndex = 1;
            this.tableLayoutPanel_adding.Visible = false;
            // 
            // button_remove_ing
            // 
            this.button_remove_ing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(81)))));
            this.button_remove_ing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_remove_ing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_remove_ing.Font = new System.Drawing.Font("Yu Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_remove_ing.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_remove_ing.Location = new System.Drawing.Point(4, 393);
            this.button_remove_ing.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_remove_ing.Name = "button_remove_ing";
            this.button_remove_ing.Size = new System.Drawing.Size(378, 63);
            this.button_remove_ing.TabIndex = 9;
            this.button_remove_ing.Text = "Remove selected ingredient";
            this.button_remove_ing.UseVisualStyleBackColor = false;
            this.button_remove_ing.Click += new System.EventHandler(this.button_remove_ing_Click);
            // 
            // button_Done
            // 
            this.button_Done.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(81)))));
            this.button_Done.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Done.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Done.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Done.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_Done.Location = new System.Drawing.Point(4, 328);
            this.button_Done.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_Done.Name = "button_Done";
            this.button_Done.Size = new System.Drawing.Size(378, 59);
            this.button_Done.TabIndex = 7;
            this.button_Done.Text = "Done";
            this.button_Done.UseVisualStyleBackColor = false;
            this.button_Done.Click += new System.EventHandler(this.button_Done_Click);
            // 
            // button_add_ingrediens
            // 
            this.button_add_ingrediens.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(81)))));
            this.button_add_ingrediens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_add_ingrediens.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add_ingrediens.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add_ingrediens.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_add_ingrediens.Location = new System.Drawing.Point(4, 263);
            this.button_add_ingrediens.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_add_ingrediens.Name = "button_add_ingrediens";
            this.button_add_ingrediens.Size = new System.Drawing.Size(378, 59);
            this.button_add_ingrediens.TabIndex = 6;
            this.button_add_ingrediens.Text = "Add";
            this.button_add_ingrediens.UseVisualStyleBackColor = false;
            this.button_add_ingrediens.Click += new System.EventHandler(this.button_add_ingrediens_Click);
            // 
            // textBox_antal
            // 
            this.textBox_antal.Location = new System.Drawing.Point(4, 3);
            this.textBox_antal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_antal.Name = "textBox_antal";
            this.textBox_antal.Size = new System.Drawing.Size(246, 29);
            this.textBox_antal.TabIndex = 5;
            // 
            // label_ingred
            // 
            this.label_ingred.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_ingred.AutoSize = true;
            this.label_ingred.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold);
            this.label_ingred.ForeColor = System.Drawing.SystemColors.Control;
            this.label_ingred.Location = new System.Drawing.Point(108, 14);
            this.label_ingred.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ingred.Name = "label_ingred";
            this.label_ingred.Size = new System.Drawing.Size(170, 36);
            this.label_ingred.TabIndex = 0;
            this.label_ingred.Text = "Ingredients";
            // 
            // label_antal_ing
            // 
            this.label_antal_ing.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_antal_ing.AutoSize = true;
            this.label_antal_ing.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold);
            this.label_antal_ing.ForeColor = System.Drawing.SystemColors.Control;
            this.label_antal_ing.Location = new System.Drawing.Point(132, 144);
            this.label_antal_ing.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_antal_ing.Name = "label_antal_ing";
            this.label_antal_ing.Size = new System.Drawing.Size(121, 36);
            this.label_antal_ing.TabIndex = 0;
            this.label_antal_ing.Text = "Amount";
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(4, 68);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(378, 32);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.Click += new System.EventHandler(this.comboBox1_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.10526F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.89474F));
            this.tableLayoutPanel3.Controls.Add(this.textBox_antal, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label_currentunit, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 198);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(380, 59);
            this.tableLayoutPanel3.TabIndex = 10;
            // 
            // label_currentunit
            // 
            this.label_currentunit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label_currentunit.AutoSize = true;
            this.label_currentunit.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold);
            this.label_currentunit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_currentunit.Location = new System.Drawing.Point(317, 0);
            this.label_currentunit.Name = "label_currentunit";
            this.label_currentunit.Size = new System.Drawing.Size(0, 59);
            this.label_currentunit.TabIndex = 6;
            // 
            // FormRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1898, 1304);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormRecipe";
            this.Text = "FormRecipe";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel_buttonrow.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel_hidden.ResumeLayout(false);
            this.tableLayoutPanel_recipenameTag.ResumeLayout(false);
            this.tableLayoutPanel_recipenameTag.PerformLayout();
            this.tableLayoutPanel_adding.ResumeLayout(false);
            this.tableLayoutPanel_adding.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBox_recipes;
        private System.Windows.Forms.ListView listView_ing;
        private System.Windows.Forms.Button button_remove;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.ListView listView_info;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_buttonrow;
        private System.Windows.Forms.Button button_addnewing;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_recipenameTag;
        private System.Windows.Forms.Button button_add_ing;
        private System.Windows.Forms.Button button_add_tagg;
        private System.Windows.Forms.TextBox textBox_tags;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_amount_port;
        private System.Windows.Forms.Label labelRecipeName;
        private System.Windows.Forms.TextBox textBox_recipename;
        private System.Windows.Forms.Label label_AmountPort;
        private System.Windows.Forms.ListView listView_selected_ingredienses;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_adding;
        private System.Windows.Forms.Button button_Done;
        private System.Windows.Forms.Button button_add_ingrediens;
        private System.Windows.Forms.TextBox textBox_antal;
        private System.Windows.Forms.Label label_ingred;
        private System.Windows.Forms.Label label_antal_ing;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel_hidden;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader_name;
        private System.Windows.Forms.ColumnHeader columnHeader_amount;
        private System.Windows.Forms.ColumnHeader columnHeader_unit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ColumnHeader columnHeader_nameIng;
        private System.Windows.Forms.ColumnHeader columnHeader_amount_ing;
        private System.Windows.Forms.ColumnHeader columnHeader_unit_ing;
        private System.Windows.Forms.ListBox listView_tags;
        private System.Windows.Forms.Button button_remove_ing;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label_currentunit;
    }
}