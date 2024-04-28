using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    internal class TXTHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Открытие текстового документа");
        }

        public override void Create()
        {
            Console.WriteLine("Создание текстового документа");
        }

        public override void Change()
        {
            Console.WriteLine("Изменение текстового документа");
        }

        public override void Save()
        {
            Console.WriteLine("Сохранение текстового документа");
        }
    }
}
