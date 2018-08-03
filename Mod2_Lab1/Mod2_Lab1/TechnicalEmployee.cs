using System;
using System.Collections.Generic;
using System.Text;

namespace Mod2_Lab1
{
    // TechnicalEmployee Class inheriting from Employee Class
    class TechnicalEmployee : Employee
    {
        // creates integer variable called successfulCheckIns and assigns value to 5
        public int successfulCheckIns = 5;

        // calls upon base-class (EmployeeClass) constructor from within derived class (TechnicalEmployee Class)
        public TechnicalEmployee(string name) : base(name, 75000)
        {

        }

        public override string employeeStatus()
        {
            return this.toString() + " has " + this.successfulCheckIns + "successfull check ins";
        }
    }
}
