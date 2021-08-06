using System;
using System.Collections.Generic;
using System.Text;

namespace SubstitutionLibrary
{
    public class Manager : Employee, IManager
    {
        public override void CalculaterPerHourRate(int rank)
        {
            decimal baseAmount = 19.75M;

            Salary = baseAmount + (rank * 4);
        }

        public void GeneratePerformanceReview()
        {
            // Simulates reviewing of direct report
            Console.WriteLine("I'm reviewing the yearly performance of a direct report.");
        }
    }
}
