using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace les1
{
    internal class Title
    {
        public string title;
        static public void Show(  Title tit)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(tit.title);
            Console.ResetColor();
        }
    }
}
