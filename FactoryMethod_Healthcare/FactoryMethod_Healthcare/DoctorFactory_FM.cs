using System.Collections.Generic;

namespace FactoryMethod_Healthcare
{
    internal class DoctorFactory_FM : IDoctorFactory_FM
    {
        private List<Doctor> doctors = new List<Doctor>();

        public Doctor Create(string name, string surname, string department)
        {
            Doctor person = new Doctor(name, surname, department);
            doctors.Add(person);
            return person;
        }

        public void Delete(Doctor doctor)
        {
            doctors.Remove(doctor);
        }

        public List<Doctor> GetDoctors()
        {
            return doctors;
        }
    }
}