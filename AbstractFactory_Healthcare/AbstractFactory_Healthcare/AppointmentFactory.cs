using System;

namespace AbstractFactory_Healthcare
{
    public class AppointmentFactory :IAppointmentFactory
    {
        public Appointment CreateAppointment(Doctor doctor, Patient patient, DateTime appointmentDate)
        {
            return new Appointment(doctor, patient, appointmentDate);
        }
    }
}