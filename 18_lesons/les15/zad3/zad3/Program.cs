using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    struct Price
    {
        public string ProductName;   
        public string ShopName;      
        public decimal Cost;         
    }

   internal class Program
    {
        static void Main(string[] args)
        {
            
            Price[] prices = new Price[2];
                        
            for (int i = 0; i < prices.Length; i++)
            {
                Console.WriteLine($"Введите информацию о товаре №{i + 1}:");
                Console.Write("Название товара: ");
                prices[i].ProductName = Console.ReadLine();
                Console.Write("Название магазина: ");
                prices[i].ShopName = Console.ReadLine();
                Console.Write("Стоимость товара (в белорусских рублях): ");
                prices[i].Cost = decimal.Parse(Console.ReadLine());
            }
                        
            Array.Sort(prices, (x, y) => string.Compare(x.ShopName, y.ShopName));
                      
            Console.Write("Введите название магазина для поиска: ");
            string ShopToFind = Console.ReadLine();

            bool found = false;
            foreach (var price in prices)
            {
                if (price.ShopName == ShopToFind)
                {
                    Console.WriteLine($"Товар: {price.ProductName}, Стоимость: {price.Cost} BYN");
                    found = true;
                }
            }
                        
            if (!found)
            {
                throw new Exception($"Магазин с названием '{ShopToFind}' не найден.");
            }
        }
    }
}
