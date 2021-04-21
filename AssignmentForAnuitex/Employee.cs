namespace AssignmentForAnuitex
{
    public abstract class Employee
    {
        public int Experiance { get; }
        public string Name { get; }
        public string Surname { get; }
        public string MidlName { get; }

        public Employee(int experiance, string name, string surname, string midlName)
        {
            Experiance = experiance;
            Name = name;
            Surname = surname;
            MidlName = midlName;
        }

        public abstract void Work();
    }
}
