using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_27_08_2025
{
    internal class Adress
    {
        public string Type {  get; set; }
        public string Street {  get; set; }
        public string HouseNumber { get; set; }
        public int Zip {  get; set; }
        public string City {  get; set; }
        public string Country { get; set; }
        public Adress(string type, string street, string houseNumber, int zip, string city, string country) 
        { 
            Type = type;
            Street = street;
            HouseNumber = houseNumber;
            Zip = zip;
            City = city;
            Country = country;
        }

        public void PrintAdress()
        {
            Console.WriteLine($"{Type}:\n" +
                $"{Street} {HouseNumber}, \n" +
                $"{Zip} {City}\n" +
                $"{Country}");
        }
    }
}
