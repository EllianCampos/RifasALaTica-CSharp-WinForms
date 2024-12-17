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
    public partial class SalesFrm : Form
    {
        private Raffle _raffle;
        private List<Sale> _sales;
        private readonly SaleBLL _saleBLL;

        public SalesFrm(Raffle raffle)
        {
            InitializeComponent();
            _raffle = raffle;
            _saleBLL = new SaleBLL();
        }

        void GetSales()
        {
            _sales = _saleBLL.GetSalesByRaffleIdPaginated(_raffle.Id);
            dgvSales.DataSource = null;
            dgvSales.DataSource = _sales;
            dgvSales.Columns[0].Visible = false;
            dgvSales.Columns[1].Visible = false;
            dgvSales.Columns[2].HeaderText = "Cliente";
            dgvSales.Columns[3].Visible = false;
            dgvSales.Columns[4].HeaderText = "Método de Pago";
            dgvSales.Columns[5].HeaderText = "Detalles";
            dgvSales.Columns[6].HeaderText = "Cantidad de Números";
            dgvSales.Columns[7].HeaderText = "Valor del Número";
            dgvSales.Columns[8].HeaderText = "Total";
            dgvSales.Columns[9].HeaderText = "Fecha de Venta";
        }

        private void SalesFrm_Load(object sender, EventArgs e)
        {
            lblRafleName.Text = _raffle.Name;
            GetSales();
        }

        private void dgvSales_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int saleId = Convert.ToInt32(dgvSales.SelectedRows[0].Cells[0].Value);
            var ticketForm = new TicketFrm(_sales.FirstOrDefault(x => x.Id == saleId), _raffle);
            ticketForm.ShowDialog();

        }
    }
}
