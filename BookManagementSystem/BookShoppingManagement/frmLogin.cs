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
    public partial class frmLogin : Form
    {
        private readonly BookShoppingManagementContext _context = new();
        public frmLogin()
        {
            InitializeComponent();
        }


        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        public static string username_text = "";
        public static string user_id = "";
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            var user = _context.Users.FirstOrDefault(u => u.Username == username && u.Password == password);
            if (user != null)
            {
                user_id = user.UserId.ToString();
                username_text = user.Username;
                frmBill frmBill = new frmBill();
                frmBill.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password");
                txtPassword.Text = string.Empty;
                txtUsername.Text = string.Empty;

            }
        }

        private void linkLabelAdmin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLoginForAdmin frmLoginForAdmin = new frmLoginForAdmin();
            frmLoginForAdmin.Show();
            this.Hide();
        }
    }
}
