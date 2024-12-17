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
    public partial class NewSaleFrm : Form
    {
        private readonly Raffle _raffle;

        private readonly SaleBLL _saleBLL;
        private readonly PaymentMethodsBLL _paymentMethodsBLL;

        private List<PaymentMethod> paymentMethods;

        List<int> availableNumbers = new List<int>();
        List<int> choosedNumbers = new List<int>();

        int total = 0;

        public NewSaleFrm(Raffle raffle)
        {
            InitializeComponent();

            _raffle = raffle;

            _saleBLL = new SaleBLL();
            _paymentMethodsBLL = new PaymentMethodsBLL();
        }

        void CalculateTotal()
        {
            total = choosedNumbers.Count() * _raffle.Price;
            lblNumPrice.Text = _raffle.Price.ToString();
            lblNumCount.Text = choosedNumbers.Count().ToString();
            lblTotal.Text = string.Format("{0:C0}", total);
        }

        void AddNumber(int number)
        {
            choosedNumbers.Add(number);
            choosedNumbers.OrderBy(x => x);
            listBox.Items.Add(number);
            availableNumbers.Remove(number);
            SyncComboBox();
            CalculateTotal();
        }

        void RemoveNumber(int numToRemove)
        {
            choosedNumbers.Remove(numToRemove);
            availableNumbers.Add(numToRemove);
            listBox.Items.Remove(numToRemove);
            SyncComboBox();
            CalculateTotal();
        }

        void SyncComboBox()
        {
            cbNumber.Items.Clear();
            foreach (int number in availableNumbers.OrderBy(x => x))
            {
                cbNumber.Items.Add(number);
            }
        }

        void LoadPaymentMethods()
        {
            paymentMethods = _paymentMethodsBLL.Get();

            cbPaymentMethod.DataSource = paymentMethods;
            cbPaymentMethod.DisplayMember = "Method";
            cbPaymentMethod.ValueMember = "Id";
        }

        void ComboBoxAddNumber()
        {
            bool numIsAvailable = false;
            bool numIsChoosed = false;
            int numInserted = 0;

            if (!int.TryParse(cbNumber.Text, out numInserted))
                return;

            // Validate if the number has alreday been taken
            foreach (int number in choosedNumbers)
            {
                if (number == numInserted)
                {
                    numIsChoosed = true;
                }
            }
            if (numIsChoosed)
            {
                MessageBox.Show($"El número {numInserted} ya esta seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate if the number is available
            foreach (int number in availableNumbers)
            {
                if (number == numInserted)
                {
                    numIsAvailable = true;
                }
            }
            if (!numIsAvailable)
            {
                MessageBox.Show($"El número {numInserted} no esta disponible", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            AddNumber(numInserted);
        }

        private void SalesFrm_Load(object sender, EventArgs e)
        {
            availableNumbers = _saleBLL.GetAvailableNumbers(_raffle.Id);
            SyncComboBox();
            listBox.Sorted = true;

            LoadPaymentMethods();
            lblNumPrice.Text = _raffle.Price.ToString();
        }

        private void cbNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxAddNumber();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedItems.Count == 0)
                return;

            string selectedItem = listBox.SelectedItem.ToString().Trim();
            int numToRemove = int.Parse(selectedItem);
            RemoveNumber(numToRemove);
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            List<SaleDetails> saleDetails = new List<SaleDetails>();
            foreach (int number in choosedNumbers)
                saleDetails.Add(new SaleDetails { Number = number });

            var newSale = new Sale
            {
                RaffleId = _raffle.Id,
                Client = txtClient.Text,
                Details = txtDetails.Text,
                PaymentMethod = cbPaymentMethod?.SelectedItem as PaymentMethod,
                NumbersQuantity = choosedNumbers.Count,
                NumberPrice = _raffle.Price,
                Numbers = saleDetails
            };

            var result = _saleBLL.CreateSale(newSale);

            if (!result.Success)
            {
                //ShowFieldsErrors(result.Errors);
                MessageBox.Show(result.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show(result.Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Dispose();

        }

        private void cbNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Enter)
            {
                ComboBoxAddNumber();
                cbNumber.Text = "";
            }
        }
    }
}
