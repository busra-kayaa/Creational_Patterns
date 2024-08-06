using System;

namespace DependencyInjection_Healthcare
{
    internal class GeneralSurgeryDoctor : IDoctor
    {
        public string FirstName { get; }
        public string LastName { get; }

        public GeneralSurgeryDoctor(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public void Diagnose()
        {
            Console.WriteLine($"Dr. {FirstName} {LastName} Genel Cerrahide teşhis koyuyor...");
        }

        public void PrescribeMedication()
        {
            Console.WriteLine($"Dr. {FirstName} {LastName} Genel Cerrahi hastasına ilaç yazıyor...");
        }
    }
}