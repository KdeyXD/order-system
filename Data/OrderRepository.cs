using DecoratorDrink.Logic.Composite;
using DrinkOrderSystem.Data;
using Microsoft.Data.SqlClient;

namespace MiniPOS.Data
{
    public class OrderRepository
    {
        public int InsertOrder(Order order)
        {
            using var conn = DatabaseConnection.Instance.CreateConnection();
            conn.Open();

            using var transaction = conn.BeginTransaction();

            try
            {
                // Insert Order Header
                var cmd = new SqlCommand(
                    "INSERT INTO tbOrder (TotalAmount) OUTPUT INSERTED.Id VALUES (@Total)",
                    conn, transaction);

                cmd.Parameters.AddWithValue("@Total", order.GetTotalPrice());

                int orderId = (int)cmd.ExecuteScalar();

                // Insert Order Items
                foreach (var item in order.Items)
                {
                    if (item is OrderItem orderItem)
                    {
                        var itemCmd = new SqlCommand(
                            @"INSERT INTO tbOrderItem
                              (OrderId, DrinkName, UnitPrice, Quantity, TotalPrice)
                              VALUES (@OrderId, @Name, @UnitPrice, @Qty, @Total)",
                            conn, transaction);

                        itemCmd.Parameters.AddWithValue("@OrderId", orderId);
                        itemCmd.Parameters.AddWithValue("@Name", orderItem.GetDescription());
                        itemCmd.Parameters.AddWithValue("@UnitPrice", orderItem.GetUnitPrice());
                        itemCmd.Parameters.AddWithValue("@Qty", orderItem.Quantity);
                        itemCmd.Parameters.AddWithValue("@Total", orderItem.GetTotalPrice());

                        itemCmd.ExecuteNonQuery();
                    }
                }

                transaction.Commit();
                return orderId;
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }
    }
}
