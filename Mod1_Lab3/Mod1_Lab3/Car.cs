using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_Lab3
{

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
