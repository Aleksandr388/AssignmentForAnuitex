using System.Collections.Generic;

namespace AssignmentForAnuitex
{
    public class Company
    {
        public List<Employee> Employees { get; }

        public Company()
        {
            Employees = new List<Employee>();
        }

        public static Company operator +(Company company, Employee employee)
        {
            company.Employees.Add(employee);
            return company;
        }

        public static Company operator -(Company company, Employee employee)
        {
            company.Employees.Remove(employee);
            return company;
        }
    }
}
