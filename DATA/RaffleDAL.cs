using ENTITIES;
using System.Data.SQLite;
using System.Configuration;


namespace DATA
{
    public class RaffleDAL
    {
        private readonly string _connectionString = Connection.getConnectionString();

        public (int, List<Raffle>) GetPaginated(int limit, int offset)
        {
            int rowsCount = 0;
            List<Raffle> raffles = new List<Raffle>();

            using (var conn = new SQLiteConnection(_connectionString))
            {
                // Get the Total of rows
                var query = "SELECT COUNT(*) FROM Raffles";

                conn.Open();
                var cmd = new SQLiteCommand(query, conn);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        rowsCount = reader.GetInt32(0);
                    }
                }
                
                // Get the rows
                query = "SELECT Id, Name, Date, Price FROM Raffles ORDER BY Id DESC LIMIT @limit OFFSET @offset";
                cmd.CommandText = query;                
                cmd.Parameters.AddWithValue("@limit", limit);
                cmd.Parameters.AddWithValue("@offset", offset);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var raffle = new Raffle()
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Date = DateOnly.Parse(reader.GetString(2)),
                            Price = reader.GetInt32(3)
                        };

                        raffles.Add(raffle);
                    }
                }                
            }

            return (rowsCount, raffles);
        }

        public Raffle? GetById(int id)
        {
            Raffle raffle = null;

            using (var conn = new SQLiteConnection(_connectionString))
            {
                var query = "SELECT Id, Name, Date, Price FROM Raffles WHERE Id = @id";

                conn.Open();
                var cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        raffle = new Raffle()
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Date = DateOnly.Parse(reader.GetString(2)),
                            Price = reader.GetInt32(3)
                        };
                    }                    
                }
            }

            return raffle;
        }

        public bool Insert(Raffle raffle)
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                var query = "INSERT INTO Raffles (Name, Date, Price) VALUES (@name, @date, @price)";

                conn.Open();
                var cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", raffle.Name);
                cmd.Parameters.AddWithValue("@date", raffle.Date);
                cmd.Parameters.AddWithValue("@price", raffle.Price);

                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

        public bool Update(Raffle raffle)
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                var query = "UPDATE Raffles SET Name = @name, Date = @date, Price = @price WHERE Id = @id";

                conn.Open();
                var cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", raffle.Name);
                cmd.Parameters.AddWithValue("@date", raffle.Date);
                cmd.Parameters.AddWithValue("@price", raffle.Price);
                cmd.Parameters.AddWithValue("@id", raffle.Id);

                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

        public bool Delete(int id)
        {
            var query = "DELETE FROM Raffles WHERE Id = @id";

            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);

                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
    }
}
