using System;
using System.Collections.Generic;
using System.Text;

namespace Bangazon_Classes
{
    public class Company
    {
        public string Name { get; set; }
        public DateTime CreatedOn { get; set; }

        // Create a property for holding a list of current employees
        public List<Employee> Employees { get; set; }

        public Company(string companyName, DateTime createdOn)
        {
            Name = companyName;
            CreatedOn = createdOn;
            Employees = new List<Employee>();
        }

        // Create a method that allows external code to add an employee
        public void AddEmployee(Employee newEmployee)
        {
            Employees.Add(newEmployee);
        }

        // Create a method that allows external code to remove an employee
        public void RemoveEmployee(Employee firedEmployee)
        {
            Employees.Remove(firedEmployee);
        }

        // Create a method to write the name of each employee to the console
        public void ListEmployees()
        {
            foreach (Employee employee in Employees)
            {
                Console.WriteLine(employee.EmployeeName);
            }
        }
    }
}
