using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace les1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double side1;
            double side2;
            
            Console.WriteLine("Введите длинну 1 стороны:");
            side1= Convert.ToDouble( Console.ReadLine());
           
            Console.WriteLine("Введите длинну 2 стороны:");
            side2= Convert.ToDouble(Console.ReadLine());

            Rectangle rec = new Rectangle(side1,side2);

            Console.WriteLine($"Площадь прямоуголника:{rec.AreaCalculator()} ____Периметр:{rec.PerimeterCalculator()}");
            Book book = new Book();


            Console.WriteLine("перецдем к заполнению данных о книге:");
            Console.WriteLine("введите автора:");
            try
            {
                book.BookAuthor.author = Console.ReadLine();
                Console.WriteLine("введите название");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                    
            }
            book.BookTitle.title = Console.ReadLine();
            Console.WriteLine("введите содержание");
            book.BookContent.content = Console.ReadLine();
            book.show();


            Point point1 = new Point(10,10,"A");
            Point point2 = new Point(20,20,"B");
            Point point3 = new Point(5,5,"C");
            Point point4 = new Point(100,100,"D");
            Point point5 = new Point(0,0,"E");
            Figure fig1 = new Figure(point1, point2, point3);
            Figure fig2 = new Figure(point1, point2, point3, point4);
            Figure fig3 = new Figure(point1, point2, point3, point4, point5);
            fig1.PerimeterCalculator();
            fig2.PerimeterCalculator();
            fig3.PerimeterCalculator();



            Adress adress = new Adress();
            adress.Street = "Sverdlovo";
            adress.House = "13";
            adress.City = "Minsk";
            adress.Country = "Belarus";
            adress.Apartment = "каб 200-3а";
            adress.Index = "222416";
            Console.WriteLine(adress.Street);
            Console.WriteLine(adress.House);
            Console.WriteLine(adress.City);
            Console.WriteLine(adress.Country);
            Console.WriteLine(adress.Apartment);
            Console.WriteLine(adress.Index);

        }
    }
}
