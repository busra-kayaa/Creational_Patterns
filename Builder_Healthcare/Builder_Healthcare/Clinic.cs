using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Healthcare
{
    internal class Clinic
    {
        private List<Doctor> _doctors;
        private List<Patient> _patients;
        private List<Appointment> _appointments;

        public Clinic()
        {
            _doctors = new List<Doctor>();
            _patients = new List<Patient>();
            _appointments = new List<Appointment>();
        }

        public void AddDoctor(Doctor doctor)
        {
            _doctors.Add(doctor);
        }

        public void AddPatient(Patient patient)
        {
            _patients.Add(patient);
        }

        public void AddAppointment(Appointment appointment)
        {
            _appointments.Add(appointment);
        }

        public void PrintDoctors()
        {
            Console.WriteLine("\nDoktorlar:");
            foreach (var doctor in _doctors)
            {
                Console.WriteLine(doctor);
            }
        }

        public void PrintPatients()
        {
            Console.WriteLine("\nHastalar:");
            foreach (var patient in _patients)
            {
                Console.WriteLine(patient);
            }
        }

        public void PrintAppointments()
        {
            Console.WriteLine("\nRandevular:");
            foreach (var appointment in _appointments)
            {
                Console.WriteLine(appointment);
            }
        }
    }
}
