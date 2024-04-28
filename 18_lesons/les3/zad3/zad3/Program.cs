using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Plane plane = new Plane(100, 800, 2010, 10000, 150,30);
            Car car = new Car(50, 200, 2018, 30);
            Ship ship = new Ship(500, 30, 2005, 500,  30,"Minsk");

            
            Console.WriteLine("Информация о самолете:");
            plane.ShowInfo();

            Console.WriteLine("\nИнформация о машине:");
            car.ShowInfo();

            Console.WriteLine("\nИнформация о корабле:");
            ship.ShowInfo();
        }
    }
}
