using System;
namespace oop_hw_2
{
    public class Address
    {
        private string street;
        private int houseNo;
        private int? flatNo;
        private string postalCode;
        private string city;
        private string country;

        public Address()
        {
       
        }

        public void SetAddress(string street, int houseNo, string postalCode, string city, string country)
        {
            this.street = street;
            this.houseNo = houseNo;
            this.postalCode = postalCode;
            this.city = city;
            this.country = country;
        }

        public void SetAddress(string street, int houseNo, int flatNo, string postalCode, string city, string country)
        {
            this.street = street;
            this.houseNo = houseNo;
            this.flatNo = flatNo;
            this.postalCode = postalCode;
            this.city = city;
            this.country = country;
        }

        public void GetAddress()
        {
            if (this.flatNo != null)
            {
                Console.WriteLine($"{this.houseNo}/{this.flatNo} {this.street} Street\n" +
                    $"{this.postalCode} {this.city}\n" +
                    $"{this.country}");
            }
            else
            {
                Console.WriteLine($"{this.houseNo} {this.street} Street\n" +
                    $"{this.postalCode} {this.city}\n" +
                    $"{this.country}");
            }
        }
    }
}
