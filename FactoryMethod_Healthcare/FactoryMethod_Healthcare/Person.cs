using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_Healthcare
{
    internal class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public Person(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
        public virtual void PrintInfo()
        {
            Console.WriteLine($"Kişi: {Name} {Surname}");
        }
    }
}
