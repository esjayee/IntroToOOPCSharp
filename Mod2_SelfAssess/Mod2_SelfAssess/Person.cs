using System;

namespace Mod2_SelfAssess
{
    abstract class Person
    {
        // variables
        private static int id = 0;

        // properties
        public string Forename { get; set; }
        public string Surname { get; set; }
        public DateTime Dob { get; set; }

        public string Address { get; set; }
        public string Postcode { get; set; } = "ZZ99 3WZ";

        public string phoneNumber { get; set; }

        public Person()
        {
            ++id;
        }

        public Person(string forename, string surname) : this()
        {
            this.Forename = forename;
            this.Surname = surname;
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
                int age = -1;

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
            return $"{Name} aged {Age}\nLives at {Address}, {Postcode}";
        }
    }
}

