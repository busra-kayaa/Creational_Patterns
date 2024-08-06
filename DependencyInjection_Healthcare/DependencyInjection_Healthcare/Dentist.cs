using System;

namespace DependencyInjection_Healthcare
{
    internal class Dentist : IDoctor
    {
        public string FirstName { get; }
        public string LastName { get; }

        public Dentist(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public void Diagnose()
        {
            Console.WriteLine($"Dr. {FirstName} {LastName} Diş sorunlarını teşhis ediyor...");
        }

        public void PrescribeMedication()
        {
            Console.WriteLine($"Dr. {FirstName} {LastName} Diş hastasına ilaç yazıyor...");
        }
    }
}