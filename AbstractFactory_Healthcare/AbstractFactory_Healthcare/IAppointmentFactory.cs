using System;

namespace AbstractFactory_Healthcare
{
    public interface IAppointmentFactory
    {
        Appointment CreateAppointment(Doctor doctor, Patient patient, DateTime appointmentDate);

    }
}