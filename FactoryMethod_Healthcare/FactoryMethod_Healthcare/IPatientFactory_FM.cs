using System.Collections.Generic;

namespace FactoryMethod_Healthcare
{
    internal interface IPatientFactory_FM
    {
        Patient Create(string name, string surname, int age);
        void Delete(Patient patient);
        List<Patient> GetPatients();

    }
}