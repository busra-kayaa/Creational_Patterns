using System;

namespace FactoryMethod_Healthcare
{
    internal interface IAppointmentFactory_FM
    {
        Appointment Create(Doctor doctor, Patient patient, DateTime appointmentTime);
    }
}