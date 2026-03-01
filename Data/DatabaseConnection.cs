using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkOrderSystem.Data
{
    public sealed class DatabaseConnection
    {
        private static readonly DatabaseConnection _instance = new();
        private readonly string _connectionString;

        private DatabaseConnection()
        {
            _connectionString =
                "Server=localhost;Database=OrderDB;Trusted_Connection=True;Encrypt=False;";
        }

        public static DatabaseConnection Instance => _instance;

        public SqlConnection CreateConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
