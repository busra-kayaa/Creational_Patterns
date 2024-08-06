using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection_Healthcare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDoctor doctor = new GeneralSurgeryDoctor("Ahmet", "Yılmaz");
            IAppointment appointment = new Appointment(doctor);
            appointment.Create("Ali", "Kaya");
            appointment.FollowUp("Ali", "Kaya");
            Console.WriteLine();

            IDoctor doctor1 = new InternalMedicineDoctor("Ayşe", "Demir");
            IAppointment appointment1 = new Appointment(doctor1);
            appointment1.Create("Fatma", "Yıldız");
            appointment1.FollowUp("Fatma", "Yıldız");
            Console.WriteLine();

            IDoctor doctor2 = new UrologistDoctor("Mehmet", "Şahin");
            IAppointment appointment2 = new Appointment(doctor2);
            appointment2.Create("Ahmet", "Öztürk");
            appointment2.FollowUp("Ahmet", "Öztürk");
            Console.WriteLine();

            IDoctor doctor3 = new Dentist("Zeynep", "Çelik");
            IAppointment appointment3 = new Appointment(doctor3);
            appointment3.Create("Ayşe", "Kara");
            appointment3.FollowUp("Ayşe", "Kara");
        }
    }
}
