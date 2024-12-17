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
    public partial class RaffleFormFrm : Form
    {
        private readonly RaffleBLL _raffleBLL = new RaffleBLL();

        private int _id = 0;
        private Raffle? _raffle;

        public RaffleFormFrm()
        {
            InitializeComponent();
        }

        public RaffleFormFrm(int? id)
        {
            InitializeComponent();

            if (id != null)
            {
                _raffle = _raffleBLL.GetById(id.Value);
                btnDelete.Visible = true;
            }
        }

        private void RaffleFormFrm_Load(object sender, EventArgs e)
        {
            if (_raffle != null)
            {
                _id = _raffle.Id;
                txtName.Text = _raffle?.Name;
                dtpDate.Text = _raffle?.Date.ToString();
                txtPrice.Text = _raffle?.Price.ToString();

                lblTitle.Text = "Ajustes del Sorteo";
            }
        }

        private void ShowFieldsErrors(Dictionary<string, string> errors)
        {
            string? error;
            errorProvider1.Clear();

            if (errors.TryGetValue("Name", out error))
                errorProvider1.SetError(txtName, error);

            if (errors.TryGetValue("Date", out error))
                errorProvider1.SetError(dtpDate, error);

            if (errors.TryGetValue("Price", out error))
                errorProvider1.SetError(txtPrice, error);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var raffle = new Raffle()
            {
                Id = _id,
                Name = txtName.Text,
                Date = DateOnly.Parse(dtpDate.Text),
                Price = int.TryParse(txtPrice.Text, out int price) ? price : 0,
            };

            var result = _raffleBLL.Save(raffle);

            if (!result.Success)
            {
                ShowFieldsErrors(result.Errors);
                MessageBox.Show(result.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show(result.Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = _raffleBLL.Delete(_id);

            if (!result.Success)
            {
                MessageBox.Show(result.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show(result.Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
