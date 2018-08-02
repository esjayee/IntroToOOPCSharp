using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiating an object of Car() Class by using Type Inference called Car1
            var Car1 = new Car();

            // using dot notation to call members on Car1
            Car1.Color = "kingfisher blue";
            Car1.Year = 1995;
            Car1.Mileage = 85000;

            // output to the console window
            Console.WriteLine($"This car is painted {Car1.Color}, was built in {Car1.Year} and has {Car1.Mileage} miles on it");
        }
    }

    // declaring the Car Class
    // this class has 3 properties: Color, Year and Mileage

    public class Car
    {
        // defining properties
        public string Color { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }
    }
}
