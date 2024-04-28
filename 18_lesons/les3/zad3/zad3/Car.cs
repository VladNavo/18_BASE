using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    internal class Car: Vehicle
    {
        public Car(double coordinates, double price, double speed, int year) : base(coordinates, price, speed, year)
        {
        }

        
        public override void ShowInfo()
        {
            base.ShowInfo(); 
        }
    }
}
