using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    internal class House : ICloneable
    {
        public string Address { get; set; }
        public int NumberOfFloors { get; set; }
        public Apartment apartment { get; set; }

        public House(string address,  int numberOfFloors, Apartment apartment)
        {
            Address = address;
            NumberOfFloors = numberOfFloors;
            this.apartment = apartment;
        }

        public object Clone() => MemberwiseClone();

        public House DeepClone()
        {
            House NewHouse = (House)this.MemberwiseClone();
            NewHouse.Address = String.Copy(Address);
            NewHouse.NumberOfFloors = NumberOfFloors;
            NewHouse.apartment = new Apartment(NumberOfFloors);
            return NewHouse;
        }

    }
}
