using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    internal class ClassRoom
    {
        private Pupil[] pupils;
        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3, Pupil pupil4)
        {
            pupils = new Pupil[4];   
            pupils[0] = pupil1;
            pupils[1] = pupil2;
            pupils[2] = pupil3;
            pupils[3] = pupil4;
        }
        public ClassRoom(Pupil pupil1, Pupil pupil2 )
        {
            pupils = new Pupil[2];
            pupils[0] = pupil1;
            pupils[1] = pupil2;
            
        }
        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3)
        {
            pupils = new Pupil[3];
            pupils[0] = pupil1;
            pupils[1] = pupil2;
            pupils[2] = pupil3;
            
        }

        public void Show()
        {
            for (int i = 0; i <pupils.Length; i++)
            {
                Console.WriteLine($"Ученик {i + 1}:");
                pupils[i].Study();
                pupils[i].Read();
                pupils[i].Write();
                pupils[i].Relax();
                Console.WriteLine();
            }
        }


    }
}
