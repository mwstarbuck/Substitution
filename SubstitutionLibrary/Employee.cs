using System;
using System.Collections.Generic;
using System.Text;

namespace SubstitutionLibrary
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Employee Manager { get; set; } = null;
        public decimal Salary { get; set; }

        public virtual void AssignManager(Employee manager)
        {
            // Simulation of other tasks being performed here
            // otherwise this should be a property statement, not a method
            Manager = manager;
        }

        public virtual void CalculaterPerHourRate(int rank)
        {
            decimal baseAmount = 12.50M;

            Salary = baseAmount + (rank * 2);
        }
    }
}
