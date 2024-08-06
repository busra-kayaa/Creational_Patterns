using System;

namespace Builder_Healthcare
{
    internal class ClinicBuilder
    {
        private Clinic _clinic;

        public ClinicBuilder()
        {
            _clinic = new Clinic();
        }

        public ClinicBuilder AddDoctor(Doctor doctor)
        {
            _clinic.AddDoctor(doctor);
            return this;
        }

        public ClinicBuilder AddPatient(Patient patient)
        {
            _clinic.AddPatient(patient);
            return this;
        }

        public ClinicBuilder AddAppointment(Appointment appointment)
        {
            _clinic.AddAppointment(appointment);
            return this;
        }

        public Clinic Build()
        {
            return _clinic;
        }
    }
}