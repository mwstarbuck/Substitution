using System;
using System.Collections.Generic;
using System.Text;

namespace SubstitutionLibrary
{
    public class CEO :  Employee
    {
        public override void CalculaterPerHourRate(int rank)
        {
            decimal baseAmount = 150M;

            Salary = baseAmount + rank;
        }

        public virtual void AssignManager(Employee manager)
        {
            throw new InvalidOperationException("The CEO has no manager.");
        }

        public void GeneratePerformanceReview()
        {
            // Simulates reviewing of direct report
            Console.WriteLine("I'm reviewing the yearly performance of a direct report.");
        }

        public void FireSomeone()
        {
            Console.WriteLine("You're fired!");
        }
    }
}
