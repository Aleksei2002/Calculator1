using System;

namespace ClassPerson
{
    class Person : IComparable<Person>
    {
        string firstName;
        string lastName;
        string idKod;

        public string FirstName { get { return firstName; } }
        public string LastName { get { return lastName; } }
        public string IdKod { get { return idKod; } }

        public Person(string firstName, string lastName, string idKod)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.idKod = idKod;
        }

        public override string ToString()
        {
            return String.Format(
                "{0,-10} {1,-20} {2,-12} ", firstName, lastName, idKod);
        }

        public override bool Equals(object obj)
        {
            Person temp = (Person)obj;

            return firstName == temp.firstName &&
                   lastName == temp.lastName &&
                   idKod == temp.idKod;
        }
        public int CompareTo(Person other)
        {
            // return firstName.CompareTo(other.firstName);    
            return lastName.CompareTo(other.lastName);
        }
    }
}
