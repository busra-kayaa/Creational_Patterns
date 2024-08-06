using System;

namespace FactoryMethod_Healthcare
{
    internal class Appointment
    {
        public Doctor Doctor { get; }
        public Patient Patient { get; }
        public DateTime AppointmentTime { get; }
        public bool Cancelled { get; private set; }

        public Appointment(Doctor doctor, Patient patient, DateTime appointmentTime)
        {
            Doctor = doctor;
            Patient = patient;
            AppointmentTime = appointmentTime;
            Cancelled = false;
        }

        public void Cancel()
        {
            Cancelled = true;
        }

        public override string ToString()
        {
            string status = Cancelled ? "(İptal Edildi)" : "";
            return $"Randevu Tarihi: {AppointmentTime}, {Doctor.Name} {Doctor.Surname}, {Patient.Name} {Patient.Surname} {status}";
        }
    }
}