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

            Printer printer = new Printer();
            printer.print("принтер обычный");
            RedPrinter printer2 = new RedPrinter();
            Printer basePrinter = (Printer)printer2;
            basePrinter.print("красный принтер");
            Console.ResetColor();
        }
    }
}
