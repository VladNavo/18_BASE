using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace les1
{
    internal class Figure
    {
        private Point[] points;

        public Figure(Point point1, Point point2, Point point3)
        {
            points = new Point[3];
            points[0] = point1;
            points[1] = point2;
            points[2] = point3;
        }

        public Figure(Point point1, Point point2, Point point3, Point point4)
        {
            points = new Point[4];
            points[0] = point1;
            points[1] = point2;
            points[2] = point3;
            points[3] = point4;
        }

        public Figure(Point point1, Point point2, Point point3, Point point4, Point point5)
        {
            points = new Point[5];
            points[0] = point1;
            points[1] = point2;
            points[2] = point3;
            points[3] = point4;
            points[4] = point5;
        }

        double LengthSide(Point A, Point B)
        {
            int kat1 = Math.Abs(A.MyProperty - B.MyProperty);
            int kat2 = Math.Abs(A.MyProperty1 - B.MyProperty1);
            double dlin = Math.Sqrt(kat1 * kat1 + kat2 * kat2);
           
            return dlin;
        }

        public void PerimeterCalculator()
        {
            double perimeter = 0;
            for (int i = 0; i < points.Length - 1; i++)
            {
                perimeter += LengthSide(points[i], points[i + 1]);
                Console.Write(points[i].MyProperty2 + "-");
            }
            perimeter += LengthSide(points[points.Length - 1], points[0]);
            Console.WriteLine(points[points.Length - 1].MyProperty2);
            Console.WriteLine(perimeter.ToString());
        }
    }
}
