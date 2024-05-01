using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad4
{
    internal class Employee
    {
        private string firstname;
        private string lastname;
        private Enum position;
        private int experience;
        public Employee(string firstname,string lastname,Enum position,int expirience)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.position = position;
            this.experience = expirience;
        }

        public double Calculatemon()
        {
            double finalsumm;
            var basem = 2000.0;
            var expbonus = 1.4+5*0.1;
            var positionBonus = 1.0;
            switch (position.ToString())
            {
                case "0": positionBonus = 500; break;
                case "1": positionBonus = 1000;break;
            }
            
            
            finalsumm=basem*expbonus+positionBonus;

           var tax = finalsumm * 0.2;
            finalsumm-=tax;
            return finalsumm;
        }
        public void DisplayEmployeeInfo()
        {
           


          double  finalsumm=Calculatemon();

           
            Console.WriteLine("Информация о сотруднике:");
            Console.WriteLine("Фамилия: " + lastname);
            Console.WriteLine("Имя: " + firstname);
            Console.WriteLine("Должность: " + position);
            Console.WriteLine("Оклад: " + finalsumm);
            
        }
    }
}
