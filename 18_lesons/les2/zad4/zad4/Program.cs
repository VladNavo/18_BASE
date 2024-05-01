using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad4
{
    internal class Program
    {
        enum Pos
        {
            Manager,
            Developer
           
        }
        static void Main(string[] args)
        { 
            Employee employee = new Employee("Avarice", "navo", Pos.Manager, 5);

            
            employee.DisplayEmployeeInfo();

          

        }
    }
}
