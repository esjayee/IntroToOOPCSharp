using System;
using System.Collections.Generic;
using System.Text;

namespace Mod2_SelfAssess
{
    class Teacher : Person
    {
        public Teacher() { }

        public Teacher(string firstname, string surname) : base(firstname, surname)
        {
        }

        public Teacher(string firstname, string surname, DateTime dob) : base(firstname, surname, dob)
        {
        }

        public string TeacherNumber()
        {
            return "T" + person_id.ToString("000000");
        }

        public override string ToString()
        {
            return $"Teacher number: {TeacherNumber()}\n" + base.ToString();
        }
    }
}
