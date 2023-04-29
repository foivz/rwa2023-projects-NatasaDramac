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
using StrongManGym.Models;
using StrongManGym.Repositories;

namespace StrongManGym
{
    public partial class FrmLogin : Form
    {
        public static Zaposleni LoggedZaposleni { get; set; }
        public FrmLogin()
        {
            InitializeComponent();
            
        }
        public static void SetConfiguration (string database = "RWA_ndramac_DB", string username = "RWA_ndramac_User", string password= "TRs8W#Qw")
        {
            DB.SetConfiguration(database,username,password);
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
            else
            {
                var zaposleni = ZaposleniRepository.GetZaposleni(username);
                if (zaposleni != null && zaposleni.Password == password) {
                    LoggedZaposleni =zaposleni;
                    FrmClanovi forma = new FrmClanovi();
                    this.Hide();
                    forma.ShowDialog();
                    this.Close();
                    MessageBox.Show("Uspješna prijava!");
                }
                else
                {
                    MessageBox.Show("Neuspješna prijava!");
                }
            }

        }
    }
}
