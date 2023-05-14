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

        public void ShowClanovi(string filter = "")
        {
            var clanovi = ClanoviRepository.GetClanovis().ToList();
            if (!string.IsNullOrEmpty(filter) )
            {
                var filteredClanovi = ClanoviRepository.GetClanovis().Where(c => c.FirstName.ToLower().Contains(filter.ToLower()) || c.LastName.ToLower().Contains(filter.ToLower())).ToList();
                if (filteredClanovi.Any())
                {
                    dgvClanovi.DataSource = filteredClanovi;
                }
                else
                {
                    dgvClanovi.DataSource = null;
                    MessageBox.Show("Traženi član nije pronađen.");
                }
            }
            else
            {
                dgvClanovi.DataSource = clanovi;
            }
            
            dgvClanovi.Columns["Id"].Visible = false;
            dgvClanovi.Columns["IdClana"].DisplayIndex = 0;
            dgvClanovi.Columns["FirstName"].DisplayIndex = 1;
            dgvClanovi.Columns["LastName"].DisplayIndex = 2;
            dgvClanovi.Columns["E_mail"].DisplayIndex = 3;
            dgvClanovi.Columns["DateOfBirth"].DisplayIndex = 4;
            dgvClanovi.Columns["Kontakt"].DisplayIndex = 5;
            dgvClanovi.Columns["NazivClanarine"].DisplayIndex = 6;
            dgvClanovi.Columns["IdClanarine"].Visible = false;
        }

        private void btnNoviClan_Click(object sender, EventArgs e)
        {
            FrmNoviClan forma = new FrmNoviClan();
            this.Hide();
            forma.ShowDialog();
        }

        private void btnUlaz_Click(object sender, EventArgs e)
        {

            var selectedClan = dgvClanovi.CurrentRow.DataBoundItem as Clan;
            if (selectedClan != null)
            {
                var posljednjiUlazIzlaz = UlazIzlazRepostiroy.GetPosljednjiUlazIzlaz(selectedClan.IdClana);
                if (posljednjiUlazIzlaz == null)
                {
                   var ulaz = new UlazIzlaz
                    {
                        IdClana = selectedClan.IdClana,
                        Ulaz = DateTime.Now
                    };

                    UlazIzlazRepostiroy.InsertUlaz(ulaz);
                    MessageBox.Show("Uspješno zabilježen ulaz!");
                }

                else if (posljednjiUlazIzlaz.Izlaz != null)
                {
                    var ulaz = new UlazIzlaz
                    {
                        IdClana = selectedClan.IdClana,
                        Ulaz = DateTime.Now
                    };

                    UlazIzlazRepostiroy.InsertUlaz(ulaz) ;
                    MessageBox.Show("Uspješno zabilježen ulaz!");
                }
                else
                {
                    MessageBox.Show("Za odabranog člana ulaz je već zabilježen!");
                }
            }
        }
        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            var selectedClan = dgvClanovi.CurrentRow.DataBoundItem as Clan;
            if (selectedClan != null)
            {
                var posljednjiUlazIzlaz = UlazIzlazRepostiroy.GetPosljednjiUlazIzlaz(selectedClan.IdClana);
               
                if (posljednjiUlazIzlaz == null || posljednjiUlazIzlaz.Ulaz == null)
                {
                    MessageBox.Show("Za odabranog člana nije zabilježen ulaz!");
                }
                else
                {
                    posljednjiUlazIzlaz.Izlaz = DateTime.Now;
                    UlazIzlazRepostiroy.InsertIzlaz(posljednjiUlazIzlaz);
                    MessageBox.Show("Uspješno zabilježen izlaz!");
                }
            }
        }

        private void btnPrikaziClana_Click(object sender, EventArgs e)
        {
            
            Clan selectedClan = dgvClanovi.CurrentRow.DataBoundItem as Clan;
            if(selectedClan != null)
            {
                FrmSelectedClan showSelectedClan = new FrmSelectedClan(selectedClan);
                showSelectedClan.ShowDialog();
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string filter = txtFilter.Text.Trim().ToLower();
            var clanovi = ClanoviRepository.GetClanovis().ToList();
            var filteredClanovi = clanovi.Where(c => c.FirstName.ToLower().Contains(filter) || c.LastName.ToLower().Contains(filter)).ToList();
            if (filteredClanovi.Count == 0)
            {
                MessageBox.Show("Traženi član nije pronađen!");
                ShowClanovi();
            }
            else
            {
                dgvClanovi.DataSource = filteredClanovi;
            }
        }
    }
}
