using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    internal class BadPupil:Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Плохой ученик учится");
        }

        public override void Read()
        {
            Console.WriteLine("Плохой ученик читает");
        }

        public override void Write()
        {
            Console.WriteLine("Плохой ученик пишет");
        }

        public override void Relax()
        {
            Console.WriteLine("Плохой ученик отдыхает");
        }
    }
}
