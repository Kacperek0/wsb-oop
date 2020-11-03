using System;
namespace OOP_homework
{
    public class Person
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        Address personalAddress = new Address();

        public string Address
        {
            get
            {
                return personalAddress.PostalAddress;
            }
            set
            {
                string street = personalAddress.Street;
                int houseNo = personalAddress.HouseNo;
                if (personalAddress.FlatNo.HasValue)
                {
                    int? flatNo = personalAddress.FlatNo;
                }
                else
                {
                    int? flatNo = null;
                }
                string city = personalAddress.City;
                string postalCode = personalAddress.PostalCode;
                string country = personalAddress.Country;
            }
        }

        public void Introduce()
        {
            Console.WriteLine($"Hi! My name is {Name} {Surname}");
        }

        public void SetData(string name, string surname)
        {
            Name = name;
            Surname = surname;

        }




    }
}
