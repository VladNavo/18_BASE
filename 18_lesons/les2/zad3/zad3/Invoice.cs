using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    internal class Invoice
    {
       readonly int account;
       readonly string customer;
       readonly string provider;

       public Invoice(int account, string customer, string provider, double price, int quantity, string article)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
            this.price = price;
            this.quantity = quantity;
            this.article = article;
        }

        private string article;
        private int quantity;
        private double price;

        public double CalculateTotalPrice(bool withNDS)
        {
            double totalPrice = quantity * price;
            if (withNDS)
            {
                
                totalPrice *= 1.2;
            }
            return totalPrice;
        }


    }
}
