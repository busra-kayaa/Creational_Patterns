using System;

namespace FactoryMethod_Healthcare
{
    internal class Doctor : Person
    {
        public string Department { get; set; }

        public Doctor(string name, string surname, string department) : base(name, surname)
        {
            Department = department;
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"Doktor: {Name} {Surname}, Departman: {Department}");
        }
    }
}