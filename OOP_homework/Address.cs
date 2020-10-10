using System;
namespace OOP_homework
{
    public class Address
    {
        string street, postalCode, city, country;
        int homeNumber, flatNumber;

        public Address()
        {

        }

        public void AddAdress(string address)
        {

        }

        public void ReadAddress()
        {
            Console.Write("{0}/{1} {2} St.", this.homeNumber, this.flatNumber, this.street);
            Console.Write("{0} {1}", this.postalCode, this.city);
            Console.Write(this.country);
        }
    }
}
