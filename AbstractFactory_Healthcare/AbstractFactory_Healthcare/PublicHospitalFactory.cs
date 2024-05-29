namespace AbstractFactory_Healthcare
{
    public class PublicHospitalFactory : IHealthcareFactory
    {
        public IDoctorFactory CreateDoctorFactory()
        {
            return new PublicHospitalDoctorFactory();
        }

        public IPatientFactory CreatePatientFactory()
        {
            return new PublicHospitalPatientFactory();
        }

        public IAppointmentFactory CreateAppointmentFactory()
        {
            return new AppointmentFactory(); // Standart randevu fabrikası kullanılıyor
        }
    }
}