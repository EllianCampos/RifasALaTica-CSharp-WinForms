using DATA;
using ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC
{
    public class PaymentMethodsBLL
    {
        private readonly PaymentMethodsDAL _paymentMethods;

        public PaymentMethodsBLL()
        {
            _paymentMethods = new PaymentMethodsDAL();
        }

        public List<PaymentMethod> Get() => _paymentMethods.Get();
    }
}
