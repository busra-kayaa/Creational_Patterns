using System;
using System.Collections.Generic;
using System.Security.Policy;

namespace FactoryMethod_Healthcare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDoctorFactory_FM doctorFactory = new DoctorFactory_FM();
            Doctor doctor1 = doctorFactory.Create("Dr. Büşra", "KAYA", "Dahiliye");
            Doctor doctor2 = doctorFactory.Create("Dr. Selen", "KORKMAZ", "Cerrahi");
            Doctor doctor3 = doctorFactory.Create("Dr. Esen", "AKARSU", "Genel Cerrahi");

            IPatientFactory_FM patientFactory = new PatientFactory_FM();
            Patient patient1 = patientFactory.Create("Mustafa", "AK", 35);
            Patient patient2 = patientFactory.Create("Muhammet Ali", "ÇELİK", 21);
            Patient patient3 = patientFactory.Create("Seyit", "KIRK",43);
            Patient patient4 = patientFactory.Create("Tuna", "HAN", 52);

            List<Doctor> doctors =
                new List<Doctor> { doctor1, doctor2, doctor3 };
            List<Patient> patients =
                new List<Patient> { patient1, patient2, patient3, patient4 };

            IAppointmentFactory_FM appointmentFactory = new AppointmentFactory_FM();
            Appointment appointment1 = appointmentFactory.Create(doctor1, patient1, DateTime.Now.AddHours(24));
            Appointment appointment2 = appointmentFactory.Create(doctor2, patient2, DateTime.Now.AddHours(48));

            PrintDoctors(doctors);
            PrintPatients(patients);

            Console.WriteLine("\nRandevular:");
            Console.WriteLine(appointment1.ToString());
            Console.WriteLine(appointment2.ToString());

            doctorFactory.Delete(doctor1);
            Console.WriteLine("\nSilindikten Sonraki Doktorlar:");
            PrintDoctors(doctorFactory.GetDoctors());

            patientFactory.Delete(patient3);
            Console.WriteLine("\nSilindikten Sonraki Hastalar:");
            PrintPatients(patientFactory.GetPatients());

            appointment1.Cancel();
            Console.WriteLine("\nRandevu iptal edildi:");
            Console.WriteLine(appointment1.ToString());
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
