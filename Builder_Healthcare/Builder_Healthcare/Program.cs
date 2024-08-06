using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Healthcare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var doctor1 = new Doctor("Dr. Büşra", "KAYA", "Dahiliye");
            var doctor2 = new Doctor("Dr. Selen", "KORKMAZ", "Cerrahi");

            var patient1 = new Patient("Mustafa", "AK", 35);
            var patient2 = new Patient("Muhammet Ali", "ÇELİK", 21);

            var appointment1 = new Appointment(doctor1, patient1, DateTime.Now.AddHours(24));
            var appointment2 = new Appointment(doctor2, patient2, DateTime.Now.AddHours(48));

            var clinicBuilder = new ClinicBuilder();
            var clinic = clinicBuilder.AddDoctor(doctor1)
                                      .AddDoctor(doctor2)
                                      .AddPatient(patient1)
                                      .AddPatient(patient2)
                                      .AddAppointment(appointment1)
                                      .AddAppointment(appointment2)
                                      .Build();

            clinic.PrintDoctors();
            clinic.PrintPatients();
            clinic.PrintAppointments();
        }
    }
}
