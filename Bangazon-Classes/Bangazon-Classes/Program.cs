using System;
using System.Collections.Generic;

namespace Bangazon_Classes
{
    class Program
    {
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