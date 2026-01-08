using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adressbook
{
    internal class Person
    {
        private List<Adress> Adresses;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthYear { get; set; }
        public int ID { get; set; }

        private Hobby hobby;

        public Hobby MyHobby
        {
            get { return hobby; }
        }

        public Person(string firstName, string lastName, int birthYear, int id)
        {

            FirstName = firstName;
            LastName = lastName;
            BirthYear = birthYear;
            ID = id;
            Adresses = new List<Adress>();
        }

        public void addAdress(string type, string street, string houseNumber, int zip, string city, string country)
        {
            Adress newAdress = new Adress(type, street, houseNumber, zip, city, country);
            Adresses.Add(newAdress);
        }

        public void listAdresses()
        {
            Console.WriteLine($"All adresses of {FirstName} {LastName}:");
            foreach (var adress in Adresses)
            {
                adress.PrintAdress();
            }
        }

        public void printAdressByType(string type)
        {
            foreach (var adress in Adresses) 
            {
                if (adress.Type == type)
                {
                    adress.PrintAdress();
                    break;
                }
            }
            Console.WriteLine($"{FirstName} {LastName} has no Adress with type \"{type}\"!");
        }

        public void PrintInfo()
        {
            Console.WriteLine($" --- {FirstName} {LastName} ---\n" +
                $"Birthyear: {BirthYear}");
            foreach (var adress in Adresses)
            {
                adress.PrintAdress();
            }

        }
    }
}
