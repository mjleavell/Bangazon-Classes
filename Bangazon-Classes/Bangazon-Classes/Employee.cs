using System;
using System.Collections.Generic;
using System.Text;

namespace Bangazon_Classes
{
    class Employee
    {
        private string EmployeeName { get; set; }
        private string JobTitle { get; set; }
        private DateTime StartDate { get; set; }

        public Employee(string employeeName, string jobTitle, DateTime startDate)
        {
            EmployeeName = employeeName;
            JobTitle = jobTitle;
            StartDate = startDate;
        }
    }
}