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
            Dictionary<string, int> myDictionary = new Dictionary<string, int>();
            myDictionary.Add("one", 1);
            myDictionary.Add("two", 2);
            myDictionary.Add("three", 3);

            Console.WriteLine($"Value for key 'one': {myDictionary["one"]}");
            Console.WriteLine($"Value for key 'two': {myDictionary["two"]}");
            Console.WriteLine($"Value for key 'three': {myDictionary["three"]}");

            Console.WriteLine($"Total number of elements: {myDictionary.Count}");
        }
    }
}
