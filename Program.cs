using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace ExampleProductInfo
{
    class Program
    {
        public static bool noErrors;
        static void Main(string[] args)
        {
        StartPoint:
            Directory.CreateDirectory(@"Products");
            if (Directory.Exists("@Products"))
            {
               // Nothing //
            }
            else
            {
                Directory.CreateDirectory(@"Products");
            }
            CheckProduct.ResetProducts();
            Console.Clear();
            API.getComputerName();
            var getCompID = API.ComputerOwner;
            try
            {
                Console.Title = "ProductInfo | v1.0 | by dayofpay | Connecting To Database...";
                Database.Connect();
                noErrors = true;
            }
            catch(MySql.Data.MySqlClient.MySqlException getError)
            {
                Console.WriteLine("Error trying to connect to DataBase ! ERROR \r\n" + getError.Message);
                noErrors = false;
                Thread.Sleep(4500);
                Console.WriteLine("Press any key to exit ...", Console.ReadKey());
            }
            if(noErrors == true)
            {
                Console.Title = "ProductInfo | v1.0 | by dayofpay | Welcome";
                Console.WriteLine($"Welcome,{getCompID} ...",Console.ForegroundColor = ConsoleColor.Blue);
                Thread.Sleep(1000);
                Console.WriteLine("");
                Console.Write("Product ID: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                var getID = Console.ReadLine();
                CheckProduct.startCheck(getID);
                    Console.WriteLine("--------------------------------");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Product ID: " + CheckProduct.product_id);
                    Console.WriteLine("Product Description: " + CheckProduct.product_desc);
                    Console.WriteLine("Product VALID: " + CheckProduct.product_valid);
                    Console.WriteLine("Product Weight: " + CheckProduct.product_weight);
                Console.WriteLine("Product Price: " + CheckProduct.product_price);
                    Console.WriteLine("--------------------------------");
                Console.WriteLine("Save To Files : Y/N");
                var saveCheck = Console.ReadKey();
                if(saveCheck.Key == ConsoleKey.Y)
                {
                    API.SaveFile();
                }
                if(saveCheck.Key == ConsoleKey.N)
                {
                    // Nothing //
                }
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Press Key To Reset The Window...");
                    Console.ReadKey();
                    goto StartPoint;
            }
        }
    }
}
