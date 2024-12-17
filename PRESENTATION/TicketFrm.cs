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
    public partial class TicketFrm : Form
    {
        private Sale _sale;
        private Raffle _raffle;
        private readonly SaleBLL _saleBLL;

        public TicketFrm(Sale sale, Raffle raffle)
        {
            InitializeComponent();
            _sale = sale;
            _raffle = raffle;
            _saleBLL = new SaleBLL();
        }

        private void TicketFrm_Load(object sender, EventArgs e)
        {            
            lblRafleName.Text = _raffle.Name;
            lblClient.Text = _sale.Client;
            lblPrice.Text = _sale.NumberPrice.ToString();
            lblCount.Text = _sale.NumbersQuantity.ToString();
            lblTotal.Text = _sale.Total.ToString();

            lblNumbers.Text = "";
            var numbers = _saleBLL.GetNumbersBySaleId(_sale.Id.Value);
            foreach (SaleDetails sd in numbers)
            {
                lblNumbers.Text += $"  {sd.Number}  ";
            }
        }
    }
}
