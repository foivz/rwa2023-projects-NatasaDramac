using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBLayer;

namespace StrongManGym
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            
        }
        public static void SetConfiguration (string database = "RWA_ndramac_DB", string username = "RWA_ndramac_User", string password= "TRs8W#Qw")
        {
            DB.SetConfiguration(database,username,password);
                }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (username == "")
            {
                MessageBox.Show("Morate upisati korisničko ime!");
            }
            else if (password == "")
            {
                MessageBox.Show("Morate upisati lozinku!");
            }

        }
    }
}
