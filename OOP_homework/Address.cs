using System;
namespace OOP_homework
{
    public class Address
    {
        public string Street { get; set; }
        public int HouseNo { get; set; }
        public int? FlatNo { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string PostalAddress {
            get
            {
                return $"{HouseNo}{(FlatNo.HasValue ? "/" + FlatNo : "")}{Environment.NewLine}{PostalCode} {City}{Environment.NewLine}{Country}";
            }
        }


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
