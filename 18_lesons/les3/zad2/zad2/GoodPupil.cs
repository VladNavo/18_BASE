using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    internal class GoodPupil:Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Хороший ученик учится");
        }

        public override void Read()
        {
            Console.WriteLine("Хороший ученик читает");
        }

        public override void Write()
        {
            Console.WriteLine("Хороший ученик пишет");
        }

        public override void Relax()
        {
            Console.WriteLine("Хороший ученик отдыхает");
        }
    }
}
