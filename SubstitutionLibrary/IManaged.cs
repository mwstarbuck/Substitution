using System;
namespace SubstitutionLibrary
{
    public interface IManaged : IEmployee
    {
        IEmployee Manager { get; set; }

        void AssignManager(IEmployee manager);
    }
}
