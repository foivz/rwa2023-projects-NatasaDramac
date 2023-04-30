using StrongManGym.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private void txtSifraClana_TextChanged(object sender, EventArgs e)
        {
            int SifraClana = int.Parse(txtSifraClana.ToString());
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

        private void txtDate_TextChanged(object sender, EventArgs e)
        {
            DateTime DateOfBirth = DateTime.Parse(txtDate.ToString());
        }

        private void txtContact_TextChanged(object sender, EventArgs e)
        {
            string Contact = txtContact.ToString();
        }

        private void cboStatusClanarine_SelectedIndexChanged(object sender, EventArgs e)
        {
            var status = cboStatusClanarine.SelectedItem as StatusClanarine;
        }
    }
}
