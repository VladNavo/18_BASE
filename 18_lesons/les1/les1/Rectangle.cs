using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace les1
{
    internal class Rectangle
    {
       private double side1;
       private double side2;

      public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
         public double AreaCalculator()
        {
            area = side1 * side2;
            return area;
        }
        public  double PerimeterCalculator()
        {
            perimetr = 2 * side1 + 2 * side2;
            return perimetr;  
        }
        private double area;

        public double Area
        {
            get { return area; }
            
        }
        private double perimetr;

        public double Perimetr
        {
            get { return perimetr; }
            set { perimetr = value; }
        }



    }
}
