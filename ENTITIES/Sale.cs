using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITIES
{
    public class Sale
    {
        public int? Id { get; set; }

        public int? RaffleId { get; set; }

        public string? Client { get; set; }

        public PaymentMethod PaymentMethod { get; set; }

        public string PaymentMethodText { get => PaymentMethod.Method;  }

        public string? Details { get; set; }

        public int NumbersQuantity { get; set; }

        public int NumberPrice { get; set; }

        public int Total { get; set; }

        public List<SaleDetails> Numbers { get; set; }

        public DateTime? CreatedAt { get; set; }
    }
}
