using System;
using System.Collections.Generic;
using System.Linq;

namespace AssignmentForAnuitex
{
    static class MyExtention
    {
        public static bool IsContains(this Company company, Employee employee)
        {
            return company.Employees.Contains(employee);
        }

        public static IEnumerable<T> GetAll<T>(this Company company) where T : Employee
        {
            return company.Employees.OfType<T>().ToList();
        }

        public static int GetAllCount<T>(this Company company) where T : Employee
        {
            return company.GetAll<T>().Count();
        }

        public static void PrintAll(this Company company)
        {
            foreach (var item in company.Employees)
            {
                Console.WriteLine($"Experiance: {item.Experiance}, Surname : {item.Surname}, Name: {item.Name}, Middle name {item.MidlName}");
            }
        }
    }
}
