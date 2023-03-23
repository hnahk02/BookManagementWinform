namespace BookShoppingManagement
{
    public partial class frmLoading : Form
    {
        public frmLoading()
        {
            InitializeComponent();
        }

        int startPos = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            startPos += 1;
            progressBar1.Value = startPos;
            lbPercent.Text = startPos + "%";
            if (progressBar1.Value == 100)
            {
                progressBar1.Value = 0;
                timer1.Stop();
                frmLogin login = new frmLogin();
                login.Show();
                this.Hide();
            }
        }

        private void frmLoading_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}