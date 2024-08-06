using System.Collections.Generic;

namespace AbstractFactory_Healthcare
{
    public class PublicHospitalDoctorFactory : IDoctorFactory
    {
        private List<Doctor> _doctors = new List<Doctor>();

        public Doctor CreateDoctor(string name, string surname, string specialty)
        {
            var doctor = new Doctor(name, surname, specialty);
            _doctors.Add(doctor);
            return doctor;
        }

        public void DeleteDoctor(Doctor doctor)
        {
            _doctors.Remove(doctor);
        }

        public List<Doctor> GetDoctors()
        {
            return _doctors;
        }
    }
}