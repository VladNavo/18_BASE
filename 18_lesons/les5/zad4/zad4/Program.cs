using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Article tov1 = new Article("product1","ami",123.45);
            Article tov2 = new Article("product2", "5element", 123.45);
            Article tov3 = new Article("product3", "21vek", 123.45);
            Article tov4 = new Article("product4", "pro", 123.45);
            Article tov5 = new Article("product5", "ami", 123.45);

            Store store1= new Store(tov1,tov2,tov3,tov4,tov5);
            Console.WriteLine("введите имя товара");
            var result1=Console.ReadLine();
           store1.proverka(result1);
            Console.WriteLine("введите id товара");
            var result2 =Convert.ToInt32(Console.ReadLine());
            store1.PoId(result2);



        }
    }
}
