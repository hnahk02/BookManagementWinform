namespace BookShoppingManagement
{
    partial class frmUsersManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsersManagement));
            lbBooks = new Label();
            label2 = new Label();
            panel4 = new Panel();
            panel3 = new Panel();
            btnReset = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnSave = new Button();
            txtPassword = new TextBox();
            lbLogout = new Label();
            panel6 = new Panel();
            lbDashboard = new Label();
            label9 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            txtPhone = new TextBox();
            txtUsername = new TextBox();
            panel2 = new Panel();
            label8 = new Label();
            panel5 = new Panel();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            txtAddress = new TextBox();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lbBooks
            // 
            lbBooks.AutoSize = true;
            lbBooks.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            lbBooks.ForeColor = SystemColors.AppWorkspace;
            lbBooks.Location = new Point(3, 0);
            lbBooks.Name = "lbBooks";
            lbBooks.Size = new Size(110, 46);
            lbBooks.TabIndex = 1;
            lbBooks.Text = "Books";
            lbBooks.Click += lbBooks_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.AppWorkspace;
            label2.Location = new Point(5, -3);
            label2.Name = "label2";
            label2.Size = new Size(101, 46);
            label2.TabIndex = 1;
            label2.Text = "Users";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Green;
            panel4.Controls.Add(label2);
            panel4.Location = new Point(-2, 250);
            panel4.Name = "panel4";
            panel4.Size = new Size(245, 49);
            panel4.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaptionText;
            panel3.Controls.Add(lbBooks);
            panel3.Location = new Point(0, 195);
            panel3.Name = "panel3";
            panel3.Size = new Size(245, 49);
            panel3.TabIndex = 1;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.PaleGreen;
            btnReset.ForeColor = Color.Black;
            btnReset.Location = new Point(889, 150);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 29);
            btnReset.TabIndex = 14;
            btnReset.Text = "Refresh";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.PaleGreen;
            btnDelete.ForeColor = Color.Black;
            btnDelete.Location = new Point(747, 150);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.PaleGreen;
            btnEdit.ForeColor = Color.Black;
            btnEdit.Location = new Point(608, 150);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 12;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.PaleGreen;
            btnSave.ForeColor = Color.Black;
            btnSave.Location = new Point(474, 150);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(934, 60);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(210, 34);
            txtPassword.TabIndex = 10;
            // 
            // lbLogout
            // 
            lbLogout.AutoSize = true;
            lbLogout.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            lbLogout.ForeColor = SystemColors.AppWorkspace;
            lbLogout.Location = new Point(5, 0);
            lbLogout.Name = "lbLogout";
            lbLogout.Size = new Size(127, 46);
            lbLogout.TabIndex = 1;
            lbLogout.Text = "Logout";
            lbLogout.Click += lbLogout_Click;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ActiveCaptionText;
            panel6.Controls.Add(lbDashboard);
            panel6.Location = new Point(-2, 305);
            panel6.Name = "panel6";
            panel6.Size = new Size(245, 49);
            panel6.TabIndex = 3;
            // 
            // lbDashboard
            // 
            lbDashboard.AutoSize = true;
            lbDashboard.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            lbDashboard.ForeColor = SystemColors.AppWorkspace;
            lbDashboard.Location = new Point(5, -3);
            lbDashboard.Name = "lbDashboard";
            lbDashboard.Size = new Size(136, 46);
            lbDashboard.TabIndex = 1;
            lbDashboard.Text = "Statistic";
            lbDashboard.Click += lbDashboard_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(64, 0, 0);
            label9.Location = new Point(934, 23);
            label9.Name = "label9";
            label9.Size = new Size(102, 26);
            label9.TabIndex = 9;
            label9.Text = "Password";
            label9.Click += label9_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(64, 0, 0);
            label7.Location = new Point(504, 23);
            label7.Name = "label7";
            label7.Size = new Size(123, 26);
            label7.TabIndex = 7;
            label7.Text = "Phone Num";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(64, 0, 0);
            label6.Location = new Point(722, 23);
            label6.Name = "label6";
            label6.Size = new Size(88, 26);
            label6.TabIndex = 6;
            label6.Text = "Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(64, 0, 0);
            label5.Location = new Point(256, 23);
            label5.Name = "label5";
            label5.Size = new Size(104, 26);
            label5.TabIndex = 5;
            label5.Text = "Username";
            label5.Click += label5_Click;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(504, 60);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(180, 34);
            txtPhone.TabIndex = 4;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(256, 60);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(205, 34);
            txtUsername.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MediumPurple;
            panel2.Controls.Add(label8);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(0, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 557);
            panel2.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.BurlyWood;
            label8.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(64, 0, 0);
            label8.Location = new Point(24, 137);
            label8.Name = "label8";
            label8.Size = new Size(209, 34);
            label8.TabIndex = 38;
            label8.Text = "BOOK'S SHOP";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ActiveCaptionText;
            panel5.Controls.Add(lbLogout);
            panel5.Location = new Point(-2, 360);
            panel5.Name = "panel5";
            panel5.Size = new Size(245, 49);
            panel5.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.LightSteelBlue;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(74, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 98);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 37;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Thistle;
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(txtAddress);
            panel1.Controls.Add(btnReset);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtPhone);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(panel2);
            panel1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.ForeColor = Color.IndianRed;
            panel1.Location = new Point(1, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1155, 563);
            panel1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(315, 240);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(804, 278);
            dataGridView1.TabIndex = 19;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(722, 60);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(192, 34);
            txtAddress.TabIndex = 16;
            // 
            // frmUsersManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1157, 565);
            Controls.Add(panel1);
            Name = "frmUsersManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Users";
            Load += Users_Load;
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lbBooks;
        private Label label2;
        private Panel panel4;
        private Panel panel3;
        private Button btnReset;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnSave;
        private TextBox txtPassword;
        private Label lbLogout;
        private Panel panel6;
        private Label lbDashboard;
        private Label label9;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox txtPhone;
        private TextBox txtUsername;
        private Panel panel2;
        private Panel panel5;
        private Panel panel1;
        private TextBox txtAddress;
        private DataGridView dataGridView1;
        private Label label8;
        private PictureBox pictureBox1;
    }
}