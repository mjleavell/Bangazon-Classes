using System;
using System.Collections.Generic;

namespace Bangazon_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public class BrandNewConsultingCompany
        {
            // 1. Create a class that contains information about employees of a company and define methods to get/set employee name, job title, and start date.
            // 2. Consider the concept of aggregation, and modify the Company class so that you assign employees to a company.
            // 3. In the Main method, create a company, and three employees, and then assign the employees to the company.
            // 4. Update the Company class to write the name of each employee to the console.Consider a method named ListEmployees().

            /*
                Some readonly properties
            */
            public string Name { get; set; }
            public DateTime CreatedOn { get; set; }

            // Create a property for holding a list of current employees
            public List<string> Employees { get; set; }

            /*
                Create a constructor method that accepts two arguments:
                    1. The name of the company
                    2. The date it was created

                The constructor will set the value of the public properties
            */
            public BrandNewConsultingCompany(string companyName, DateTime createdOn)
            {
                Name = companyName;
                CreatedOn = createdOn;
            }

            // Create a method that allows external code to add an employee
            public void AddEmployee(string employee)
            {
                Employees.Add(employee);
            }

            // Create a method that allows external code to remove an employee
            public void RemoveEmployee(string employee)

            {
                Employees.Remove(employee);
            }

        }

    }

}