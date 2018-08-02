using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_Lab2
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

    // declaring the Car Class
    // this class has 3 properties: Color, Year and Mileage

    public class Car
    {
        // defining properties
        public string Color { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }

        // adding a Constructor
        // this constructor instantiates a Car() object while only having the car's color and year information available
        public Car(string color, int year)
        {
            this.Color = color;
            this.Year = year;

            // every time the constructor runs, increment "instances"
            instances++;
        }

        // adding another Constructor
        // this constructor instantiates a Car() object while only having the car's year and mileage information available
        public Car(int year, int mileage)
        {
            this.Year = year;
            this.Mileage = mileage;

            // every time the constructor runs, increment "instances"
            instances++;
        }

        // creates integer variable called "instances" and assigns value to 0
        private static int instances = 0;

        public Car()
        {
            // every time the constructor runs, increment "instances"
            instances++;
        }

        // declare static member
        public static int CountCars()
        {
            return instances;
        }
    }
}
