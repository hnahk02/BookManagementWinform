namespace BookShoppingManagement
{
    partial class frmBooksManagement
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBooksManagement));
            panel1 = new Panel();
            label10 = new Label();
            btnSearch = new Button();
            txtSearch = new TextBox();
            groupBox1 = new GroupBox();
            cbFilterByCategory = new ComboBox();
            dataGridView1 = new DataGridView();
            cbCategories = new ComboBox();
            btnRefresh = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnSave = new Button();
            txtPrice = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            txtAuthor = new TextBox();
            txtQuantities = new TextBox();
            txtTitle = new TextBox();
            panel2 = new Panel();
            label11 = new Label();
            panel5 = new Panel();
            lbLogout = new Label();
            pictureBox1 = new PictureBox();
            panel6 = new Panel();
            lbDashboard = new Label();
            panel4 = new Panel();
            lbUsers = new Label();
            panel3 = new Panel();
            lbBooks = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Thistle;
            panel1.Controls.Add(label10);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(cbCategories);
            panel1.Controls.Add(btnRefresh);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(txtPrice);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtAuthor);
            panel1.Controls.Add(txtQuantities);
            panel1.Controls.Add(txtTitle);
            panel1.Controls.Add(panel2);
            panel1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.ForeColor = Color.IndianRed;
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1155, 563);
            panel1.TabIndex = 0;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.FromArgb(64, 0, 0);
            label10.Location = new Point(816, 202);
            label10.Name = "label10";
            label10.Size = new Size(151, 26);
            label10.TabIndex = 22;
            label10.Text = "Search by Title";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.PaleGreen;
            btnSearch.ForeColor = Color.Black;
            btnSearch.Location = new Point(1001, 237);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 21;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(782, 237);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(213, 34);
            txtSearch.TabIndex = 20;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbFilterByCategory);
            groupBox1.ForeColor = Color.FromArgb(64, 0, 0);
            groupBox1.Location = new Point(303, 198);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(179, 78);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filter";
            // 
            // cbFilterByCategory
            // 
            cbFilterByCategory.Font = new Font("Times New Roman", 7.8F, FontStyle.Italic, GraphicsUnit.Point);
            cbFilterByCategory.Items.AddRange(new object[] { "Fiction", "Non-fiction", "Mystery", "Thriller", "Romance", "Science fiction", "Fantasy", "Historical ", "Biography", "Self-help", "Business", "Finance", "Travel", "Religion", "Children's books", "Young adult", "Comics", "Graphic novels", "Art", "Photography", "Cookbooks", "History", "Politics", "Social sciences", "Science", "Sports", "Horror" });
            cbFilterByCategory.Location = new Point(19, 34);
            cbFilterByCategory.Name = "cbFilterByCategory";
            cbFilterByCategory.Size = new Size(151, 23);
            cbFilterByCategory.TabIndex = 0;
            cbFilterByCategory.Text = "Filter by Category";
            cbFilterByCategory.SelectionChangeCommitted += cbFilter;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = Color.Yellow;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Location = new Point(303, 282);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(804, 278);
            dataGridView1.TabIndex = 18;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // cbCategories
            // 
            cbCategories.Font = new Font("Times New Roman", 10.8F, FontStyle.Italic, GraphicsUnit.Point);
            cbCategories.FormattingEnabled = true;
            cbCategories.Items.AddRange(new object[] { "Fiction", "Non-fiction", "Mystery", "Thriller", "Romance", "Science fiction", "Fantasy", "Historical ", "Biography", "Self-help", "Business", "Finance", "Travel", "Religion", "Children's books", "Young adult", "Comics", "Graphic novels", "Art", "Photography", "Cookbooks", "History", "Politics", "Social sciences", "Science", "Sports", "Horror" });
            cbCategories.Location = new Point(722, 66);
            cbCategories.Name = "cbCategories";
            cbCategories.Size = new Size(151, 28);
            cbCategories.TabIndex = 17;
            cbCategories.Text = "Select category";
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.PaleGreen;
            btnRefresh.ForeColor = Color.Black;
            btnRefresh.Location = new Point(503, 232);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 15;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.PaleGreen;
            btnDelete.ForeColor = Color.Black;
            btnDelete.Location = new Point(737, 150);
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
            // txtPrice
            // 
            txtPrice.Location = new Point(1001, 60);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(151, 34);
            txtPrice.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(64, 0, 0);
            label9.Location = new Point(1001, 23);
            label9.Name = "label9";
            label9.Size = new Size(59, 26);
            label9.TabIndex = 9;
            label9.Text = "Price";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(64, 0, 0);
            label8.Location = new Point(877, 23);
            label8.Name = "label8";
            label8.Size = new Size(106, 26);
            label8.TabIndex = 8;
            label8.Text = "Quantities";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(64, 0, 0);
            label7.Location = new Point(528, 23);
            label7.Name = "label7";
            label7.Size = new Size(78, 26);
            label7.TabIndex = 7;
            label7.Text = "Author";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(64, 0, 0);
            label6.Location = new Point(722, 23);
            label6.Name = "label6";
            label6.Size = new Size(109, 26);
            label6.TabIndex = 6;
            label6.Text = "Categories";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(64, 0, 0);
            label5.Location = new Point(256, 23);
            label5.Name = "label5";
            label5.Size = new Size(53, 26);
            label5.TabIndex = 5;
            label5.Text = "Title";
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(528, 60);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(188, 34);
            txtAuthor.TabIndex = 4;
            // 
            // txtQuantities
            // 
            txtQuantities.Location = new Point(879, 60);
            txtQuantities.Name = "txtQuantities";
            txtQuantities.Size = new Size(116, 34);
            txtQuantities.TabIndex = 3;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(256, 60);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(252, 34);
            txtTitle.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MediumPurple;
            panel2.Controls.Add(label11);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(0, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 557);
            panel2.TabIndex = 0;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.BurlyWood;
            label11.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.FromArgb(64, 0, 0);
            label11.Location = new Point(26, 120);
            label11.Name = "label11";
            label11.Size = new Size(209, 34);
            label11.TabIndex = 40;
            label11.Text = "BOOK'S SHOP";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ActiveCaptionText;
            panel5.Controls.Add(lbLogout);
            panel5.Location = new Point(0, 350);
            panel5.Name = "panel5";
            panel5.Size = new Size(245, 49);
            panel5.TabIndex = 3;
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
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.LightSteelBlue;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(76, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 98);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 39;
            pictureBox1.TabStop = false;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ActiveCaptionText;
            panel6.Controls.Add(lbDashboard);
            panel6.Location = new Point(0, 295);
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
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaptionText;
            panel4.Controls.Add(lbUsers);
            panel4.Location = new Point(0, 240);
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
            panel3.BackColor = Color.Green;
            panel3.Controls.Add(lbBooks);
            panel3.Location = new Point(2, 185);
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
            // 
            // frmBooksManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(1179, 587);
            Controls.Add(panel1);
            Name = "frmBooksManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmBooksManagement";
            Load += frmBooksManagement_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnRefresh;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnSave;
        private TextBox txtPrice;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label5;
        private TextBox txtAuthor;
        private TextBox txtQuantities;
        private TextBox txtTitle;
        private Panel panel2;
        private Panel panel5;
        private Label lbLogout;
        private Panel panel6;
        private Label lbDashboard;
        private Panel panel4;
        private Label lbUsers;
        private Panel panel3;
        private Label lbBooks;
        private ComboBox cbCategories;
        private ComboBox cbFilterByCategory;
        private Label label6;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Button btnSearch;
        private TextBox txtSearch;
        private Label label10;
        private Label label11;
        private PictureBox pictureBox1;
    }
}