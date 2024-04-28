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
            Player player = new Player();

            
            Console.WriteLine("Проигрывание:");
            player.Play();
            player.Pause();
            player.Stop();

            Console.WriteLine("\nЗапись:");
            player.Record();
            player.Pause();
            player.Stop();

           
        }
    }
}
