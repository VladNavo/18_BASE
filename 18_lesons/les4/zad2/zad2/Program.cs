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
            AbstractHandler xmlHandler = new XMLHandler();
            AbstractHandler txtHandler = new TXTHandler();
            AbstractHandler docHandler = new DOCHandler();

            
            Console.WriteLine("XML документ:");
            PerformDocumentOperations(xmlHandler);

            Console.WriteLine("\nТекстовый документ:");
            PerformDocumentOperations(txtHandler);

            Console.WriteLine("\nDOC документ:");
            PerformDocumentOperations(docHandler);
        }
        static void PerformDocumentOperations(AbstractHandler handler)
        {
            handler.Open();
            handler.Create();
            handler.Change();
            handler.Save();
        }
    }
}
