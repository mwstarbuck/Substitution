using System;
namespace SubstitutionLibrary
{
    // Use abstract class b/c you never want to use this base class directly
    public abstract class BaseEmployee : IEmployee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }

        public virtual void CalculaterPerHourRate(int rank)
        {
            decimal baseAmount = 12.50M;

            Salary = baseAmount + (rank * 2);
        }
    }
}
