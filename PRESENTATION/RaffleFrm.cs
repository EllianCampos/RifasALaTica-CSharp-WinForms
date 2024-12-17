using ENTITIES;
using LOGIC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRESENTATION
{
    public partial class RaffleFrm : Form
    {
        private Raffle _raffle;

        private readonly RaffleBLL _raffleBLL = new RaffleBLL();

        public RaffleFrm(int raffleId)
        {
            InitializeComponent();

            GetRaffle(raffleId);
        }

        private void GetRaffle(int raffleId)
        {
            var raffle = _raffleBLL.GetById(raffleId);

            if (raffle == null)
                this.Dispose();
            else
                _raffle = raffle;

            lblRafleName.Text = _raffle.Name;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            this.Hide();
            var raffleForm = new RaffleFormFrm(_raffle.Id);
            raffleForm.ShowDialog();
            this.Show();
            GetRaffle(_raffle.Id);
        }

        private void btnNewSale_Click(object sender, EventArgs e)
        {
            var newSaleFrm = new NewSaleFrm(this._raffle);
            this.Hide();
            newSaleFrm.ShowDialog();
            this.Show();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            var salesForm = new SalesFrm(this._raffle);
            this.Hide();
            salesForm.ShowDialog();
            this.Show();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            var reportFrm = new ReportFrm(_raffle);
            this.Hide();
            reportFrm.ShowDialog();
            this.Show();
        }

        private void RaffleFrm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
