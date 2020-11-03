using System;
namespace oop_hw_2
{
    public class Person
    {
        private string name;
        private string surname;
        private Address address;

        public Person()
        {

        }

        public Person(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }

        public Person(string name, string surname, Address address)
        {
            this.name = name;
            this.surname = surname;
            this.address = address;
        }

        public void Introduce()
        {
            Console.WriteLine($"My name is {this.name} {this.surname}");
            if (this.address != null)
            {
                address.GetAddress();
            }
            
        }

        public void SetData(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }

        public void SetData(string name, string surname, string street, int houseNo,
            string postalCode, string city, string country)
        {
            this.name = name;
            this.surname = surname;
            address = new Address();
            address.SetAddress(street, houseNo, postalCode, city, country);
        }
    }
}
