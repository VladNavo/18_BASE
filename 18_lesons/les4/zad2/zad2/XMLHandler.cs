using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    internal class XMLHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Открытие XML документа");
        }

        public override void Create()
        {
            Console.WriteLine("Создание XML документа");
        }

        public override void Change()
        {
            Console.WriteLine("Изменение XML документа");
        }

        public override void Save()
        {
            Console.WriteLine("Сохранение XML документа");
        }
    }
}
