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

    }
}
