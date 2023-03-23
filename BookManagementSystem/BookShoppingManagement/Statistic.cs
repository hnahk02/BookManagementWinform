using BookShoppingManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShoppingManagement
{
    public partial class Statistic : Form
    {
        private readonly BookShoppingManagementContext _context = new();
        public Statistic()
        {
            InitializeComponent();
        }

        private void Statistic_Load(object sender, EventArgs e)
        {
            txtBookSold.Enabled = false;
            txtNumBooks.Enabled = false;
            txtTotalAmounts.Enabled = false;
            txtTotalBills.Enabled = false;
            txtTotalUsers.Enabled = false;

            txtBookSold.Text = frmBill.number_of_books_sold.ToString();

            var numBooks = _context.Books.Sum(b => b.Quantity);
            txtNumBooks.Text = numBooks.ToString();

            var totalAmounts = _context.Bills.Sum(x => x.Amount);
            txtTotalAmounts.Text = totalAmounts.ToString();

            var totalBills = _context.Bills.Count();
            txtTotalBills.Text = totalBills.ToString();

            var totalUsers = _context.Users.Count();
            txtTotalUsers.Text = totalUsers.ToString();

            LoadDataGridView();
        }

        private void lbBooks_Click(object sender, EventArgs e)
        {
            frmBooksManagement frmBooksManagement = new frmBooksManagement();
            frmBooksManagement.Show();
            this.Hide();
        }

        private void lbUsers_Click(object sender, EventArgs e)
        {
            frmUsersManagement frmUsersManagement = new frmUsersManagement();
            frmUsersManagement.Show();
            this.Hide();
        }

        private void lbLogout_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Hide();
        }

        private void getTotalBookShow()
        {

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadDataGridView()
        {
            var billList = new List<Bill>();
            billList = _context.Bills.ToList();
            dgv.DataSource = billList;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            List<Bill> searchBillList = new List<Bill>();
            searchBillList = (_context.Bills.ToList()).Where(b => b.ClientName.ToLower().Contains(txtSearch.Text.ToLower())).ToList();
            dgv.DataSource = searchBillList;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSearch.Text = String.Empty;
            LoadDataGridView();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 1)
            {
                int id = (int)dgv.SelectedRows[0].Cells[0].Value;
                var b = _context.Bills.SingleOrDefault(b => b.BillId == id);

                if (b != null)
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this bill?", "Confirmation", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        _context.Bills.Remove(b);
                        _context.SaveChanges();
                        MessageBox.Show("Delete bill successfully");
                        LoadDataGridView();
                        txtBookSold.Text = frmBill.number_of_books_sold.ToString();

                        var numBooks = _context.Books.Sum(b => b.Quantity);
                        txtNumBooks.Text = numBooks.ToString();

                        var totalAmounts = _context.Bills.Sum(x => x.Amount);
                        txtTotalAmounts.Text = totalAmounts.ToString();

                        var totalBills = _context.Bills.Count();
                        txtTotalBills.Text = totalBills.ToString();

                        var totalUsers = _context.Users.Count();
                        txtTotalUsers.Text = totalUsers.ToString();
                    }
                    else
                    {
                        LoadDataGridView();
                    }
                }
            }
        }


    }
}
