namespace Builder_Healthcare
{
    internal class Patient
    {
        public string Name { get; }
        public string Surname { get; }
        public int Age { get; }

        public Patient(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }

        public override string ToString()
        {
            return $"İsim: {Name}, Soyisim: {Surname}, Yaş: {Age}";
        }
    }
}