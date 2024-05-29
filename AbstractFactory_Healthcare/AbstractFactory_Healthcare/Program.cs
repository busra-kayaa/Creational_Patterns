using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_Healthcare
{
    public class Program
    {
        static void Main(string[] args)
        {
            IHealthcareFactory privateClinicFactory = new PrivateClinicFactory();
            IHealthcareFactory publicHospitalFactory = new PublicHospitalFactory();

            var privateClinicDoctorFactory = privateClinicFactory.CreateDoctorFactory();
            var privateClinicPatientFactory = privateClinicFactory.CreatePatientFactory();

            var publicHospitalDoctorFactory = publicHospitalFactory.CreateDoctorFactory();
            var publicHospitalPatientFactory = publicHospitalFactory.CreatePatientFactory();

            Doctor doctor1 = privateClinicDoctorFactory.CreateDoctor("Dr. Büşra", "KAYA", "Dahiliye");
            Doctor doctor2 = privateClinicDoctorFactory.CreateDoctor("Dr. Selen", "KORKMAZ", "Cerrahi");

            Doctor doctor3 = publicHospitalDoctorFactory.CreateDoctor("Dr. Esen", "AKARSU", "Genel Cerrahi");

            Patient patient1 = privateClinicPatientFactory.CreatePatient("Mustafa", "AK", 35);
            Patient patient2 = privateClinicPatientFactory.CreatePatient("Muhammet Ali", "ÇELİK", 21);

            Patient patient3 = publicHospitalPatientFactory.CreatePatient("Seyit", "KIRK", 43);
            Patient patient4 = publicHospitalPatientFactory.CreatePatient("Tuna", "HAN", 52);

            List<Doctor> privateClinicDoctors = privateClinicDoctorFactory.GetDoctors();
            List<Doctor> publicHospitalDoctors = publicHospitalDoctorFactory.GetDoctors();

            List<Patient> privateClinicPatients = privateClinicPatientFactory.GetPatients();
            List<Patient> publicHospitalPatients = publicHospitalPatientFactory.GetPatients();

            AppointmentFactory appointmentFactory = new AppointmentFactory(); // Standart randevu fabrikası kullanılıyor

            Appointment appointment1 = appointmentFactory.CreateAppointment(doctor1, patient1, DateTime.Now.AddHours(24));
            Appointment appointment2 = appointmentFactory.CreateAppointment(doctor2, patient2, DateTime.Now.AddHours(48));
            Appointment appointment3 = appointmentFactory.CreateAppointment(doctor3, patient3, DateTime.Now.AddHours(72));

            Console.WriteLine("Özel Poliklinik Doktorlar:");
            PrintDoctors(privateClinicDoctors);

            Console.WriteLine("\nKamu Hastanesi Doktorlar:");
            PrintDoctors(publicHospitalDoctors);

            Console.WriteLine("\nÖzel Poliklinik Hastalar:");
            PrintPatients(privateClinicPatients);

            Console.WriteLine("\nKamu Hastanesi Hastalar:");
            PrintPatients(publicHospitalPatients);

            Console.WriteLine("\nRandevular:");
            Console.WriteLine(appointment1.ToString());
            Console.WriteLine(appointment2.ToString());
            Console.WriteLine(appointment3.ToString());
        }
        static void PrintDoctors(List<Doctor> doctors)
        {
            Console.WriteLine("\nDoktorlar:");
            foreach (var doctor in doctors)
            {
                doctor.PrintInfo();
            }
        }

        static void PrintPatients(List<Patient> patients)
        {
            Console.WriteLine("\nHastalar:");
            foreach (var patient in patients)
            {
                patient.PrintInfo();
            }
        }

    }
}
