namespace winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtusername.Text.ToString() == "admin"&&txtPassword.Text.ToString()=="admin")
            {
                frmMain frmMain = new frmMain();
                frmMain.ShowDialog();
                this.Close();
            }
        }
    }
}