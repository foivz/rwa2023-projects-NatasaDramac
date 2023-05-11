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
    public partial class FrmSelectedClan : Form
    {
        private Clan SelectedClan;
        public FrmSelectedClan(Models.Clan selectedClan)
        {
            InitializeComponent();
            SelectedClan = selectedClan;
        }

    public void ShowUlazIzlaz()
        {
            int idClana = SelectedClan.IdClana;
            List<UlazIzlaz> ulazIzlazClana = UlazIzlazRepostiroy.GetUlazIzlazs(idClana);
            dgvSelectedClan.DataSource = ulazIzlazClana;
            dgvSelectedClan.Columns["IdUlazIzlaz"].Visible = false;
            dgvSelectedClan.Columns["IdClana"].Visible = false;
            dgvSelectedClan.Columns["Ulaz"].HeaderText = "Vrijeme ulaska";
            dgvSelectedClan.Columns["Izlaz"].HeaderText = "Vrijeme izlaska";
        }

        private void FrmSelectedClan_Load(object sender, EventArgs e)
        {
            SetFormText();
            ShowUlazIzlaz();

        }

        private void SetFormText()
        {
            Text = SelectedClan.FirstName + " " + SelectedClan.LastName;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
