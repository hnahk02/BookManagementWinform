namespace BookShoppingManagement
{
    partial class frmBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBill));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pictureBox1 = new PictureBox();
            lbLogout = new Label();
            panel5 = new Panel();
            label7 = new Label();
            label5 = new Label();
            txtClient = new TextBox();
            txtBookName = new TextBox();
            panel2 = new Panel();
            panel3 = new Panel();
            label9 = new Label();
            lbID = new Label();
            lbUserName = new Label();
            pictureBox2 = new PictureBox();
            label8 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            txtAvailable = new TextBox();
            btnSearch = new Button();
            txtSearch = new TextBox();
            btnPrint = new Button();
            lbTotal = new Label();
            btnAdd = new Button();
            btnReset = new Button();
            dgvBill = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            dgvListOfBooks = new DataGridView();
            label6 = new Label();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            txtPrice = new TextBox();
            txtQuantity = new TextBox();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBill).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvListOfBooks).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.LightSteelBlue;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(71, 115);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 98);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
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
            panel5.Location = new Point(2, 629);
            panel5.Name = "panel5";
            panel5.Size = new Size(245, 49);
            panel5.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(64, 0, 0);
            label7.Location = new Point(1044, 364);
            label7.Name = "label7";
            label7.Size = new Size(194, 26);
            label7.TabIndex = 7;
            label7.Text = "Enter Client Name :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(64, 0, 0);
            label5.Location = new Point(256, 23);
            label5.Name = "label5";
            label5.Size = new Size(122, 26);
            label5.TabIndex = 5;
            label5.Text = "Book Name";
            // 
            // txtClient
            // 
            txtClient.Location = new Point(1287, 356);
            txtClient.Name = "txtClient";
            txtClient.Size = new Size(182, 34);
            txtClient.TabIndex = 4;
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(256, 60);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(182, 34);
            txtBookName.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MediumPurple;
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(panel5);
            panel2.Location = new Point(0, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 683);
            panel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LavenderBlush;
            panel3.Controls.Add(label9);
            panel3.Controls.Add(lbID);
            panel3.Controls.Add(lbUserName);
            panel3.Controls.Add(pictureBox2);
            panel3.Location = new Point(2, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 90);
            panel3.TabIndex = 36;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.BurlyWood;
            label9.ForeColor = Color.Black;
            label9.Location = new Point(106, 61);
            label9.Name = "label9";
            label9.Size = new Size(42, 26);
            label9.TabIndex = 38;
            label9.Text = "ID:";
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.BackColor = SystemColors.ButtonFace;
            lbID.ForeColor = Color.Red;
            lbID.Location = new Point(146, 61);
            lbID.Name = "lbID";
            lbID.Size = new Size(42, 26);
            lbID.TabIndex = 37;
            lbID.Text = "ID:";
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.BackColor = Color.BurlyWood;
            lbUserName.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lbUserName.ForeColor = Color.FromArgb(64, 0, 0);
            lbUserName.Location = new Point(106, 9);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(135, 34);
            lbUserName.TabIndex = 34;
            lbUserName.Text = "Username";
            lbUserName.Click += lbUserName_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.LightSteelBlue;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-6, -8);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 98);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 35;
            pictureBox2.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.BurlyWood;
            label8.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(64, 0, 0);
            label8.Location = new Point(21, 232);
            label8.Name = "label8";
            label8.Size = new Size(209, 34);
            label8.TabIndex = 36;
            label8.Text = "BOOK'S SHOP";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Thistle;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtAvailable);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(btnPrint);
            panel1.Controls.Add(lbTotal);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(btnReset);
            panel1.Controls.Add(dgvBill);
            panel1.Controls.Add(dgvListOfBooks);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtPrice);
            panel1.Controls.Add(txtQuantity);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtClient);
            panel1.Controls.Add(txtBookName);
            panel1.Controls.Add(panel2);
            panel1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.ForeColor = Color.IndianRed;
            panel1.Location = new Point(4, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1516, 689);
            panel1.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(64, 0, 0);
            label3.Location = new Point(294, 127);
            label3.Name = "label3";
            label3.Size = new Size(98, 26);
            label3.TabIndex = 37;
            label3.Text = "Available";
            // 
            // txtAvailable
            // 
            txtAvailable.Location = new Point(281, 165);
            txtAvailable.Name = "txtAvailable";
            txtAvailable.Size = new Size(125, 34);
            txtAvailable.TabIndex = 36;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.PaleGreen;
            btnSearch.ForeColor = Color.Black;
            btnSearch.Location = new Point(1235, 10);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 35;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(1005, 8);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(213, 34);
            txtSearch.TabIndex = 34;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.PaleGreen;
            btnPrint.ForeColor = Color.Black;
            btnPrint.Location = new Point(1221, 617);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(94, 29);
            btnPrint.TabIndex = 33;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // lbTotal
            // 
            lbTotal.AutoSize = true;
            lbTotal.BackColor = Color.GhostWhite;
            lbTotal.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            lbTotal.ForeColor = Color.Green;
            lbTotal.Location = new Point(1229, 522);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(86, 39);
            lbTotal.TabIndex = 32;
            lbTotal.Text = "Total";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.PaleGreen;
            btnAdd.ForeColor = Color.Black;
            btnAdd.Location = new Point(456, 219);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(133, 29);
            btnAdd.TabIndex = 31;
            btnAdd.Text = "Add to bill";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.PaleGreen;
            btnReset.ForeColor = Color.Black;
            btnReset.Location = new Point(312, 219);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 29);
            btnReset.TabIndex = 30;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // dgvBill
            // 
            dgvBill.BackgroundColor = SystemColors.GradientActiveCaption;
            dgvBill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBill.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Info;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.IndianRed;
            dataGridViewCellStyle1.SelectionBackColor = Color.PaleGreen;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvBill.DefaultCellStyle = dataGridViewCellStyle1;
            dgvBill.Location = new Point(256, 323);
            dgvBill.Name = "dgvBill";
            dgvBill.RowHeadersWidth = 51;
            dgvBill.RowTemplate.Height = 29;
            dgvBill.Size = new Size(771, 358);
            dgvBill.TabIndex = 29;
            dgvBill.CellContentClick += dgvBill_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Books";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Price";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Quantity";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Total";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // dgvListOfBooks
            // 
            dgvListOfBooks.BackgroundColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvListOfBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvListOfBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Info;
            dataGridViewCellStyle3.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.IndianRed;
            dataGridViewCellStyle3.SelectionBackColor = Color.Turquoise;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvListOfBooks.DefaultCellStyle = dataGridViewCellStyle3;
            dgvListOfBooks.Location = new Point(617, 46);
            dgvListOfBooks.Name = "dgvListOfBooks";
            dgvListOfBooks.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvListOfBooks.RowTemplate.Height = 29;
            dgvListOfBooks.Size = new Size(873, 271);
            dgvListOfBooks.TabIndex = 28;
            dgvListOfBooks.SelectionChanged += dgvListOfBooks_SelectionChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.GhostWhite;
            label6.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Turquoise;
            label6.Location = new Point(697, 4);
            label6.Name = "label6";
            label6.Size = new Size(195, 39);
            label6.TabIndex = 27;
            label6.Text = "List of books";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.GhostWhite;
            label4.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.PaleGreen;
            label4.Location = new Point(312, 278);
            label4.Name = "label4";
            label4.Size = new Size(66, 39);
            label4.TabIndex = 26;
            label4.Text = "Bill";
            label4.Click += label4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(64, 0, 0);
            label1.Location = new Point(464, 23);
            label1.Name = "label1";
            label1.Size = new Size(59, 26);
            label1.TabIndex = 25;
            label1.Text = "Price";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(64, 0, 0);
            label2.Location = new Point(464, 127);
            label2.Name = "label2";
            label2.Size = new Size(92, 26);
            label2.TabIndex = 24;
            label2.Text = "Quantity";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(464, 62);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(125, 34);
            txtPrice.TabIndex = 23;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(464, 165);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(125, 34);
            txtQuantity.TabIndex = 22;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            printPreviewDialog1.Load += printPreviewDialog1_Load;
            // 
            // frmBill
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1524, 693);
            Controls.Add(panel1);
            Name = "frmBill";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmBill";
            Load += frmBill_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBill).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvListOfBooks).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lbLogout;
        private Panel panel5;
        private Label label7;
        private Label label5;
        private TextBox txtClient;
        private TextBox txtBookName;
        private Panel panel2;
        private Panel panel1;
        private Label label6;
        private Label label4;
        private Label label1;
        private Label label2;
        private TextBox txtPrice;
        private TextBox txtQuantity;
        private DataGridView dgvListOfBooks;
        private Button btnReset;
        private DataGridView dgvBill;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Button btnAdd;
        private Button btnPrint;
        private Label lbTotal;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private Label lbUserName;
        private Panel panel3;
        private PictureBox pictureBox2;
        private Label label8;
        private Label lbID;
        private Label label9;
        private Button btnSearch;
        private TextBox txtSearch;
        private Label label3;
        private TextBox txtAvailable;
    }
}