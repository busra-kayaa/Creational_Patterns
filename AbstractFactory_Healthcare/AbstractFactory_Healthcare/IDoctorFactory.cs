using System.Collections.Generic;

namespace AbstractFactory_Healthcare
{
    public interface IDoctorFactory
    {
        Doctor CreateDoctor(string name, string surname, string specialty);
        void DeleteDoctor(Doctor doctor);
        List<Doctor> GetDoctors();
    }
}