using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITIES;
using System.Data.SQLite;

namespace DATA
{
    public class SaleDAL
    {
        private readonly string _connectionString = Connection.getConnectionString();

        public List<int> GetSoldNumbers(int raffleId)
        {
            List<int> soldNumbers = new List<int>();
            var query = "SELECT SaleDetails.Number FROM Raffles " + 
                        "INNER JOIN Sales ON Sales.RaffleId = Raffles.Id " +
                        "INNER JOIN SaleDetails ON SaleDetails.SaleId = Sales.Id " +
                        "WHERE Raffles.Id = @raffleId";

            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@raffleId", raffleId);

                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        soldNumbers.Add(reader.GetInt32(0));
                    }
                }
            }

            return soldNumbers;
        }

        public List<Sale> GetSalesByRaffleIdPaginated(int raffleId)
        {
            List<Sale> sales = new List<Sale>();
            var query = "SELECT s.Id, s.RaffleId, s.Client, pm.Id, pm.Method, s.Details, s.NumbersQuantity, s.NumberPrice, s.Total, s.CreatedAt " +
                        "FROM Sales s " +
                        "INNER JOIN PaymentMethods pm ON pm.Id = s.PaymentMethodId " +
                        "WHERE s.RaffleId = @raffleId " +
                        "ORDER BY s.Id DESC";

            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@raffleId", raffleId);

                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var sale = new Sale()
                        {
                            Id = reader.GetInt32(0),
                            RaffleId = reader.GetInt32(1),
                            Client = reader.GetString(2),
                            PaymentMethod = new PaymentMethod
                            {
                                Id = reader.GetInt32(3),
                                Method = reader.GetString(4),
                            },
                            Details = reader.IsDBNull(5) ? null : reader.GetString(5),
                            NumbersQuantity = reader.GetInt32(6),
                            NumberPrice = reader.GetInt32(7),
                            Total = reader.GetInt32(8),
                            CreatedAt = reader.IsDBNull(9) ? null : reader.GetDateTime(9),
                        };

                        sales.Add(sale);
                    }
                }
            }

            return sales;
        }

        public List<SaleDetails> GetNumbersBySaleId(int saleId)
        {
            List<SaleDetails> numbers = new List<SaleDetails>();
            var query = "SELECT sd.SaleId, sd.Number FROM Sales s " +
                        "JOIN SaleDetails sd ON sd.SaleId = s.Id " +
                        "WHERE s.Id = @saleId " +
                        "ORDER BY sd.Number ASC";

            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                var cmd= new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@saleId", saleId);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var sale = new SaleDetails()
                        {
                            SaleId = reader.GetInt32(0),
                            Number = reader.GetInt32(1),
                        };

                        numbers.Add(sale);
                    }
                }
            }

            return numbers;
        }

        public bool CreateSale(Sale sale)
        {
           using (var conn = new SQLiteConnection(_connectionString))
           {
                conn.Open();
                var cmd = conn.CreateCommand();
                var transcation = conn.BeginTransaction();

                cmd.Connection = conn;
                cmd.Transaction = transcation;

                try
                {
                    cmd.CommandText =
                        "INSERT INTO Sales (RaffleId, Client, PaymentMethodId, Details, NumbersQuantity, NumberPrice, Total, CreatedAt) " +
                        "VALUES (@raffleId, @client, @paymentMethod, @details, @numbersQuantity, @numberPrice, @total, @createdAt);" +
                        "SELECT last_insert_rowid()";
                    cmd.Parameters.AddWithValue("@raffleId", sale.RaffleId);
                    cmd.Parameters.AddWithValue("@client", sale.Client);
                    cmd.Parameters.AddWithValue("@paymentMethod", sale.PaymentMethod.Id);
                    cmd.Parameters.AddWithValue("@details", sale.Details);
                    cmd.Parameters.AddWithValue("@numbersQuantity", sale.NumbersQuantity);
                    cmd.Parameters.AddWithValue("@numberPrice", sale.NumberPrice);
                    cmd.Parameters.AddWithValue("@total", sale.Total);
                    cmd.Parameters.AddWithValue("@createdAt", DateTime.Now);

                    var saleId = Convert.ToInt32(cmd.ExecuteScalar());
                    if (saleId <= 0)
                        throw new Exception("No fue posible crear la venta");

                    foreach (SaleDetails saleDetail in sale.Numbers)
                    {
                        cmd.Parameters.Clear();

                        cmd.CommandText =
                            "INSERT INTO SaleDetails (SaleId, Number) " +
                            "VALUES (@saleId, @number)";
                        cmd.Parameters.AddWithValue("@saleId", saleId);
                        cmd.Parameters.AddWithValue("@number", saleDetail.Number);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected == 0)
                            throw new Exception("fallo al guardar uno de los números");
                    }

                    transcation.Commit();
                    return true;

                } 
                catch (Exception ex)
                {
                    transcation.Rollback();
                    throw ex;
                }
           }
        }
    }
}
