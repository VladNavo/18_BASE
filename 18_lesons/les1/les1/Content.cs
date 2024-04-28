using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace les1
{
    internal class Content { 
    
        public string content;
        static public void Show(  Content con)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(con.content);
            Console.ResetColor();
        }

    }
}
