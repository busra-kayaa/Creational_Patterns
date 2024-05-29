using System;

namespace AbstractFactory_Healthcare
{
    public class Appointment
    {
        public Doctor Doctor { get; }
        public Patient Patient { get; }
        public DateTime AppointmentDate { get; }
        public bool IsCancelled { get; private set; }

        public Appointment(Doctor doctor, Patient patient, DateTime appointmentDate)
        {
            Doctor = doctor;
            Patient = patient;
            AppointmentDate = appointmentDate;
            IsCancelled = false;
        }

        public void Cancel()
        {
            IsCancelled = true;
        }

        public override string ToString()
        {
            return $"Doktor: {Doctor.Name} {Doctor.Surname}, Hasta: {Patient.Name} {Patient.Surname}, Randevu Tarihi: {AppointmentDate}";
        }
    }
}