using System;

namespace Mod2_Lab1
{
    class Employee
    {
        // 3 private member variables: Name, Salary and id
        private string empName;
        private double empBaseSalary;
        private int empId;

        public string Name { get => empName; set => empName = value; }
        public double BaseSalary { get => empBaseSalary; set => empBaseSalary = value; }
        public int ID { get => empId; set => empId = value; }

        // creates integer variable called empCount and assigns value to 1
        private static int empCount = 1;

        // constructor
        public Employee(string name, double baseSalary)
        {
            this.Name = name;
            this.BaseSalary = baseSalary;

            this.ID = empCount++;
        }

        // this method returns the employee's base salary
        public double getBaseSalary()
        {
            return this.BaseSalary;
        }

        // this method returns the employee's name
        public string getName()
        {
            return this.Name;
        }

        // this method returns the employee's ID
        public int getEmployeeID()
        {
            return this.ID;
        }

        // this method returns the employee's ID and name
        public string toString()
        {
            return this.Name + " (" + this.ID + ")";
        }

        // this method returns the employee's ID and Name and confirms that the employee is in the system
        public virtual string employeeStatus()
        {
            return this.toString() + " is in the company's system";
        }
    }
}
