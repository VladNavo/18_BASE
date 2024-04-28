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
            Invoice invoice = new Invoice(12345, "Поставщик Компания","Покупатель Иванов", 1500, 1,"Ноутбук");

           
            double totalPriceWithNDS = invoice.CalculateTotalPrice(true);
            Console.WriteLine("Стоимость заказа с НДС: " + totalPriceWithNDS);

            
            double totalPriceWithoutNDS = invoice.CalculateTotalPrice(false);
            Console.WriteLine("Стоимость заказа без НДС: " + totalPriceWithoutNDS);

           

        }
    }
}
