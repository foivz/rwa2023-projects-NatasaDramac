using StrongManGym;
using StrongManGym.Models;
using StrongManGym.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace StrongManGym
{
    public partial class FrmNoviClan : Form
    {
        public FrmNoviClan()
        {
            InitializeComponent();
        }

        

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            string firstName = txtFirstName.ToString();
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            string lastName = txtLastName.ToString();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            string email = txtEmail.ToString();
        }

    
        private void txtContact_TextChanged(object sender, EventArgs e)
        {
            string Contact = txtContact.ToString();
        }

        private void cboStatusClanarine_SelectedIndexChanged(object sender, EventArgs e)
        {
            var status = cboStatusClanarine.SelectedItem as StatusClanarineRepository;
        }

        private void FrmNoviClan_Load(object sender, EventArgs e)
        {
            var statusClana = StatusClanarineRepository.GetStatusClanarines();
            cboStatusClanarine.DataSource = statusClana;
        }

        private void btnUpisiClana_Click(object sender, EventArgs e)
        {
            

            var sifra =txtSifraClana.Text;
            var name = txtFirstName.Text;
            var lastname = txtLastName.Text;
            var email = txtEmail.Text;
            var dateofbirth = dtpDate.Value;
            var contact = txtContact.Text;
            var status = cboStatusClanarine.SelectedItem as StatusClanarine;

            if (string.IsNullOrEmpty(sifra))
            {
                MessageBox.Show("Morate upisati šifru člana!");
            }
            else if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Morate upisati ime člana!");
            }
            else if (string.IsNullOrEmpty(lastname))
            {
                MessageBox.Show("Morate upisati prezime člana!");
            }
            else if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Morate upisati e-mail člana!");
            }
            else if (dateofbirth > DateTime.Today.AddYears(-15))
            {
                MessageBox.Show("Član mora biti stariji od 15 godina!");
            }
            else if (string.IsNullOrEmpty(contact))
            {
                MessageBox.Show("Morate upisati kontakt člana!");
            }
            else
            {
                var clanovi = new Clan
                {
                    IdClana = int.Parse(sifra),
                    FirstName = name,
                    LastName = lastname,
                    E_mail = email,
                    DateOfBirth = dateofbirth,
                    Kontakt = contact,
                    StatusClanarine = status.NazivClanarine
                };
                ClanoviRepository.InsertNovogClana(clanovi);

                FrmClanovi frmClanovi = new FrmClanovi();
                this.Hide();
                frmClanovi.ShowDialog();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
            FrmClanovi frmClanovi = new FrmClanovi();
            frmClanovi.ShowDialog();
        }
    }
}
