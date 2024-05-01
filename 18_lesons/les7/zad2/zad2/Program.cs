using System;

namespace zad2
{
    internal class Program
    {
        struct Train : IComparable<Train>
        {
            private string NamePunkt;
            private int number;
            private DateTime data;

            public string NName
            {
                get { return NamePunkt; }
                set { NamePunkt = value; }
            }

            public int Number
            {
                get { return number; }
                set { number = value; }
            }

            public DateTime Data
            {
                get { return data; }
                set { data = value; }
            }

            public void Proverka(int number, Train[] array)
            {
                bool found = false;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i].Number == number)
                    {
                        Console.WriteLine(array[i].NamePunkt + ":" + array[i].Number + ":" + array[i].Data);
                        found = true;
                        break; 
                    }
                }
                if (!found)
                {
                    Console.WriteLine("Отсутствует");
                }
            }

            public int CompareTo(Train other)
            {
                return this.Number.CompareTo(other.Number);
            }
        }

        static void Main(string[] args)
        {
            Train[] array = new Train[3];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Введите пункт назначения {i + 1} поезда:");
                array[i].NName = Console.ReadLine();

                Console.WriteLine($"Введите номер {i + 1} поезда:");
                array[i].Number = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Введите дату отправки {i + 1} поезда в формате (гггг-мм-дд):");
                array[i].Data = Convert.ToDateTime(Console.ReadLine());
            }

            Array.Sort(array); 

            foreach (var item in array)
            {
                Console.WriteLine($"namePunkt: {item.NName} number: {item.Number} date: {item.Data}");
            }
        }
    }
}
