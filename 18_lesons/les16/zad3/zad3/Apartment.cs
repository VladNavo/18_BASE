using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    internal class Apartment : ICloneable
    {
        public int NumberOFRooms { get; set; }

        public Apartment(int numberOfRooms)
        {
            NumberOFRooms = numberOfRooms;
        }

        public object Clone() => MemberwiseClone();

        public Apartment DeepClone()
        {
            return new Apartment(NumberOFRooms);
        }
    }
}
