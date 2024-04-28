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
        private string position;
        private int experience;
        public Employee(string firstname,string lastname,string position,int expirience)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.position = position;
            this.experience = expirience;
        }

        public double Calculatemon()
        {
            double finalsumm;
            double basem = 2000;
            double expbonus = 1.4+5*0.1;
            double positionBonus = 1;
            if (position == "Менеджер")
            {
                positionBonus = 500;
            }
            else if (position == "Разработчик")
            {
                positionBonus = 1000;
            }
            finalsumm=basem*expbonus+positionBonus;

           double tax = finalsumm * 0.2;
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
