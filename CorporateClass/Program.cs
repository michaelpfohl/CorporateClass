using System;
using System.Collections.Generic;

namespace CorporateClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var lyft = new Company("Lyft", DateTime.Today);
            lyft.AddEmployee("Michael Pfohl", "Software Engineer");
            lyft.AddEmployee("Liz Barnes", "Software Engineer");
            lyft.AddEmployee("Shrek Ogre", "Onion Salesman");
            lyft.RemoveEmployee("Shrek Ogre");
            lyft.ListEmployees();
        }
    }
}
