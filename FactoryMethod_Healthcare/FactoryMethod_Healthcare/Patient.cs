using System;

namespace FactoryMethod_Healthcare
{
    internal class Patient : Person
    {
        public int Age { get; set; }

        public Patient(string name, string surname, int age) : base(name, surname)
        {
            Age = age;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Hasta: {Name} {Surname}, Yaş: {Age}");
        }
    }
}