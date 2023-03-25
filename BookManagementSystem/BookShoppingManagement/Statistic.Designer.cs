namespace BookShoppingManagement
{
    partial class Statistic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Statistic));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            panel6 = new Panel();
            lbLogout = new Label();
            panel5 = new Panel();
            SearchBtn = new Button();
            txtNumBooks = new TextBox();
            label8 = new Label();
            txtTotalBills = new TextBox();
            txtBookSold = new TextBox();
            txtTotalAmounts = new TextBox();
            panel1 = new Panel();
            label6 = new Label();
            btnReset = new Button();
            txtSearch = new TextBox();
            label1 = new Label();
            txtTotalUsers = new TextBox();
            btnDelete = new Button();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label7 = new Label();
            dgv = new DataGridView();
            panel2 = new Panel();
            panel4 = new Panel();
            lbUsers = new Label();
            panel3 = new Panel();
            lbBooks = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.LightSteelBlue;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(77, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 98);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.AppWorkspace;
            label4.Location = new Point(5, -3);
            label4.Name = "label4";
            label4.Size = new Size(136, 46);
            label4.TabIndex = 1;
            label4.Text = "Statistic";
            // 
            // panel6
            // 
            panel6.BackColor = Color.Green;
            panel6.Controls.Add(label4);
            panel6.Location = new Point(3, 237);
            panel6.Name = "panel6";
            panel6.Size = new Size(245, 49);
            panel6.TabIndex = 3;
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
            // panel5
            // 
            panel5.BackColor = SystemColors.ActiveCaptionText;
            panel5.Controls.Add(lbLogout);
            panel5.Location = new Point(3, 292);
            panel5.Name = "panel5";
            panel5.Size = new Size(245, 49);
            panel5.TabIndex = 3;
            // 
            // SearchBtn
            // 
            SearchBtn.BackColor = Color.PaleGreen;
            SearchBtn.ForeColor = Color.Black;
            SearchBtn.Location = new Point(771, 229);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(94, 29);
            SearchBtn.TabIndex = 15;
            SearchBtn.Text = "Search";
            SearchBtn.UseVisualStyleBackColor = false;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // txtNumBooks
            // 
            txtNumBooks.Location = new Point(1030, 20);
            txtNumBooks.Name = "txtNumBooks";
            txtNumBooks.Size = new Size(117, 34);
            txtNumBooks.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(64, 0, 0);
            label8.Location = new Point(877, 23);
            label8.Name = "label8";
            label8.Size = new Size(0, 26);
            label8.TabIndex = 8;
            // 
            // txtTotalBills
            // 
            txtTotalBills.Location = new Point(575, 76);
            txtTotalBills.Name = "txtTotalBills";
            txtTotalBills.Size = new Size(132, 34);
            txtTotalBills.TabIndex = 4;
            // 
            // txtBookSold
            // 
            txtBookSold.Location = new Point(575, 25);
            txtBookSold.Name = "txtBookSold";
            txtBookSold.Size = new Size(132, 34);
            txtBookSold.TabIndex = 3;
            // 
            // txtTotalAmounts
            // 
            txtTotalAmounts.Location = new Point(575, 130);
            txtTotalAmounts.Name = "txtTotalAmounts";
            txtTotalAmounts.Size = new Size(132, 34);
            txtTotalAmounts.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Thistle;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(btnReset);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtTotalUsers);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(dgv);
            panel1.Controls.Add(SearchBtn);
            panel1.Controls.Add(txtNumBooks);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtTotalBills);
            panel1.Controls.Add(txtBookSold);
            panel1.Controls.Add(txtTotalAmounts);
            panel1.Controls.Add(panel2);
            panel1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.ForeColor = Color.IndianRed;
            panel1.Location = new Point(-12, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1155, 563);
            panel1.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Yellow;
            label6.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(64, 0, 0);
            label6.Location = new Point(274, 230);
            label6.Name = "label6";
            label6.Size = new Size(263, 26);
            label6.TabIndex = 27;
            label6.Text = "Search Bill by Client Name";
            label6.Click += label6_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.PaleGreen;
            btnReset.ForeColor = Color.Black;
            btnReset.Location = new Point(888, 229);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 29);
            btnReset.TabIndex = 26;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(543, 227);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(208, 34);
            txtSearch.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(64, 0, 0);
            label1.Location = new Point(898, 79);
            label1.Name = "label1";
            label1.Size = new Size(112, 26);
            label1.TabIndex = 24;
            label1.Text = "Total users";
            // 
            // txtTotalUsers
            // 
            txtTotalUsers.Location = new Point(1030, 76);
            txtTotalUsers.Name = "txtTotalUsers";
            txtTotalUsers.Size = new Size(117, 34);
            txtTotalUsers.TabIndex = 23;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.PaleGreen;
            btnDelete.ForeColor = Color.Black;
            btnDelete.Location = new Point(1015, 229);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 22;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 13.8F, FontStyle.Underline, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(64, 0, 0);
            label5.Location = new Point(464, 79);
            label5.Name = "label5";
            label5.Size = new Size(105, 26);
            label5.TabIndex = 21;
            label5.Text = "Total Bills";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Underline, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(64, 0, 0);
            label3.Location = new Point(347, 28);
            label3.Name = "label3";
            label3.Size = new Size(222, 26);
            label3.TabIndex = 20;
            label3.Text = "Number of books sold";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Underline, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(64, 0, 0);
            label2.Location = new Point(745, 28);
            label2.Name = "label2";
            label2.Size = new Size(265, 26);
            label2.TabIndex = 19;
            label2.Text = "Number of books available";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 13.8F, FontStyle.Underline, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(64, 0, 0);
            label7.Location = new Point(421, 133);
            label7.Name = "label7";
            label7.Size = new Size(148, 26);
            label7.TabIndex = 17;
            label7.Text = "Total Amounts";
            // 
            // dgv
            // 
            dgv.BackgroundColor = SystemColors.ActiveCaption;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Info;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.Yellow;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgv.DefaultCellStyle = dataGridViewCellStyle1;
            dgv.Location = new Point(272, 274);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dgv.RowTemplate.Height = 29;
            dgv.Size = new Size(875, 276);
            dgv.TabIndex = 16;
            dgv.CellContentClick += dgv_CellContentClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MediumPurple;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(0, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 557);
            panel2.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaptionText;
            panel4.Controls.Add(lbUsers);
            panel4.Location = new Point(3, 182);
            panel4.Name = "panel4";
            panel4.Size = new Size(245, 49);
            panel4.TabIndex = 2;
            // 
            // lbUsers
            // 
            lbUsers.AutoSize = true;
            lbUsers.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            lbUsers.ForeColor = SystemColors.AppWorkspace;
            lbUsers.Location = new Point(5, -3);
            lbUsers.Name = "lbUsers";
            lbUsers.Size = new Size(101, 46);
            lbUsers.TabIndex = 1;
            lbUsers.Text = "Users";
            lbUsers.Click += lbUsers_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaptionText;
            panel3.Controls.Add(lbBooks);
            panel3.Location = new Point(5, 127);
            panel3.Name = "panel3";
            panel3.Size = new Size(245, 49);
            panel3.TabIndex = 1;
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
            // Statistic
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1147, 561);
            Controls.Add(panel1);
            Name = "Statistic";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Statistic";
            Load += Statistic_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private Label label4;
        private Panel panel6;
        private Label lbLogout;
        private Panel panel5;
        private ComboBox comboBox1;
        private Button SearchBtn;
        private TextBox txtNumBooks;
        private Label label8;
        private TextBox txtTotalBills;
        private TextBox txtBookSold;
        private TextBox txtTotalAmounts;
        private Panel panel1;
        private Panel panel2;
        private Panel panel4;
        private Label lbUsers;
        private Panel panel3;
        private Label lbBooks;
        private DataGridView dgv;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label7;
        private Label label1;
        private TextBox txtTotalUsers;
        private Button btnDelete;
        private Label label6;
        private Button btnReset;
        private TextBox txtSearch;
    }
}