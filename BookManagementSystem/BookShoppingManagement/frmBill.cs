using BookShoppingManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShoppingManagement
{
    public partial class frmBill : Form
    {


        private readonly BookShoppingManagementContext _context = new();
        public frmBill()
        {
            InitializeComponent();
        }

        private void LoadDgvListOfBooks()
        {
            dgvListOfBooks.DataSource = _context.Books.ToList();
        }


        private void frmBill_Load(object sender, EventArgs e)
        {
            lbUserName.Text = frmLogin.username_text;
            lbID.Text = frmLogin.user_id;
            txtBookName.Enabled = false;
            txtPrice.Enabled = false;
            LoadDgvListOfBooks();
        }

        int key = 0;
        int stock = 0;

        private void dgvListOfBooks_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvListOfBooks.SelectedRows.Count == 1)
            {
                int id = (int)dgvListOfBooks.SelectedRows[0].Cells[0].Value;
                var book = _context.Books.Find(id);
                if (book != null)
                {
                    txtBookName.Text = book.Title;
                    txtPrice.Text = book.Price.ToString();


                    key = book.BookId;
                    stock = Convert.ToInt32(book.Quantity);
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void UpdateBookQuantity()
        {
            int new_quantiy = stock - Convert.ToInt32(txtQuantity.Text);
            var book = _context.Books.Find(key);
            if (book != null)
            {
                book.Quantity = new_quantiy;
                _context.SaveChanges();
            }

        }


        int n = 0; // id
        int grand_total = 0;
        public static int number_of_books_sold = 0;
        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (txtQuantity.Text == "" || Convert.ToInt32(txtQuantity.Text) > stock)
            {
                MessageBox.Show("Not enough products");
                Clear();
            }
            else
            {
                int total = Convert.ToInt32(txtQuantity.Text) * Convert.ToInt32(txtPrice.Text);
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dgvBill);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = txtBookName.Text;
                newRow.Cells[2].Value = txtQuantity.Text;
                newRow.Cells[3].Value = txtPrice.Text;
                newRow.Cells[4].Value = total;

                number_of_books_sold += Convert.ToInt32(txtQuantity.Text);
                n++;

                UpdateBookQuantity();
                grand_total = grand_total + total;
                lbTotal.Text = "Total: " + grand_total.ToString() + "$";
                dgvBill.Rows.Add(newRow);
                LoadDgvListOfBooks();
                Clear();
            }

        }

        private void Clear()
        {
            txtBookName.Text = string.Empty;
            txtClient.Text = string.Empty;
            txtQuantity.Text = string.Empty;
            txtPrice.Text = string.Empty;
        }

        private void dgvBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int startX = 10;
            int startY = 10;
            int rowHeight = dgvBill.RowTemplate.Height;
            int offset = 40;
            int headerHeight = 50;

            // Set the font and color for the header and details
            Font headerFont = new Font("Arial", 16, FontStyle.Bold);
            Font detailFont = new Font("Arial", 12);
            SolidBrush brush = new SolidBrush(Color.Black);

            // Create the header text
            string headerText = "BILLING RECEIPT";
            SizeF headerSize = e.Graphics.MeasureString(headerText, headerFont);
            e.Graphics.DrawString(headerText, headerFont, brush, startX + (300 - headerSize.Width) / 2, startY);

            // Add spacing for the header
            startY += headerHeight;

            // Create a rectangle that will contain the details
            RectangleF detailsRect = new RectangleF(startX, startY, e.PageSettings.PrintableArea.Width - 20, e.PageSettings.PrintableArea.Height - offset);

            // Create the details text
            string detailsText = $"Client: {txtClient.Text}\n\n";
            detailsText += "No.\tBook Name\tQuantity\tPrice\tTotal\n\n";

            // Add the footer text
            string footerText = $"\nTotal: {grand_total}$\n\nThank you for shopping with us!";
            e.Graphics.DrawString(footerText, headerFont, brush, startX + (300 - headerSize.Width) / 2, startY);

        }





        private void btnPrint_Click(object sender, EventArgs e)
        {
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 600);
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }

            if (txtClient.Text == "")
            {
                MessageBox.Show("Client Name should not be empty!!");
            }
            else
            {
                var bill = new Bill()
                {
                    UserId = Convert.ToInt32(lbID.Text),
                    Username = lbUserName.Text,
                    ClientName = txtClient.Text,
                    Amount = Convert.ToInt32(grand_total)
                };
                _context.Bills.Add(bill);
                _context.SaveChanges();
                lbTotal.Text = "";
                dgvBill.Rows.Clear();
                grand_total = 0;
                Clear();



            }
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void lbUserName_Click(object sender, EventArgs e)
        {

        }

        private void lbLogout_Click(object sender, EventArgs e)
        {
            frmLogin form = new frmLogin();
            form.Show();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            List<Book> searchBookList = new List<Book>();
            searchBookList = (_context.Books.ToList()).Where(b => b.Title.ToLower().Contains(txtSearch.Text.ToLower())).ToList();
            dgvListOfBooks.DataSource = searchBookList;

        }
    }
}
