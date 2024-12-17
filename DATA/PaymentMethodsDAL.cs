using ENTITIES;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA
{
    public class PaymentMethodsDAL
    {
        private readonly string _connectionString = Connection.getConnectionString();

        public List<PaymentMethod> Get()
        {
            List<PaymentMethod> methods = new List<PaymentMethod>();

            using (var conn = new SQLiteConnection(_connectionString))
            {
                string query = "SELECT * FROM PaymentMethods";

                conn.Open();
                var cmd = new SQLiteCommand(query, conn);

                using (SQLiteDataReader reader = cmd.ExecuteReader())
                    while (reader.Read()) 
                        methods.Add(new PaymentMethod() { Id = reader.GetInt32(0), Method = reader.GetString(1) });
            }

            return methods;
        }
    }
}
