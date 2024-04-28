using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ключ доступа (pro/exp): ");
            string key = Console.ReadLine();

            DocumentWorker documentWorker;

            if (key == "pro")
            {
                documentWorker = new ProDocumentWorker();
            }
            else if (key == "exp")
            {
                documentWorker = new ExpertDocumentWorker();
            }
            else
            {
                documentWorker = new DocumentWorker();
            }

            documentWorker.OpenDocument();
            documentWorker.EditDocument();
            documentWorker.SaveDocument();

            
        }
    }
    
}
