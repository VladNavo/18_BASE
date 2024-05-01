using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad4
{
    internal class Article
    {
        private string name;
        private string shopname;
        private double price;

       

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Shopname
        {
            get { return shopname; }
            set { shopname = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public Article(string name, string shopname, double price)
        {
            this.name = name;
            this.shopname = shopname;
            this.price = price;
        }

    }
}
