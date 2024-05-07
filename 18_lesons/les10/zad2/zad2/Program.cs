using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<int> list = new MyList<int>();
            for(int i = 0; i < 100; i++){list.Add(i);}
            Console.WriteLine(list.GetEnumerator());
            Console.WriteLine(list[10]);
        }
    }
}
