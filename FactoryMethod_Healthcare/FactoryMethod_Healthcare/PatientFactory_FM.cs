using System.Collections.Generic;

namespace FactoryMethod_Healthcare
{
    internal class PatientFactory_FM : IPatientFactory_FM
    {
        private List<Patient> patients = new List<Patient>();

        public Patient Create(string name, string surname, int age)
        {
            Patient person = new Patient(name, surname, age);
            patients.Add(person);
            return person;
        }

        public void Delete(Patient patient)
        {
            patients.Remove(patient);
        }

        public List<Patient> GetPatients()
        {
            return patients;
        }
    }
}