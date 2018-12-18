using System;

namespace RefresherAnswers
{
    public class Address
    {        
        public string Street { get; set; }
        public int HouseNumber { get; set; }
        public int ZipCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public Address()
        {
            Street = "Kalverstraat";
            HouseNumber = 1;
            ZipCode = 1012;
            City = "Amsterdam";
            Country = "The Netherlands";
        }

        public Address(string street, int houseNumber, int zipCode, string city, string country)
        {
            Street = street;
            HouseNumber = houseNumber;
            ZipCode = zipCode;
            City = city;
            Country = country;
        }

        public void MoveOneHouseToTheRight()
        {
            HouseNumber += 2;
        }
    }
}
