using Microsoft.Data.SqlClient;
using DrinkOrderSystem.Model;

namespace DrinkOrderSystem.Data
{
    public class SaleRepository
    {
        public List<SaleHistory> GetAllSales()
        {
            var sales = new List<SaleHistory>();

            using var conn = DatabaseConnection.Instance.CreateConnection();
            conn.Open();

            string query = @"
            SELECT o.Id, o.OrderDate, o.TotalAmount, p.PaymentType
            FROM tbOrder o
            LEFT JOIN tbPayment p ON o.Id = p.OrderId
            ORDER BY o.OrderDate DESC";

            using var cmd = new SqlCommand(query, conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                sales.Add(new SaleHistory
                {
                    OrderId = reader.GetInt32(0),
                    OrderDate = reader.GetDateTime(1),
                    TotalAmount = reader.GetDecimal(2),
                    PaymentType = reader.IsDBNull(3) ? "N/A" : reader.GetString(3)
                });
            }

            return sales;
        }
    }
}
