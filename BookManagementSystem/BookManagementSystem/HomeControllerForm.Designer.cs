namespace BookManagementSystem
{
    partial class HomeControllerForm
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.discount_btn = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.pay_btn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.book_quantity = new System.Windows.Forms.NumericUpDown();
            this.add_btn = new System.Windows.Forms.Button();
            this.Book = new System.Windows.Forms.ComboBox();
            this.Category = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.book_quantity)).BeginInit();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(891, 611);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.discount_btn);
            this.panel4.Controls.Add(this.numericUpDown1);
            this.panel4.Controls.Add(this.pay_btn);
            this.panel4.Location = new System.Drawing.Point(287, 238);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(519, 170);
            this.panel4.TabIndex = 3;
            // 
            // discount_btn
            // 
            this.discount_btn.Location = new System.Drawing.Point(175, 41);
            this.discount_btn.Name = "discount_btn";
            this.discount_btn.Size = new System.Drawing.Size(121, 44);
            this.discount_btn.TabIndex = 6;
            this.discount_btn.Text = "Discount";
            this.discount_btn.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(166, 107);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(150, 27);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // pay_btn
            // 
            this.pay_btn.Location = new System.Drawing.Point(334, 74);
            this.pay_btn.Name = "pay_btn";
            this.pay_btn.Size = new System.Drawing.Size(169, 60);
            this.pay_btn.TabIndex = 0;
            this.pay_btn.Text = "Pay";
            this.pay_btn.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.book_quantity);
            this.panel3.Controls.Add(this.add_btn);
            this.panel3.Controls.Add(this.Book);
            this.panel3.Controls.Add(this.Category);
            this.panel3.Location = new System.Drawing.Point(287, 46);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(519, 166);
            this.panel3.TabIndex = 2;
            // 
            // book_quantity
            // 
            this.book_quantity.Location = new System.Drawing.Point(313, 77);
            this.book_quantity.Name = "book_quantity";
            this.book_quantity.Size = new System.Drawing.Size(150, 27);
            this.book_quantity.TabIndex = 4;
            this.book_quantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(345, 121);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(94, 29);
            this.add_btn.TabIndex = 3;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            // 
            // Book
            // 
            this.Book.FormattingEnabled = true;
            this.Book.Location = new System.Drawing.Point(312, 32);
            this.Book.Name = "Book";
            this.Book.Size = new System.Drawing.Size(151, 28);
            this.Book.TabIndex = 2;
            // 
            // Category
            // 
            this.Category.FormattingEnabled = true;
            this.Category.Location = new System.Drawing.Point(103, 32);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(151, 28);
            this.Category.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listView1);
            this.panel2.Location = new System.Drawing.Point(22, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(242, 362);
            this.panel2.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(20, 19);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(209, 331);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.accountInformationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(891, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // accountInformationToolStripMenuItem
            // 
            this.accountInformationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personalInformationToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.accountInformationToolStripMenuItem.Name = "accountInformationToolStripMenuItem";
            this.accountInformationToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.accountInformationToolStripMenuItem.Text = "Account Information";
            // 
            // personalInformationToolStripMenuItem
            // 
            this.personalInformationToolStripMenuItem.Name = "personalInformationToolStripMenuItem";
            this.personalInformationToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.personalInformationToolStripMenuItem.Text = "Personal Information";
            this.personalInformationToolStripMenuItem.Click += new System.EventHandler(this.personalInformationToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // HomeControllerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 611);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HomeControllerForm";
            this.Text = "HomeControllerForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.book_quantity)).EndInit();
            this.panel2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel4;
        private Panel panel3;
        private NumericUpDown book_quantity;
        private Button add_btn;
        private ComboBox Book;
        private ComboBox Category;
        private Panel panel2;
        private ListView listView1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem adminToolStripMenuItem;
        private ToolStripMenuItem accountInformationToolStripMenuItem;
        private ToolStripMenuItem personalInformationToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private Button discount_btn;
        private NumericUpDown numericUpDown1;
        private Button pay_btn;
    }
}