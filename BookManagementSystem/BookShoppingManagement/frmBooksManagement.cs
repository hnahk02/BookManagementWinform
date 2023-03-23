using BookShoppingManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BookShoppingManagement
{
    public partial class frmBooksManagement : Form
    {
        private readonly BookShoppingManagementContext _context = new();
        public frmBooksManagement()
        {
            InitializeComponent();
        }



        private void frmBooksManagement_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text == "" || txtAuthor.Text == "" || txtQuantities.Text == "" ||
                txtPrice.Text == "" || cbCategories.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                var book = new Book()
                {
                    Title = txtTitle.Text,
                    Author = txtAuthor.Text,
                    Category = cbCategories.Text.ToString(),
                    Price = int.Parse(txtPrice.Text),
                    Quantity = int.Parse(txtQuantities.Text)
                };
                _context.Books.Add(book);
                _context.SaveChanges();
                LoadDataGridView();
                MessageBox.Show("Book saved successfully");
                Clear();
            }
        }

        private void LoadDataGridView()
        {
            dataGridView1.DataSource = _context.Books.ToList();
        }

        //selection change commit of cbFilterByCategory

        private void cbFilter(object sender, EventArgs e)
        {
            var books = new List<Book>();
            var filterBooksByCategory = _context.Books.Where(book => book.Category == cbFilterByCategory.SelectedItem.ToString()).ToList();
            dataGridView1.DataSource = filterBooksByCategory;
        }

        private void Clear()
        {
            txtTitle.Text = string.Empty;
            txtAuthor.Text = string.Empty;
            txtQuantities.Text = string.Empty;
            txtPrice.Text = string.Empty;
            cbCategories.SelectedIndex = -1;
            cbFilterByCategory.SelectedIndex = -1;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Clear();
            LoadDataGridView();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                var book = _context.Books.Find(id);
                if (book != null)
                {
                    txtTitle.Text = book.Title;
                    txtAuthor.Text = book.Author;
                    txtPrice.Text = book.Price.ToString();
                    txtQuantities.Text = book.Quantity.ToString();
                    cbCategories.Text = book.Category;
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count == 1)
            {
                int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                var book = _context.Books.Find(id);

                if (book != null)
                {
                    if (txtTitle.Text == "" || txtAuthor.Text == "" || txtQuantities.Text == "" ||
                    txtPrice.Text == "" || cbCategories.SelectedIndex == -1)
                    {
                        MessageBox.Show("Missing Information");
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Are you sure you want to update this book?", "Confirmation", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            book.Title = txtTitle.Text;
                            book.Author = txtAuthor.Text;
                            book.Price = int.Parse(txtPrice.Text);
                            book.Quantity = int.Parse(txtQuantities.Text);
                            book.Category = cbCategories.Text;
                            _context.SaveChanges();
                            LoadDataGridView();
                            MessageBox.Show("Book updated successfully");
                            Clear();
                        }
                        else
                        {
                            LoadDataGridView();
                            Clear();
                        }
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count == 1)
            {
                int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                var book = _context.Books.SingleOrDefault(b => b.BookId == id);

                if (book != null)
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this book?", "Confirmation", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        _context.Books.Remove(book);
                        _context.SaveChanges();
                        MessageBox.Show("Delete books successfully");
                        LoadDataGridView();
                        Clear();
                    }
                    else
                    {
                        LoadDataGridView();
                        Clear();
                    }
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<Book> searchBookList = new List<Book>();
            searchBookList = (_context.Books.ToList()).Where(b => b.Title.ToLower().Contains(txtSearch.Text.ToLower())).ToList();
            dataGridView1.DataSource = searchBookList;

        }


        private void lbUsers_Click(object sender, EventArgs e)
        {
            frmUsersManagement frmUsersManagement = new frmUsersManagement();
            frmUsersManagement.Show();
            this.Hide();
        }

        private void lbDashboard_Click(object sender, EventArgs e)
        {
            Statistic dashBoard = new Statistic();
            dashBoard.Show();
            this.Hide();
        }

        private void lbLogout_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Hide();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
