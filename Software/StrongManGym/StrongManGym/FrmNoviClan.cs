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
            var sifra = int.Parse(txtSifraClana.Text);
            var name = txtFirstName.Text;
            var lastname = txtLastName.Text;
            var email = txtEmail.Text;
            var dateofbirth = DateTimeOffset.Parse(dtpDate.Value.ToString("yyyy-MM-dd"));
            var contact = txtContact.Text;
            var status = cboStatusClanarine.SelectedItem as StatusClanarine;

            var clanovi = new Clanovi
            {
                IdClana = sifra,
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
}
