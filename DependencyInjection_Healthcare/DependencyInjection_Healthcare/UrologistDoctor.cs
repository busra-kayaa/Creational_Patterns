using System;

namespace DependencyInjection_Healthcare
{
    internal class UrologistDoctor : IDoctor
    {
        public string FirstName { get; }
        public string LastName { get; }

        public UrologistDoctor(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public void Diagnose()
        {
            Console.WriteLine($"Dr. {FirstName} {LastName} Üroloji'de teşhis koyuyor...");
        }

        public void PrescribeMedication()
        {
            Console.WriteLine($"Dr. {FirstName} {LastName} Üroloji hastasına ilaç yazıyor...");
        }
    }
}