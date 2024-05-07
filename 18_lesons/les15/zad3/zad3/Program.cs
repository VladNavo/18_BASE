using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{


    internal class Program
    {
        static void Main(string[] args)
        {

            Price[] prices = new Price[2];

            for (int i = 0; i < prices.Length; i++)
            {
                Console.WriteLine($"Enter product information №{i + 1}:");
                Console.Write("Product name: ");
                prices[i].ProductName = Console.ReadLine();
                Console.Write("Shop name: ");
                prices[i].ShopName = Console.ReadLine();
                Console.Write("Product cost (byn): ");
                prices[i].Cost = decimal.Parse(Console.ReadLine());
            }

            Array.Sort(prices, (x, y) => string.Compare(x.ShopName, y.ShopName));

            Console.Write("Shop name for search ");
            string ShopToFind = Console.ReadLine();

            bool found = false;
            foreach (var price in prices)
            {
                if (price.ShopName == ShopToFind)
                {
                    Console.WriteLine($"Product: {price.ProductName}, Cost: {price.Cost} BYN");
                    found = true;
                }
            }

            if (!found)
            {
                throw new Exception($"Shop whith this name '{ShopToFind}' not found.");
            }
        }
    }
}
