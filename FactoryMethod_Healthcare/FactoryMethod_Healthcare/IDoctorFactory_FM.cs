using System.Collections.Generic;

namespace FactoryMethod_Healthcare
{
    internal interface IDoctorFactory_FM
    {
        Doctor Create(string name, string surname, string department);
        void Delete(Doctor doctor);
        List<Doctor> GetDoctors();

    }
}