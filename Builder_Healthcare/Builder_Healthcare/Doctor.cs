namespace Builder_Healthcare
{
    internal class Doctor
    {
        public string Name { get; }
        public string Surname { get; }
        public string Specialty { get; }

        public Doctor(string name, string surname, string specialty)
        {
            Name = name;
            Surname = surname;
            Specialty = specialty;
        }

        public override string ToString()
        {
            return $"İsim: {Name}, Soyisim: {Surname}, Uzmanlık: {Specialty}";
        }
    }
}