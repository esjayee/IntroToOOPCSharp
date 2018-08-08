using System;
using System.Collections.Generic;
using System.Text;

namespace Mod2_SelfAssess
{
    class Student : Person
    {
        static int studentCount = 0;

        public Student()
        {
            ++studentCount;
        }

        // tricky: can only call one constructor. In order to increment student count for each constructor
        // either have to explicitly add student count, or call a constructor that increments the count
        public Student(string firstname, string surname) : this(firstname, surname, default(DateTime))
        {
        }

        public Student(string firstname, string surname, DateTime dob) : base(firstname, surname, dob)
        {
            ++studentCount;
        }

        public string StudentNumber()
        {
            return "S" + person_id.ToString("000000");
        }

        public override string ToString()
        {
            return $"Student number: {StudentNumber()}\n" + base.ToString(); 
        }

        public int getStudentCount() => studentCount;
        
    }
}
