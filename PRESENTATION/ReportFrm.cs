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
    public partial class ReportFrm : Form
    {
        private readonly Raffle _raffle;
        private readonly ReportBLL _reportBLL = new ReportBLL();
        private Dictionary<int, bool> _numbers;

        public ReportFrm(Raffle raffle)
        {
            InitializeComponent();
            _raffle = raffle;
        }

        private void ReportFrm_Load(object sender, EventArgs e)
        {
            lblRafleName.Text = _raffle.Name;
            lblPrice.Text = string.Format("{0:C0}", _raffle.Price);

            _numbers = _reportBLL.Get(_raffle.Id);

            var dt = new DataTable();

            // Add Columns
            for (int i = 0; i < 10; i++)
                dt.Columns.Add($"Col{i}", typeof(int));

            // Add Rows
            for (int i = 0; i < 10; i++)
            {
                var row = dt.NewRow();

                for (int j = 0; j < 10; j++)
                {
                    row[j] = (i * 10) + (j);
                }

                dt.Rows.Add(row);
            }

            dgvReport.DataSource = null;
            dgvReport.DataSource = dt;
            dgvReport.ClearSelection();
        }

        private void dgvReport_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value is int number)
            {

                bool isAvailable = false;
                if (_numbers.TryGetValue(number, out isAvailable ))
                {
                    if (isAvailable)
                    {
                        e.CellStyle.BackColor = Color.Green;
                        e.CellStyle.ForeColor = Color.White;
                        e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
                    }
                    else
                    {
                        e.CellStyle.BackColor = Color.Silver;
                    }
                }
            }
        }

    }
}
