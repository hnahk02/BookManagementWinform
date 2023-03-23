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
    public partial class frmLoginForAdmin : Form
    {
        public frmLoginForAdmin()
        {
            InitializeComponent();
        }

        private void frmLoginForAdmin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "admin123@")
            {
                frmBooksManagement frmBooksManagement = new frmBooksManagement();
                frmBooksManagement.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong password!!!");
                txtPassword.Text = string.Empty;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Hide();
        }
    }
}
