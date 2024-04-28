using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    internal class Player: IPlayable , IRecodable
    {
        public void Play()
        {
            Console.WriteLine("Проигрывание...");
        }

        public void Pause()
        {
            Console.WriteLine("Пауза в проигрывании.");
        }

        public void Stop()
        {
            Console.WriteLine("Остановка проигрывания.");
        }

        
        public void Record()
        {
            Console.WriteLine("Запись...");
        }

        void IRecodable.Pause()
        {
            Console.WriteLine("Пауза в записи.");
        }

        void IRecodable.Stop()
        {
            Console.WriteLine("Остановка записи.");
        }
    }
}
