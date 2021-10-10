
namespace FinalRecipeApp.Forms
{
    partial class FormLogin
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
            this.tableLayoutPanel_SQL = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_database = new System.Windows.Forms.TextBox();
            this.textBox_server = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.label_username = new System.Windows.Forms.Label();
            this.label_status = new System.Windows.Forms.Label();
            this.labelSetStatus = new System.Windows.Forms.Label();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button_Login = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel_SQL.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel_SQL);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1369, 938);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel_SQL
            // 
            this.tableLayoutPanel_SQL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(81)))));
            this.tableLayoutPanel_SQL.ColumnCount = 2;
            this.tableLayoutPanel_SQL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_SQL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_SQL.Controls.Add(this.textBox_database, 1, 4);
            this.tableLayoutPanel_SQL.Controls.Add(this.textBox_server, 1, 3);
            this.tableLayoutPanel_SQL.Controls.Add(this.label2, 0, 4);
            this.tableLayoutPanel_SQL.Controls.Add(this.label1, 0, 3);
            this.tableLayoutPanel_SQL.Controls.Add(this.labelPassword, 0, 2);
            this.tableLayoutPanel_SQL.Controls.Add(this.label_username, 0, 1);
            this.tableLayoutPanel_SQL.Controls.Add(this.label_status, 0, 0);
            this.tableLayoutPanel_SQL.Controls.Add(this.labelSetStatus, 1, 0);
            this.tableLayoutPanel_SQL.Controls.Add(this.textBox_username, 1, 1);
            this.tableLayoutPanel_SQL.Controls.Add(this.textBox_password, 1, 2);
            this.tableLayoutPanel_SQL.Controls.Add(this.button2, 0, 5);
            this.tableLayoutPanel_SQL.Controls.Add(this.button_Login, 1, 5);
            this.tableLayoutPanel_SQL.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanel_SQL.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tableLayoutPanel_SQL.Name = "tableLayoutPanel_SQL";
            this.tableLayoutPanel_SQL.RowCount = 6;
            this.tableLayoutPanel_SQL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel_SQL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel_SQL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel_SQL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel_SQL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel_SQL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel_SQL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel_SQL.Size = new System.Drawing.Size(411, 602);
            this.tableLayoutPanel_SQL.TabIndex = 9;
            // 
            // textBox_database
            // 
            this.textBox_database.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_database.Location = new System.Drawing.Point(210, 437);
            this.textBox_database.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBox_database.Name = "textBox_database";
            this.textBox_database.Size = new System.Drawing.Size(196, 26);
            this.textBox_database.TabIndex = 10;
            this.textBox_database.Text = "foodlist";
            // 
            // textBox_server
            // 
            this.textBox_server.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_server.Location = new System.Drawing.Point(210, 337);
            this.textBox_server.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBox_server.Name = "textBox_server";
            this.textBox_server.Size = new System.Drawing.Size(196, 26);
            this.textBox_server.TabIndex = 10;
            this.textBox_server.Text = "192.168.0.12";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(41, 435);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "Database";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(57, 335);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Server";
            // 
            // labelPassword
            // 
            this.labelPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelPassword.ForeColor = System.Drawing.SystemColors.Control;
            this.labelPassword.Location = new System.Drawing.Point(38, 235);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(128, 29);
            this.labelPassword.TabIndex = 10;
            this.labelPassword.Text = "Password";
            // 
            // label_username
            // 
            this.label_username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label_username.ForeColor = System.Drawing.SystemColors.Control;
            this.label_username.Location = new System.Drawing.Point(36, 135);
            this.label_username.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(132, 29);
            this.label_username.TabIndex = 9;
            this.label_username.Text = "Username";
            // 
            // label_status
            // 
            this.label_status.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_status.AutoSize = true;
            this.label_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label_status.ForeColor = System.Drawing.SystemColors.Control;
            this.label_status.Location = new System.Drawing.Point(53, 35);
            this.label_status.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(99, 29);
            this.label_status.TabIndex = 0;
            this.label_status.Text = "Status: ";
            // 
            // labelSetStatus
            // 
            this.labelSetStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSetStatus.AutoSize = true;
            this.labelSetStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelSetStatus.ForeColor = System.Drawing.SystemColors.Control;
            this.labelSetStatus.Location = new System.Drawing.Point(214, 35);
            this.labelSetStatus.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelSetStatus.Name = "labelSetStatus";
            this.labelSetStatus.Size = new System.Drawing.Size(187, 29);
            this.labelSetStatus.TabIndex = 1;
            this.labelSetStatus.Text = "Not Connected";
            // 
            // textBox_username
            // 
            this.textBox_username.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_username.Location = new System.Drawing.Point(210, 137);
            this.textBox_username.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(196, 26);
            this.textBox_username.TabIndex = 7;
            this.textBox_username.Text = "raspberry";
            // 
            // textBox_password
            // 
            this.textBox_password.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_password.Location = new System.Drawing.Point(210, 237);
            this.textBox_password.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '*';
            this.textBox_password.Size = new System.Drawing.Size(196, 26);
            this.textBox_password.TabIndex = 8;
            this.textBox_password.Text = "raspberry";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(81)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(6, 502);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(196, 98);
            this.button2.TabIndex = 12;
            this.button2.Text = "Status";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button_Login
            // 
            this.button_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(81)))));
            this.button_Login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Login.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Login.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_Login.Location = new System.Drawing.Point(208, 502);
            this.button_Login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(200, 98);
            this.button_Login.TabIndex = 6;
            this.button_Login.Text = "Log in";
            this.button_Login.UseVisualStyleBackColor = false;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(113)))));
            this.ClientSize = new System.Drawing.Size(1409, 987);
            this.Controls.Add(this.panel1);
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel_SQL.ResumeLayout(false);
            this.tableLayoutPanel_SQL.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_SQL;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.Label labelSetStatus;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox_database;
        private System.Windows.Forms.TextBox textBox_server;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}