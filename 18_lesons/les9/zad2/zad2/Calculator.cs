using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    internal class Calculator
    {
        public  delegate void Operation(int x, int y);
        public Operation sum = (x, y) => Console.WriteLine($"x:{x}+y:{y}={ x + y}");
        public Operation substraction = (x, y) => Console.WriteLine($"{x}-{y}= {x - y}");
        public Operation multiplication = (x, y) => Console.WriteLine($"{x}*{y}= {x * y}");
        public delegate void OperationDivision(double x, double y);
        public OperationDivision division = (x, y) =>
        {
            if (y != 0)
            {
                Console.WriteLine($"{x}/{y}={x / y}");
            }
            else
            {
                Console.WriteLine("на 0 нельзя");
            }
        };
    }
}
