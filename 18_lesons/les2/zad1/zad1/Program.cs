﻿using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var usd =3.24;
            var eur = 3.5;
            var rub = 0.035;

            Converter converter = new Converter(usd,eur,rub);
            var money =1000.0;
            Console.WriteLine("деньги:" + money);
            
            
            Console.WriteLine("By_to_Rub:"+ converter.ByToRub(money));
            
            Console.WriteLine("ByToEur:" + converter.ByToEur(money));
           
            Console.WriteLine("ByToUsd:" + converter.ByToUsd(money));
            
            Console.WriteLine("ToBy(usd):" + converter.ToBy(money, "usd"));
            
            Console.WriteLine("ToBy(rub):" + converter.ToBy(money, "rub"));
            
            Console.WriteLine("ToBy(eur):" + converter.ToBy(money, "eur"));
        }
    }
}
