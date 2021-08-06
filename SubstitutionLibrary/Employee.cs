using System;
using System.Collections.Generic;
using System.Text;

namespace SubstitutionLibrary
{
    public class Employee : BaseEmployee, IManaged
    {

        public IEmployee Manager { get; set; } = null;


        public virtual void AssignManager(IEmployee manager)
        {
            // Simulation of other tasks being performed here
            // otherwise this should be a property statement, not a method
            Manager = manager;
        }

    }
}
