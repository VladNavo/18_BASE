using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    internal class Vehicle
    {
        protected double coordinates;
        protected double price;
        protected double speed;
        protected int year;

      
        public Vehicle(double coordinates, double price, double speed, int year)
        {
            this.coordinates = coordinates;
            this.price = price;
            this.speed = speed;
            this.year = year;
        }

       
        public virtual void ShowInfo()
        {
            Console.WriteLine($"Цена: {price}$");
            Console.WriteLine($"Скорость: {speed} км/ч");
            Console.WriteLine($"Год выпуска: {year}");
        }
    }
}
