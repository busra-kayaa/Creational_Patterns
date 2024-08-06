using System;

namespace DependencyInjection_Healthcare
{
    internal class InternalMedicineDoctor : IDoctor
    {
        public string FirstName { get; }
        public string LastName { get; }

        public InternalMedicineDoctor(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public void Diagnose()
        {
            Console.WriteLine($"Dr. {FirstName} {LastName} Dahiliye'de teşhis koyuyor...");
        }

        public void PrescribeMedication()
        {
            Console.WriteLine($"Dr. {FirstName} {LastName} Dahiliye hastasına ilaç yazıyor...");
        }
    }
}