using System.Collections.Generic;

namespace AbstractFactory_Healthcare
{
    public interface IPatientFactory
    {
        Patient CreatePatient(string name, string surname, int age);
        void DeletePatient(Patient patient);
        List<Patient> GetPatients();
    }
}