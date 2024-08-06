namespace DependencyInjection_Healthcare
{
    internal interface IDoctor
    {
        string FirstName { get; }
        string LastName { get; }
        void Diagnose();
        void PrescribeMedication();
    }
}