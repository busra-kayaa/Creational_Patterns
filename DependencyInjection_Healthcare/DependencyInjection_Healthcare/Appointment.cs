using System;

namespace DependencyInjection_Healthcare
{
    internal class Appointment : IAppointment
    {
        private readonly IDoctor _doctor;

        public Appointment(IDoctor doctor)
        {
            _doctor = doctor;
        }

        public void Create(string patientFirstName, string patientLastName)
        {
            Console.WriteLine($"Hasta {patientFirstName} {patientLastName} için Dr. {_doctor.FirstName} {_doctor.LastName} ile randevu oluşturuluyor...");
            _doctor.Diagnose();
            _doctor.PrescribeMedication();
        }

        public void FollowUp(string patientFirstName, string patientLastName)
        {
            Console.WriteLine($"Hasta {patientFirstName} {patientLastName} için Dr. {_doctor.FirstName} {_doctor.LastName} ile takip randevusu yapılıyor...");
            _doctor.Diagnose();
        }
    }
}