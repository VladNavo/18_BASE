using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad4
{
    enum variant
    {
        basic,
        pro,
        exp

     }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ключ доступа (pro/exp/basic):(0/1/2) ");
            var key = Console.ReadLine();
            

            DocumentWorker documentWorker;

            if (key == variant.pro.ToString())
            {
                documentWorker = new ProDocumentWorker();
            }
            else if (key == variant.exp.ToString())
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
