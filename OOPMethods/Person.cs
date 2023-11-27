using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPMethods
{
    internal class Person
    {
        static Person() 
        {
            Console.Write("PopulationCount: ");
            string? populationCountAsText = Console.ReadLine();
            int populationCount = Convert.ToInt32(populationCountAsText);
            Person.PopulationCount = populationCount;

        }

        public Person() : this(string.Empty, string.Empty)
        {
            return;
        }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        ~Person()
        {
            FirstName = null;
            LastName = null;
        }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public static int PopulationCount { get; private set; }
    }
}
