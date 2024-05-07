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
            const string CHOSENMODEL = "A6";
            List<Car> cars = new List<Car>
            {
                new Car { Brand = "Toyota", Model = "Camry", Year = 2020, Color = "Black" },
                new Car { Brand = "Honda", Model = "Civic", Year = 2019, Color = "White" },
                new Car { Brand = "Audi", Model = "A6", Year = 2021, Color = "Yellow" }
            };
            List<Purchase> purchases = new List<Purchase>
            {
                new Purchase { Model = "Camry", BuyerName = "Robert Poulson", PhoneNumber = "+37529240556" },
                new Purchase { Model = "Civic", BuyerName = "Robert Poulson", PhoneNumber = "+37529240556" },
                new Purchase { Model = "A6", BuyerName = "Robert Poulson", PhoneNumber = "+37529240556" }
            };
           
            var purchaseInfo = purchases.Where(purchase => purchase.Model == CHOSENMODEL).Join(cars, purchase => purchase.Model, car => car.Model, (purchase, car) => new
            {
                purchase.BuyerName,
                purchase.PhoneNumber,
                car.Brand,
                car.Model,
                car.Year,
                car.Color
            })
            .FirstOrDefault();

            if (purchaseInfo != null)
            {
                Console.WriteLine($"Information about customer:");
                Console.WriteLine($"Name: {purchaseInfo.BuyerName}");
                Console.WriteLine($"Telephone number: {purchaseInfo.PhoneNumber}");

                Console.WriteLine($"Characteristics of the purchased car:");
                Console.WriteLine($"Brand: {purchaseInfo.Brand}");
                Console.WriteLine($"Model: {purchaseInfo.Model}");
                Console.WriteLine($"Year: {purchaseInfo.Year}");
                Console.WriteLine($"Color: {purchaseInfo.Color}");
            }
            else
            {
                Console.WriteLine("Information not found");
            }
        }
    }
}
