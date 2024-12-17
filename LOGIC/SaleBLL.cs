using DATA;
using ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC
{
    public class SaleBLL
    {
        private readonly SaleDAL _saleDAL;

        public SaleBLL()
        {
            _saleDAL = new SaleDAL();
        }

        public List<int> GetAvailableNumbers(int raffleId)
        {
            var availableNumbers = new List<int>();
            var soldNumbers = _saleDAL.GetSoldNumbers(raffleId);

            for (int i = 0; i <= 99; i++)
            {
                bool wasSold = false;

                foreach (int num in soldNumbers)
                {
                    if (i == num)
                    {
                        wasSold = true;
                    }
                }

                if (!wasSold)
                    availableNumbers.Add(i);
            }

            return availableNumbers;
        }

        public List<Sale> GetSalesByRaffleIdPaginated(int raffleId) => _saleDAL.GetSalesByRaffleIdPaginated(raffleId);

        public List<SaleDetails> GetNumbersBySaleId(int saleId) => _saleDAL.GetNumbersBySaleId(saleId);

        public Result CreateSale(Sale sale)
        {
            try
            {
                if (sale.Numbers.Count == 0)
                    return new Result { Success = false, Message = "Debes seleccionar almenos 1 número" };

                if (sale.Client == "")
                    return new Result { Success = false, Message = "El nombre del cliente es requerido" };

                // Calculate the total
                int total = sale.NumberPrice * sale.NumbersQuantity;
                sale.Total = total;

                bool result = _saleDAL.CreateSale(sale);

                if (!result)
                    return new Result { Success = false, Message = "Algo salio mal guardando la venta" };

                return new Result { Success = true, Message = "Venta creada con exito" };
            }
            catch (Exception ex)
            {
                return new Result { Success = false, Message = "Ocurrió un error: " + ex.Message };
            }
        }
    }
}
