using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            Console.WriteLine("введите 1 число:");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("введите 2 число:");
            int y = Convert.ToInt32(Console.ReadLine());

            calculator.sum(x, y);
            calculator.substraction(x, y);
            calculator.multiplication(x, y);
            calculator.division(x, y);

        }
    }
}
