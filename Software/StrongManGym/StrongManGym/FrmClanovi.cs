using StrongManGym.Models;
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
    public partial class FrmClanovi : Form
    {
        public FrmClanovi()
        {
            InitializeComponent();
        }

        private void FrmClanovi_Load(object sender, EventArgs e)
        {
            ShowClanovi();
        }

        private void ShowClanovi()
        {
            var clanovi = ClanoviRepository.GetClanovis();
            //DataGridView test = new DataGridView();
            //test.DataSource = clanovi;
            //test.Columns["Id"].Visible = false;
            //dgvClanovi.Columns["Id"].Visible = false;
            dgvClanovi.DataSource = clanovi;
            dgvClanovi.Columns["Id"].Visible = false;
            dgvClanovi.Columns["IdClana"].DisplayIndex = 0;
            dgvClanovi.Columns["FirstName"].DisplayIndex = 1;
            dgvClanovi.Columns["LastName"].DisplayIndex = 2;
            dgvClanovi.Columns["E_mail"].DisplayIndex = 3;
            dgvClanovi.Columns["DateOfBirth"].DisplayIndex = 4;
            dgvClanovi.Columns["Kontakt"].DisplayIndex = 5;
            dgvClanovi.Columns["StatusClanarine"].DisplayIndex = 6;
        }

        private void btnNoviClan_Click(object sender, EventArgs e)
        {

        }

        private void btnUlaz_Click(object sender, EventArgs e)
        {
            var selectedClan = dgvClanovi.CurrentRow.DataBoundItem as Clanovi;
            if(selectedClan != null)
            {
                //var form = new FrmSelectedClan(selectedClan);
                //form.ShowDialog();
            }
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {

        }

        private void dgvClanovi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
