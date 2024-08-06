namespace AbstractFactory_Healthcare
{
    public interface IHealthcareFactory
    {
        IDoctorFactory CreateDoctorFactory();
        IPatientFactory CreatePatientFactory();
        IAppointmentFactory CreateAppointmentFactory();
    }
}