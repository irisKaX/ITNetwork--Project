using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PojisteniApp
{
    internal class Person
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }
        public string PhoneNumber { get; private set; }

        public Person(string firstName, string lastName, int age, string phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            PhoneNumber = phoneNumber;
        }

        public override string ToString()
        {
            return String.Format("{0} {1} {2} {3}", FirstName, LastName, Age, PhoneNumber);
        }
    }
}
