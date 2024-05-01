using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    internal class Converter
    {
        readonly double usd;
        readonly double eur;
        readonly double rub;


        public Converter( double usd,double eur,double rub)
        {
            this.usd = usd;
            this.rub = rub;
            this.eur = eur;
        }
        public double ByToUsd(double money) 
        {
            return money / usd;
        }
        public double ByToEur(double money) { return money / eur; }
        public double ByToRub(double money) { return money / rub; }
        
        public double ToBy( double money,string valuta)
        {
            var  itog=0.0;
            if (valuta.Equals("usd"))
            {
                itog = usd * money;
            }
            if (valuta.Equals("eur"))
            {
                itog = eur * money;
            }
            if (valuta.Equals("rub"))
            {
                itog = rub * money;
            }
            return itog;
        }
    }
}
