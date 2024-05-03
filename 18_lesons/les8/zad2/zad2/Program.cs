using System;

namespace zad2
{
    internal class Program
    {
        enum Colors
        {
            White,
            Red,
            Green,
            Yellow,
            Blue,
            Magenta,
            Cyan
        }

        static class Printer
        {
            public static void Print(string stroka, Colors color)
            {
                switch (color)
                {
                    case Colors.White:
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case Colors.Red:
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case Colors.Green:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case Colors.Yellow:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case Colors.Blue:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    case Colors.Magenta:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        break;
                    case Colors.Cyan:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }
                Console.WriteLine(stroka);
                Console.ResetColor();
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Выбор цвета (White, Red, Green, Yellow, Blue, Magenta, Cyan): (0, 1, 2, 3, 4, 5, 6)");
            int indexOfColor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите само сообщение:");
            string textMessage = Console.ReadLine();

            if (Enum.IsDefined(typeof(Colors), indexOfColor))
            {
                Printer.Print(textMessage, (Colors)indexOfColor);
            }
            else
            {
                Console.WriteLine("Неверный выбор цвета. Используйте числа от 0 до 6.");
            }
        }
    }
}
