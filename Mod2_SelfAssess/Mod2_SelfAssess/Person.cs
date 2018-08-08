using System;

namespace Mod2_SelfAssess
{
    abstract class Person
    {
        // variables
        protected static int id = 0;
        protected int person_id;

        // properties
        public string Forename { get; set; }
        public string Surname { get; set; }
        public DateTime Dob { get; set; }

        public string Address { get; set; }
        public string Postcode { get; set; } = "ZZ99 3WZ";

        public string PhoneNumber { get; set; }

        public Person()
        {
            ++id;
            person_id = id;
        }

        public Person(string forename, string surname) : this()
        {
            this.Forename = forename;
            this.Surname = surname;
        }

        public Person(string forename, string surname, DateTime dob) : this(forename, surname)
        {
            this.Dob = dob;
        }

        public string Name
        {
            get
            {
                return $"{Forename} {Surname}";
            }
        }

        public int Age
        {
            get
            {
                int age = 0;

                if (Dob.Year > 0001)
                {
                    age = DateTime.Today.Year - Dob.Year;

                    if ((Dob.Month > DateTime.Today.Month) || (Dob.Month == DateTime.Today.Month && Dob.Day > DateTime.Today.Day))
                        age--;
                }

                return age;
            }
        }

        public override string ToString()
        {
            return $"Name: {Name}\nAge: {Age:##}\nAddress: {Address}, {Postcode}";
        }
    }
}

