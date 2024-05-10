using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<int> myList = new MyList<int>();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);

            foreach (int item in myList)
            {
                Console.WriteLine(item);
            }
            
            var array = MyListExtension.GetArray(myList);
            foreach (var item in array)
            {
                Console.WriteLine($"array item:"+item);
            }



        }
    }
}
