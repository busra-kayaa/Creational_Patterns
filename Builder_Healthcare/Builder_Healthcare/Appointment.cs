using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Healthcare
{
    internal class Appointment
    {
        public Doctor Doctor { get; }
        public Patient Patient { get; }
        public DateTime AppointmentDate { get; }

        public Appointment(Doctor doctor, Patient patient, DateTime appointmentDate)
        {
            Doctor = doctor;
            Patient = patient;
            AppointmentDate = appointmentDate;
        }

        public override string ToString()
        {
            return $"Doktor: {Doctor}, Hasta: {Patient}, Randevu Tarihi: {AppointmentDate}";
        }
    }
}
