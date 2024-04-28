using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace les1
{
    internal class Author
    {
        public string author;

        static public void Show(  Author aut)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(aut.author);
            Console.ResetColor();

        }
    }
}
