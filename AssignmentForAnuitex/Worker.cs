using System;

namespace AssignmentForAnuitex
{
    public class Worker : Employee
    {
        public Worker(int experiance, string name, string surname, string midlName) : base(experiance, name, surname, midlName)
        {
        }
        public override void Work()
        {
            Console.WriteLine("Product creation");
        }
    }
}
