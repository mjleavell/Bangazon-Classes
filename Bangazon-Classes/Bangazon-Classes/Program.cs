using System;
using System.Collections.Generic;

namespace Bangazon_Classes
{
    class Program
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
                foreach(Employee employee in Employees)
                {
                    Console.WriteLine(employee.EmployeeName);
                }
            }
        }

        // static method that launches everything
        static void Main(string[] args)
        {
            Company BrandNewCompany = new Company("Brand New Congress", DateTime.Now);
            Employee marg = new Employee("marg", "junior dev", DateTime.Now);
            Employee serena = new Employee("Serena Williams", "Tennis Player", DateTime.Now);
            Employee federer = new Employee("Roger Federer", "THE GOAT", DateTime.Now);

            BrandNewCompany.AddEmployee(marg);
            BrandNewCompany.AddEmployee(serena);
            BrandNewCompany.AddEmployee(federer);

            //Console.WriteLine($"Name: {marg.EmployeeName}; Title: {marg.JobTitle}; Date: {marg.StartDate}");
            //Console.WriteLine($"Company: {BrandNewCompany.Name}; Employees: {BrandNewCompany.Employees}; Created: {BrandNewCompany.CreatedOn}");

            BrandNewCompany.ListEmployees();

            Console.ReadLine();
        }

    }

}