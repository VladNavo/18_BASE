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
           
            Apartment apartment=new Apartment(5);
            House originalHouse = new House("Sverdlovo 31", 5,apartment);
            House clone = (House)originalHouse.Clone();
            House deepClone = originalHouse.DeepClone();
            clone.apartment.NumberOFRooms = 21;
            deepClone.apartment.NumberOFRooms = 43;
            deepClone.Address = "Tolstoy 51";
            clone.Address = "Tolstoy 55";


            Console.WriteLine("originalHouse:");
            Console.WriteLine(originalHouse.Address);
            Console.WriteLine(originalHouse.NumberOfFloors);
            Console.WriteLine(originalHouse.apartment.NumberOFRooms);

            Console.WriteLine("Clone():");
            Console.WriteLine(clone.Address);  
            Console.WriteLine(clone.NumberOfFloors);
            Console.WriteLine(clone.apartment.NumberOFRooms);

            Console.WriteLine("DeepClone():");
            Console.WriteLine(deepClone.Address);  
            Console.WriteLine(deepClone.NumberOfFloors);
            Console.WriteLine(deepClone.apartment.NumberOFRooms);
        }
    }
}
