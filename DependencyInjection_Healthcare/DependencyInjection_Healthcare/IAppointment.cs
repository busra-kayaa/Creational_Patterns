namespace DependencyInjection_Healthcare
{
    internal interface IAppointment
    {
        void Create(string patientFirstName, string patientLastName);
        void FollowUp(string patientFirstName, string patientLastName);
    }
}