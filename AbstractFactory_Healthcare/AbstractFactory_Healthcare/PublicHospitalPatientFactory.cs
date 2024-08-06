using System.Collections.Generic;

namespace AbstractFactory_Healthcare
{
    public class PublicHospitalPatientFactory : IPatientFactory
    {
        private List<Patient> _patients = new List<Patient>();

        public Patient CreatePatient(string name, string surname, int age)
        {
            var patient = new Patient(name, surname, age);
            _patients.Add(patient);
            return patient;
        }

        public void DeletePatient(Patient patient)
        {
            _patients.Remove(patient);
        }

        public List<Patient> GetPatients()
        {
            return _patients;
        }
    }
}