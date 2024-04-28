using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    internal class User
    {
        private string login;
        private string firstName;
        private string lastName;
        private int age;
        private readonly DateTime registrDate;

       
        public User(string login, string firstName, string lastName, int age)
        {
            this.login = login;
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.registrDate = DateTime.Now; 
        }

        
        public void DisplayUserInfo()
        {
            Console.WriteLine("Информация о пользователе:");
            Console.WriteLine("Логин: " + login);
            Console.WriteLine("Имя: " + firstName);
            Console.WriteLine("Фамилия: " + lastName);
            Console.WriteLine("Возраст: " + age);
            Console.WriteLine("Дата заполнения анкеты: " + registrDate);
        }
    }
}
