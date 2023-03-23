using BookShoppingManagement.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class frmUsersManagement : Form
    {
        private readonly BookShoppingManagementContext _context = new();
        public frmUsersManagement()
        {
            InitializeComponent();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtAddress.Text == "" || txtPhone.Text == "" ||
                txtPassword.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                var user = new Models.User()
                {
                    Username = txtUsername.Text,
                    Phone = txtPhone.Text,
                    Password = txtPassword.Text,
                    Address = txtAddress.Text
                };
                _context.Users.Add(user);
                _context.SaveChanges();
                LoadDataGridView();
                MessageBox.Show("Book saved successfully");
                Clear();
            }
        }

        private void LoadDataGridView()
        {
            dataGridView1.DataSource = _context.Users.ToList();
        }



        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                var user = _context.Users.Find(id);

                if (txtUsername.Text == "" || txtAddress.Text == "" || txtPhone.Text == "" ||
                txtPassword.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to update this book?", "Confirmation", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        user.Username = txtUsername.Text;
                        user.Phone = txtPhone.Text;
                        user.Address = txtAddress.Text;
                        user.Password = txtPassword.Text;
                        _context.SaveChanges();
                        LoadDataGridView();
                        MessageBox.Show("User updated successfully");
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


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                var user = _context.Users.SingleOrDefault(u => u.UserId == id);

                if (user != null)
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this user?", "Confirmation", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        _context.Users.Remove(user);
                        _context.SaveChanges();
                        MessageBox.Show("Delete user successfully");
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

        private void Clear()
        {
            txtUsername.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Clear();
            LoadDataGridView();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                var user = _context.Users.Find(id);
                if (user != null)
                {
                    txtUsername.Text = user.Username;
                    txtPhone.Text = user.Phone;
                    txtAddress.Text = user.Address;
                    txtPassword.Text = user.Password;
                }
            }
        }



        private void lbBooks_Click(object sender, EventArgs e)
        {
            frmBooksManagement frmBooksManagement = new frmBooksManagement();
            frmBooksManagement.Show();
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
    }
}
