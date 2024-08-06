using System;

namespace FactoryMethod_Healthcare
{
    internal class AppointmentFactory_FM : IAppointmentFactory_FM
    {
        public Appointment Create(Doctor doctor, Patient patient, DateTime appointmentTime)
        {
            return new Appointment(doctor, patient, appointmentTime);
        }       
    }
}