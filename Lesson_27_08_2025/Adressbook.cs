using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_27_08_2025
{
    
    internal class Adressbook
    {
        private List<Person> People;

        public Adressbook() 
        {
            People = new List<Person>();
        }

        public void addPerson(string firstName, string lastName, int birthYear, int id)
        {
            Person newPerson = new Person(firstName, lastName, birthYear, id);

            foreach (Person person in People)
            {
                if(person.ID == id)
                {
                    throw new ArgumentException($"ID: {id} already used!");
                }
            }
            Console.WriteLine("Person added!");
            People.Add(newPerson);
        }

        public void addAdressToPersonById(int id, string type, string street, string houseNumber, int zip, string city, string country)
        {

            var person = People.SingleOrDefault(p => p.ID == id);

            if(person != null)
            {
                person.addAdress(type, street, houseNumber, zip, city, country);
            }
            else
            {
                throw new Exception($"Keine Person mit ID = {id} gefunden!");
            }

        }


        public int getPersonIdByName(string firstName, string lastName)
        {
            var foundPerson = People.FirstOrDefault(p => (p.FirstName == firstName && p.LastName == lastName));

            if(foundPerson != null)
            {
                return foundPerson.ID;
            }
            else
            {
                throw new ArgumentException($"No Person found with Name \"{firstName}\" \"{lastName}\"!");
            }
        }

    }
}
