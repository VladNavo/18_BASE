using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad4
{
    internal class Store
    {
        private Article[] products;

        public Store(params Article[] productss)
        {
            var flug = false;
            products = new Article[productss.Length];
            for (int i = 0; i < productss.Length; i++)
            {
                products[i] = productss[i];
                flug = true;
            }
            if (!flug)
            {
                Console.WriteLine("нету");
            }
        }

        public void proverka(string namefromconsole)
        {
            var flug = false;
            foreach (Article product in products)
            {
              
                if (product.Name == namefromconsole)
                {
                    
                   Console.WriteLine($"name:{product.Name}shopname:{product.Shopname}price{product.Price}");
                    flug = true;
                    
                }
            }
             if( !flug ) 
            {
                Console.WriteLine("нету");
            }

        }
        public void PoId(int id) 
        {
            for(int i = 0;i < products.Length;i++) 
            {
                if (id == i)
                {
                    Console.WriteLine($"name:{products[i].Name}shopname:{products[i].Shopname}price{products[i].Price}");
                }
            }
        }
    }
}
