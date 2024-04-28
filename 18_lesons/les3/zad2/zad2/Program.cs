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
           ExcelentPupil exelent=new ExcelentPupil();
            GoodPupil goodPupil=new GoodPupil();
            BadPupil badPupil=new BadPupil();
            GoodPupil  good=new GoodPupil();

            ClassRoom classRoom = new ClassRoom( exelent,goodPupil,badPupil,good);
            classRoom.Show();


        }
    }
}
