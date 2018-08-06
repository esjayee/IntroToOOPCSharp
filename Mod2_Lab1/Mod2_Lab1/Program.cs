using System;

namespace Mod2_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiates TechnicalEmployee Object with name Libby called employee1
            var employee1 = new TechnicalEmployee("Libby");
            // Instantiates TechnicalEmployee Object with name Zaynah called employee2
            var employee2 = new TechnicalEmployee("Zaynah");
            // Instantiates BusinessEmployee Object with name Winter called employee3
            var employee3 = new BusinessEmployee("Winter");

            // Output to the console window
            Console.WriteLine(employee1.employeeStatus() + "\n" + employee2.employeeStatus() + "\n" + employee3.employeeStatus() + "\n");
        }
    }
}
