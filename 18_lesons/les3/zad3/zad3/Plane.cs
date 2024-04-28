using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    internal class Plane: Vehicle
    {
        private double height;
        private int passengers;

        
        public Plane(double coordinates, double price, double speed, int year, double height, int passengers) : base(coordinates, price, speed, year)
        {
            this.height = height;
            this.passengers = passengers;
        }

        
        public override void ShowInfo()
        {
            base.ShowInfo(); 
            Console.WriteLine($"Высота: {height} м");
            Console.WriteLine($"Количество пассажиров: {passengers}");
        }
    }
}
