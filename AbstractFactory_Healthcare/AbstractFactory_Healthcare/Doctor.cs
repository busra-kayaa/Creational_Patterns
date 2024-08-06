using System;

namespace AbstractFactory_Healthcare
{
    public class Doctor
    {
        public string Name { get; }
        public string Surname { get; }
        public string Specialty { get; }

        public Doctor(string name, string surname, string specialty)
        {
            Name = name;
            Surname = surname;
            Specialty = specialty;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"İsim: {Name}, Soyisim: {Surname}, Uzmanlık: {Specialty}");
        }
    }
}