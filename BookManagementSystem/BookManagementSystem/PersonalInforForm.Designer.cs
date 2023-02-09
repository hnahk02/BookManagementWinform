namespace BookManagementSystem
{
    partial class PersonalInforForm
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
            this.back_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textbox_password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.texbox_displayname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textbox_username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.back_btn);
            this.panel1.Controls.Add(this.update_btn);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textbox_password);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.texbox_displayname);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textbox_username);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(578, 433);
            this.panel1.TabIndex = 0;
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(420, 351);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(87, 35);
            this.back_btn.TabIndex = 9;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.Location = new System.Drawing.Point(295, 351);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(87, 35);
            this.update_btn.TabIndex = 8;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(191, 225);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(305, 27);
            this.textBox4.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "label4";
            // 
            // textbox_password
            // 
            this.textbox_password.Location = new System.Drawing.Point(191, 161);
            this.textbox_password.Name = "textbox_password";
            this.textbox_password.ReadOnly = true;
            this.textbox_password.Size = new System.Drawing.Size(305, 27);
            this.textbox_password.TabIndex = 5;
            this.textbox_password.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // texbox_displayname
            // 
            this.texbox_displayname.Location = new System.Drawing.Point(191, 101);
            this.texbox_displayname.Name = "texbox_displayname";
            this.texbox_displayname.ReadOnly = true;
            this.texbox_displayname.Size = new System.Drawing.Size(305, 27);
            this.texbox_displayname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Display name";
            // 
            // textbox_username
            // 
            this.textbox_username.Location = new System.Drawing.Point(191, 48);
            this.textbox_username.Name = "textbox_username";
            this.textbox_username.ReadOnly = true;
            this.textbox_username.Size = new System.Drawing.Size(305, 27);
            this.textbox_username.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // PersonalInforForm
            // 
            this.AcceptButton = this.update_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.back_btn;
            this.ClientSize = new System.Drawing.Size(578, 433);
            this.Controls.Add(this.panel1);
            this.Name = "PersonalInforForm";
            this.Text = "Personal Information";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private TextBox textBox4;
        private Label label4;
        private TextBox textbox_password;
        private Label label3;
        private TextBox texbox_displayname;
        private Label label2;
        private TextBox textbox_username;
        private Label label1;
        private Button back_btn;
        private Button update_btn;
    }
}