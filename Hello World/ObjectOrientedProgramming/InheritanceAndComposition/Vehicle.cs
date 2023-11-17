using System;

namespace ObjectOrientedProgramming.InheritanceAndComposition
{
    public class Vehicle
    {
        //? Private fields
        private readonly string _registrationNumber;

        //?Constructors:
        // public Vehicle()
        // {
        //     Console.WriteLine("Vehicle is being initialized");
        // }

        public Vehicle(string registrationNumber)
        {
            _registrationNumber = registrationNumber;
            Console.WriteLine("Vehicle is being initialized. {0}", registrationNumber);
        }
    }
}