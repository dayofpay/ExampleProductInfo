using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace ExampleProductInfo
{
    class CheckProduct
    {
        public static bool productExists;
        public static string product_id;
        public static string product_desc;
        public static bool product_valid = true;
        public static string product_weight;
        public static double product_price;
        public static void ResetProducts()
        {
            productExists = false;
            product_id = "";
            product_desc = "";
            product_valid = false;
            product_weight = "";
        }
        public static void startCheck(string productid)
        {
            MySqlCommand checkResults = new MySqlCommand("SELECT product_id,product_desc,product_valid,product_weight,product_price FROM productinfo WHERE product_id = '" + productid + "'",Database.connection);
            using (MySqlDataReader resultReader = checkResults.ExecuteReader())
            {
                while (resultReader.Read())
                {
                    if (resultReader.HasRows)
                    {
                        product_id = resultReader.GetString(0);
                        product_desc = resultReader.GetString(1);
                        product_weight = resultReader.GetString(3);
                        product_price = resultReader.GetInt32(4);
                        if (resultReader.GetString(2) == "1")
                        {
                            product_valid = true;
                        }
                        else
                        {
                            product_valid = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("No Results ...", Console.ForegroundColor = ConsoleColor.Red);
                        productExists = false;
                    }
                }
            }
        }
    }
}
