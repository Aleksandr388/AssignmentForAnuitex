using System;

namespace AssignmentForAnuitex
{
    public class Manager : Employee
    {
        public Manager(int experiance, string name, string surname, string midlName) : base(experiance, name, surname, midlName)
        {
        }
        public override void Work()
        {
            Console.WriteLine("Collecting orders");
        }

        public void GiveTask()
        {
            Console.WriteLine("Task issuance messages");
        }
    }
}
