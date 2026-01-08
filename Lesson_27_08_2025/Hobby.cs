using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_27_08_2025
{
    internal class Hobby
    {

        private string Type;
        private int TimesPerWeek;
        public Hobby(string type, int timesPerWeek) 
        { 
            Type = type;
            TimesPerWeek = timesPerWeek;
        }

        public void PrintInfo()
        {
            Console.WriteLine("---");
            Console.WriteLine($"Hobby: {Type}");
            Console.WriteLine($"Repetitions per Week: {TimesPerWeek}");
            Console.WriteLine("---");
        }
    }
}
