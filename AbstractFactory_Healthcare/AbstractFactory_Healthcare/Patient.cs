using System;

namespace AbstractFactory_Healthcare
{
    public class Patient
    {
        public string Name { get; }
        public string Surname { get; }
        public int Age { get; }

        public Patient(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"İsim: {Name}, Soyismi: {Surname}, Yaş: {Age}");
        }
    }
}