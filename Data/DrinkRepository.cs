using DecoratorDrink.Model;
using MiniPOS.Data;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrinkOrderSystem.Data;
namespace DecoratorDrink.Data
{
    public class DrinkRepository
    {
        public List<Drink> GetAllDrinks()
        {
            var drinks = new List<Drink>();
            using var conn = DatabaseConnection.Instance.CreateConnection();
            conn.Open();

            string query = "SELECT Id, Name, Price FROM tbDrinks";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    drinks.Add(new Drink(
                        reader.GetInt32(0),
                        reader.GetString(1),
                        reader.GetDecimal(2)
                    ));
                }
            }

            return drinks;
        }
    }
}
