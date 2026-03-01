using DrinkOrderSystem.Model;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkOrderSystem.Data
{
    public class UserRepository
    {
        public User GetUserByUsernameAndPassword(string username, string password)
        {
            using var conn = DatabaseConnection.Instance.CreateConnection();
            conn.Open();

            string query = "SELECT Id, Username, Password FROM tbUser WHERE Username=@Username AND Password=@Password";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new User(
                            reader.GetInt32(0),
                            reader.GetString(1),
                            reader.GetString(2)
                        );
                    }
                }
            }

            return null;
        }
    }
}
