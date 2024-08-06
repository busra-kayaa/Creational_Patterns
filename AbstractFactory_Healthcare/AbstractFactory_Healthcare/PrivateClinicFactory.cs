namespace AbstractFactory_Healthcare
{
    public class PrivateClinicFactory : IHealthcareFactory
    {
        public IDoctorFactory CreateDoctorFactory()
        {
            return new PrivateClinicDoctorFactory();
        }

        public IPatientFactory CreatePatientFactory()
        {
            return new PrivateClinicPatientFactory();
        }

        public IAppointmentFactory CreateAppointmentFactory()
        {
            return new AppointmentFactory(); // Standart randevu fabrikası kullanılıyor
        }
    }
}