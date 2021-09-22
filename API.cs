using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ExampleProductInfo
{
    class API
    {
        public static string path = "/Products";
        public static string ComputerOwner { get; set; }
        public static void getComputerName()
        {
           ComputerOwner = Environment.UserName;
        }
        public static void SaveFile()
        {
            Random getRandom = new Random();
            var getNum = getRandom.Next(10, 23502);
            var generate = CheckProduct.product_id + "-" + getNum;
            string fileName = @"Products/" + generate + ".txt";
            using (StreamWriter sw = File.CreateText(fileName))
            {
                sw.WriteLine("Product ID: " + CheckProduct.product_id);
                sw.WriteLine("Product Valid: " + CheckProduct.product_valid);
                sw.WriteLine("Product Weight: " + CheckProduct.product_weight);
                sw.WriteLine("Product Descrption: " + CheckProduct.product_desc);
                sw.WriteLine("Product Price: " + CheckProduct.product_price);
            }
        }
    }
}
