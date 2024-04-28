using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    internal class Ship: Vehicle
    { 
        private int passengers;
        private string port;

       
        public Ship(double coordinates, double price, double speed, int year, int passengers, string port) : base(coordinates, price, speed, year)
        {
            this.passengers = passengers;
            this.port = port;
        }

        
        public override void ShowInfo()
        {
            base.ShowInfo(); 
            Console.WriteLine($"Количество пассажиров: {passengers}");
            Console.WriteLine($"Порт приписки: {port}");
        }

    }
}
