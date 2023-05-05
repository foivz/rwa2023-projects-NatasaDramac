using DBLayer;
using StrongManGym;
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

        public void ShowClanovi()
        {
            var clanovi = ClanoviRepository.GetClanovis();
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
            FrmNoviClan forma = new FrmNoviClan();
            this.Hide();
            forma.ShowDialog();
        }

        private void btnUlaz_Click(object sender, EventArgs e)
        { 
            
                var selectedClan = dgvClanovi.CurrentRow.DataBoundItem as Clanovi;
                if (selectedClan != null)
                {
                    var ulaz = new UlazIzlaz
                    {
                        IdClana = selectedClan.IdClana,
                        Ulaz = DateTime.Now
                    };
                    
                UlazIzlazRepostiroy.InsertUlaz(ulaz);
                MessageBox.Show("Uspješno zabilježen ulaz!");
                }

        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            var selectedClan = dgvClanovi.CurrentRow.DataBoundItem as Clanovi;
            if (selectedClan != null)
            {
                var izlaz = new UlazIzlaz
                {
                    IdClana = selectedClan.IdClana,
                    Izlaz = DateTime.Now
                };

                UlazIzlazRepostiroy.InsertIzlaz(izlaz);
                MessageBox.Show("Uspješno zabilježen izlaz!");
            }
        }

        private void btnPrikaziClana_Click(object sender, EventArgs e)
        {
            
            Clanovi selectedClan = dgvClanovi.CurrentRow.DataBoundItem as Clanovi;
            if(selectedClan != null)
            {
                FrmSelectedClan showSelectedClan = new FrmSelectedClan(selectedClan);
                showSelectedClan.ShowDialog();
            }

        }
    }
}
