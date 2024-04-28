using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    internal class ExcelentPupil:Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Отличник учится");
        }

        public override void Read()
        {
            Console.WriteLine("Отличник читает");
        }

        public override void Write()
        {
            Console.WriteLine("Отличник пишет");
        }

        public override void Relax()
        {
            Console.WriteLine("Отличник отдыхает");
        }
    }
}
