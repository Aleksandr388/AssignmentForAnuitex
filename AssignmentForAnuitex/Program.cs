using System;

namespace AssignmentForAnuitex
{
    class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company();

            var manager = new Manager(5, "Alex", "Nesheretnuy", "Alekseevich");

            company += manager;
            company += new Worker(5, "Alex", "Nesheretnuy", "Alekseevich");
            company += new Manager(2, "Bill", "Nesheretnuy", "Osipovich");
            company += new Foreman(3, "Alex", "Saimon", "Alekseevich");
            company += new Manager(1, "Mary", "Ivaniv", "Vadimovna");
            company += new Foreman(1, "Alex", "Kuznec", "Alekseevich");
            company += new Worker(1, "Alex", "LObanov", "Karlovich");

            var worker = new Worker(5, "Alex", "Nesheretnuy", "Alekseevich");
            var foreman = new Foreman(3, "Alex", "Saimon", "Petrovich");

            manager.Work();
            manager.GiveTask();
            foreman.Work();
            foreman.CheckingWorkers();
            worker.Work();

            Console.WriteLine("-----------------------");

            var managers = company.GetAll<Manager>();

            foreach (var item in managers)
            {
                Console.WriteLine($"Experiance: {item.Experiance}, Surname : {item.Surname}, Name: {item.Name}, Middle name {item.MidlName}");
            }

            Console.WriteLine("-----------------------");

            company.PrintAll();

            Console.WriteLine("-----------------------");
            Console.WriteLine(company.IsContains(manager));
            Console.WriteLine("-----------------------");
            Console.WriteLine("Count: " + company.GetAllCount<Worker>());

            Console.ReadLine();
        }
    }
}
