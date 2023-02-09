using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagementSystem
{
    public partial class HomeControllerForm : Form
    {
        public HomeControllerForm()
        {
            InitializeComponent();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void personalInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonalInforForm pf = new PersonalInforForm();
            pf.ShowDialog(this);
            
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminForm af = new AdminForm();
            af.ShowDialog(this);
        }
    }
}
