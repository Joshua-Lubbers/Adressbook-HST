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
            
            People.Add(newPerson);
        }

    }
}
