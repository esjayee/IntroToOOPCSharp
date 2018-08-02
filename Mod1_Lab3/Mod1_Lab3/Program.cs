using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiating an object of Car() Class by using Type Inference called Car1
            var Car1 = new Car();
            var Car2 = new Car("Red", 2008);


            // using dot notation to call members on Car1
            Car1.Color = "kingfisher blue";
            Car1.Year = 1995;
            Car1.Mileage = 85000;

            // access static members
            int carCount = Car.CountCars();

            // output to the console window
            Console.WriteLine($"There are {carCount} cars on inventory right now");
        }
    }



}
