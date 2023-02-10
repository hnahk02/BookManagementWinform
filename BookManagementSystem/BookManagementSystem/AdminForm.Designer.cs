namespace BookManagementSystem
{
    partial class AdminForm
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
            this.bill_tabcontrol = new System.Windows.Forms.TabControl();
            this.revenue_page = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.view_btn = new System.Windows.Forms.Button();
            this.to_date_picker = new System.Windows.Forms.DateTimePicker();
            this.from_date_picker = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bill_data_grid_view = new System.Windows.Forms.DataGridView();
            this.book_page = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.search_btn = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.delete_book_btn = new System.Windows.Forms.Button();
            this.update_book_btn = new System.Windows.Forms.Button();
            this.add_book_btn = new System.Windows.Forms.Button();
            this.view_book_btn = new System.Windows.Forms.Button();
            this.category_page = new System.Windows.Forms.TabPage();
            this.account_page = new System.Windows.Forms.TabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.account_data_grid_view = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.bill_tabcontrol.SuspendLayout();
            this.revenue_page.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bill_data_grid_view)).BeginInit();
            this.book_page.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.account_page.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.account_data_grid_view)).BeginInit();
            this.SuspendLayout();
            // 
            // bill_tabcontrol
            // 
            this.bill_tabcontrol.Controls.Add(this.revenue_page);
            this.bill_tabcontrol.Controls.Add(this.book_page);
            this.bill_tabcontrol.Controls.Add(this.category_page);
            this.bill_tabcontrol.Controls.Add(this.account_page);
            this.bill_tabcontrol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bill_tabcontrol.Location = new System.Drawing.Point(0, 0);
            this.bill_tabcontrol.Name = "bill_tabcontrol";
            this.bill_tabcontrol.SelectedIndex = 0;
            this.bill_tabcontrol.Size = new System.Drawing.Size(845, 494);
            this.bill_tabcontrol.TabIndex = 0;
            // 
            // revenue_page
            // 
            this.revenue_page.Controls.Add(this.panel2);
            this.revenue_page.Controls.Add(this.panel1);
            this.revenue_page.Location = new System.Drawing.Point(4, 29);
            this.revenue_page.Name = "revenue_page";
            this.revenue_page.Padding = new System.Windows.Forms.Padding(3);
            this.revenue_page.Size = new System.Drawing.Size(837, 461);
            this.revenue_page.TabIndex = 0;
            this.revenue_page.Text = "Revenue";
            this.revenue_page.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.view_btn);
            this.panel2.Controls.Add(this.to_date_picker);
            this.panel2.Controls.Add(this.from_date_picker);
            this.panel2.Location = new System.Drawing.Point(8, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(777, 43);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "To";
            // 
            // view_btn
            // 
            this.view_btn.Location = new System.Drawing.Point(639, 6);
            this.view_btn.Name = "view_btn";
            this.view_btn.Size = new System.Drawing.Size(94, 29);
            this.view_btn.TabIndex = 2;
            this.view_btn.Text = "View";
            this.view_btn.UseVisualStyleBackColor = true;
            // 
            // to_date_picker
            // 
            this.to_date_picker.Location = new System.Drawing.Point(357, 6);
            this.to_date_picker.Name = "to_date_picker";
            this.to_date_picker.Size = new System.Drawing.Size(250, 27);
            this.to_date_picker.TabIndex = 1;
            // 
            // from_date_picker
            // 
            this.from_date_picker.Location = new System.Drawing.Point(29, 6);
            this.from_date_picker.Name = "from_date_picker";
            this.from_date_picker.Size = new System.Drawing.Size(250, 27);
            this.from_date_picker.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bill_data_grid_view);
            this.panel1.Location = new System.Drawing.Point(8, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 350);
            this.panel1.TabIndex = 0;
            // 
            // bill_data_grid_view
            // 
            this.bill_data_grid_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bill_data_grid_view.Location = new System.Drawing.Point(17, 14);
            this.bill_data_grid_view.Name = "bill_data_grid_view";
            this.bill_data_grid_view.RowHeadersWidth = 51;
            this.bill_data_grid_view.RowTemplate.Height = 29;
            this.bill_data_grid_view.Size = new System.Drawing.Size(747, 324);
            this.bill_data_grid_view.TabIndex = 0;
            // 
            // book_page
            // 
            this.book_page.Controls.Add(this.panel5);
            this.book_page.Controls.Add(this.panel4);
            this.book_page.Controls.Add(this.panel3);
            this.book_page.Location = new System.Drawing.Point(4, 29);
            this.book_page.Name = "book_page";
            this.book_page.Padding = new System.Windows.Forms.Padding(3);
            this.book_page.Size = new System.Drawing.Size(837, 461);
            this.book_page.TabIndex = 1;
            this.book_page.Text = "Book";
            this.book_page.UseVisualStyleBackColor = true;
            this.book_page.Click += new System.EventHandler(this.book_page_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.textBox5);
            this.panel5.Controls.Add(this.search_btn);
            this.panel5.Controls.Add(this.textBox4);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.textBox3);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.textBox2);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.textBox1);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(8, 245);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(804, 180);
            this.panel5.TabIndex = 2;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(33, 65);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(279, 27);
            this.textBox5.TabIndex = 8;
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(133, 98);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(72, 32);
            this.search_btn.TabIndex = 4;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(499, 125);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(279, 27);
            this.textBox4.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(427, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Price";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(499, 83);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(279, 27);
            this.textBox3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(410, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Category";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(499, 50);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(279, 27);
            this.textBox2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(427, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Title";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(499, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(279, 27);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(427, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Location = new System.Drawing.Point(8, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(671, 220);
            this.panel4.TabIndex = 1;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(643, 192);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.delete_book_btn);
            this.panel3.Controls.Add(this.update_book_btn);
            this.panel3.Controls.Add(this.add_book_btn);
            this.panel3.Controls.Add(this.view_book_btn);
            this.panel3.Location = new System.Drawing.Point(713, 21);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(99, 204);
            this.panel3.TabIndex = 0;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // delete_book_btn
            // 
            this.delete_book_btn.Location = new System.Drawing.Point(15, 132);
            this.delete_book_btn.Name = "delete_book_btn";
            this.delete_book_btn.Size = new System.Drawing.Size(72, 32);
            this.delete_book_btn.TabIndex = 3;
            this.delete_book_btn.Text = "Delete";
            this.delete_book_btn.UseVisualStyleBackColor = true;
            // 
            // update_book_btn
            // 
            this.update_book_btn.Location = new System.Drawing.Point(15, 84);
            this.update_book_btn.Name = "update_book_btn";
            this.update_book_btn.Size = new System.Drawing.Size(72, 32);
            this.update_book_btn.TabIndex = 2;
            this.update_book_btn.Text = "Update";
            this.update_book_btn.UseVisualStyleBackColor = true;
            // 
            // add_book_btn
            // 
            this.add_book_btn.Location = new System.Drawing.Point(15, 44);
            this.add_book_btn.Name = "add_book_btn";
            this.add_book_btn.Size = new System.Drawing.Size(72, 34);
            this.add_book_btn.TabIndex = 1;
            this.add_book_btn.Text = "Add";
            this.add_book_btn.UseVisualStyleBackColor = true;
            // 
            // view_book_btn
            // 
            this.view_book_btn.Location = new System.Drawing.Point(15, 3);
            this.view_book_btn.Name = "view_book_btn";
            this.view_book_btn.Size = new System.Drawing.Size(72, 35);
            this.view_book_btn.TabIndex = 0;
            this.view_book_btn.Text = "View";
            this.view_book_btn.UseVisualStyleBackColor = true;
            // 
            // category_page
            // 
            this.category_page.Location = new System.Drawing.Point(4, 29);
            this.category_page.Name = "category_page";
            this.category_page.Padding = new System.Windows.Forms.Padding(3);
            this.category_page.Size = new System.Drawing.Size(837, 461);
            this.category_page.TabIndex = 2;
            this.category_page.Text = "Category";
            this.category_page.UseVisualStyleBackColor = true;
            // 
            // account_page
            // 
            this.account_page.Controls.Add(this.panel7);
            this.account_page.Controls.Add(this.panel6);
            this.account_page.Location = new System.Drawing.Point(4, 29);
            this.account_page.Name = "account_page";
            this.account_page.Padding = new System.Windows.Forms.Padding(3);
            this.account_page.Size = new System.Drawing.Size(837, 461);
            this.account_page.TabIndex = 3;
            this.account_page.Text = "Account";
            this.account_page.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.account_data_grid_view);
            this.panel7.Location = new System.Drawing.Point(8, 6);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(642, 449);
            this.panel7.TabIndex = 1;
            // 
            // account_data_grid_view
            // 
            this.account_data_grid_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.account_data_grid_view.Location = new System.Drawing.Point(18, 19);
            this.account_data_grid_view.Name = "account_data_grid_view";
            this.account_data_grid_view.RowHeadersWidth = 51;
            this.account_data_grid_view.RowTemplate.Height = 29;
            this.account_data_grid_view.Size = new System.Drawing.Size(593, 403);
            this.account_data_grid_view.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(665, 6);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(161, 447);
            this.panel6.TabIndex = 0;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 494);
            this.Controls.Add(this.bill_tabcontrol);
            this.Name = "AdminForm";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.bill_tabcontrol.ResumeLayout(false);
            this.revenue_page.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bill_data_grid_view)).EndInit();
            this.book_page.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.account_page.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.account_data_grid_view)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl bill_tabcontrol;
        private TabPage revenue_page;
        private Panel panel2;
        private Label label1;
        private Button view_btn;
        private DateTimePicker to_date_picker;
        private DateTimePicker from_date_picker;
        private Panel panel1;
        private DataGridView bill_data_grid_view;
        private TabPage book_page;
        private TabPage category_page;
        private TabPage account_page;
        private Panel panel5;
        private TextBox textBox5;
        private Button search_btn;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private Panel panel4;
        private DataGridView dataGridView1;
        private Panel panel3;
        private Button delete_book_btn;
        private Button update_book_btn;
        private Button add_book_btn;
        private Button view_book_btn;
        private Panel panel7;
        private DataGridView account_data_grid_view;
        private Panel panel6;
    }
}