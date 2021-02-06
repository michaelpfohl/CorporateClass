using System;
using System.Collections.Generic;
using System.Text;

namespace CorporateClass
{
    public class Company
    {
        // Some properties
        public string Name { get; }
        public DateTime CreatedOn { get; }

        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties
        */
        public Company(string name, DateTime createdOn)
        {
            Name = name;
            CreatedOn = createdOn;
        }

        // Create a private property for holding a collection of current employees
        private List<Employee> employees { get; set; } = new List<Employee>();

        // Create a method that allows a caller to add an employee
        public void AddEmployee(string employeeName, string employeeTitle) => employees.Add(new Employee(employeeName, employeeTitle));
        // Create a method that allows a caller to remove an employee
        public void RemoveEmployee(string employeeName) => employees.RemoveAll(employee => employee.Name == employeeName);
        // Create a method that allows a caller to retrieve the list of employees
        public void ListEmployees() => employees.ForEach(employee => Console.WriteLine(employee.Name));
    }
}
