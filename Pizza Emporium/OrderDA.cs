using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Emporium
{
    class OrderDA
    {
        DateTime saleDate = DateTime.Now;
        
        public static SqlConnection GetPizzaConnection()
        {
            String connectionString = @"Data Source=pizzaEmporium.db.2823567.hostedresource.com;Initial Catalog=pizzaEmporium;Persist Security Info=True;User ID=pizzaEmporium;Password=C#1434!spring";
            SqlConnection conn = new SqlConnection(connectionString);
            return conn;
        }
    }
}
