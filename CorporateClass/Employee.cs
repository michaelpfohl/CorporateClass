using System;
using System.Collections.Generic;
using System.Text;

namespace CorporateClass
{
    class Employee
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }

        public Employee(string name, string title)
        {
            Name = name;
            Title = title;
            StartDate = DateTime.Now;
        }
    }
}
