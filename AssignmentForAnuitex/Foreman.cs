using System;

namespace AssignmentForAnuitex
{
    public class Foreman : Employee
    {
        public Foreman(int experiance, string name, string surname, string midlName) : base(experiance, name, surname, midlName)
        {
        }
        public override void Work()
        {
            Console.WriteLine("Purchase of materials");
        }

        public void CheckingWorkers()
        {
            Console.WriteLine("Workers check progress messages");
        }
    }
}
