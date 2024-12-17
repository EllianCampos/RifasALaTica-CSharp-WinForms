using DATA;
using ENTITIES;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC
{
    public class ReportBLL
    {
        private readonly SaleDAL _saleDAL = new SaleDAL();

        public Dictionary<int, bool> Get(int raffleId)
        {              
            var soldNumbers = _saleDAL.GetSoldNumbers(raffleId);

            // Create a dictionary to know if a number is available or sold
            var numbersList = new Dictionary<int, bool>();
            for (int i = 0; i < 100; i++)
            {
                // Number Sold case
                if (soldNumbers.Contains(i))
                   numbersList.Add(i, false);
                
                // Available case
                else 
                    numbersList.Add(i, true);
            }

            return numbersList;
        }
    }
}
