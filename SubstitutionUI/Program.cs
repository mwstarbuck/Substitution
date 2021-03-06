using SubstitutionLibrary;
using System;

namespace SubstitutionUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager accountingVP = new Manager();

            accountingVP.FirstName = "Bob";
            accountingVP.LastName = "Ross";
            accountingVP.CalculaterPerHourRate(4);

            Employee emp = new Employee();

            emp.FirstName = "Mike";
            emp.LastName = "Starbuck";
            emp.AssignManager(accountingVP);
            emp.CalculaterPerHourRate(2);

            Console.WriteLine($"{emp.FirstName}'s salary is {emp.Salary}/hour.");
            Console.ReadLine();

        }
    }
}
