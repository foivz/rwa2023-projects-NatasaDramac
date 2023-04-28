namespace Teretana
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (username == "")
            {
                MessageBox.Show("Morate upisati korisnièko ime!");
            }
            else if (password == "")
            {
                MessageBox.Show("Morate upisati lozinku!");
            }
        }

     
    }
}