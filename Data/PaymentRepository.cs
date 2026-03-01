using DrinkOrderSystem.Data;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniPOS.Data
{
    public class PaymentRepository
    {
        public void InsertPayment(int orderId, string paymentType, decimal amount)
        {
            using var conn = DatabaseConnection.Instance.CreateConnection();
            conn.Open();

            var cmd = new SqlCommand(
                @"INSERT INTO tbPayment (OrderId, PaymentType, Amount)
              VALUES (@OrderId, @Type, @Amount)", conn);

            cmd.Parameters.AddWithValue("@OrderId", orderId);
            cmd.Parameters.AddWithValue("@Type", paymentType);
            cmd.Parameters.AddWithValue("@Amount", amount);

            cmd.ExecuteNonQuery();
        }
    }
}
