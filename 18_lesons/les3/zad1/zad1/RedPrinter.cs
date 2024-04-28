using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    internal class RedPrinter:Printer
    {
        public override void print(string value)
        {
            
            Console.ForegroundColor = ConsoleColor.Red;
            base.print(value);
            
        }

    }
}
