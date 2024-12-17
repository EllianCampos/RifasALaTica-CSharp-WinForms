using LOGIC;

namespace PRESENTATION
{
    public partial class RafflesFrm : Form
    {
        private readonly RaffleBLL _raffleBLL = new RaffleBLL();

        private int _limit = 10;
        private int _page = 1;

        public RafflesFrm()
        {
            InitializeComponent();
        }

        private void FillPageNumberCB(int totalPages)
        {
            cbPageNumber.Items.Clear();
            int count = 1;
            while (count <= totalPages)
                cbPageNumber.Items.Add(count++);

            if (cbPageNumber.Items.Count > 0)
                cbPageNumber.SelectedIndex = _page - 1;
            else
            {
                cbPageNumber.Items.Add(1);
                cbPageNumber.SelectedIndex = 0;
            }
        }

        private void GetRaffles()
        {            
            int offSet = (_limit * _page) - _limit;
            var (rowsCount, rows) = _raffleBLL.GetPaginated(_limit, offSet);

            int totalPages = (int)Math.Ceiling((double)rowsCount / _limit);

            lblTotalItems.Text = $"({rowsCount}) items";            
            txtTotalPages.Text = totalPages.ToString();
            FillPageNumberCB(totalPages);

            dgvRaffles.DataSource = null;
            dgvRaffles.DataSource = rows;
            dgvRaffles.Columns[0].Visible = false;
            dgvRaffles.Columns[1].HeaderText = "Nombre del Sorteo";
            dgvRaffles.Columns[2].HeaderText = "Fecha";
            dgvRaffles.Columns[3].HeaderText = "Valor del Número";
        }

        private void RafflesFrm_Load(object sender, EventArgs e)
        {
            GetRaffles();
            cbItemsPerPage.Text = _limit.ToString();
        }

        private void btnAddRaffle_Click(object sender, EventArgs e)
        {
            this.Hide();
            var raffleForm = new RaffleFormFrm();
            raffleForm.ShowDialog();
            this.Show();
            GetRaffles();
        }

        private void dgvRaffles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int raffleId = Convert.ToInt32(dgvRaffles.SelectedRows[0].Cells[0].Value);

            var raffleFrm = new RaffleFrm(raffleId);
            this.Hide();
            raffleFrm.ShowDialog();
            this.Show();
            GetRaffles();
        }

        private void cbItemsPerPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            _page = 1;
            _limit = Convert.ToInt32(cbItemsPerPage.SelectedItem);
            GetRaffles();
        }

        private void cbPageNumber_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _page = Convert.ToInt32(cbPageNumber.SelectedItem);
            GetRaffles();
        }
    }
}
