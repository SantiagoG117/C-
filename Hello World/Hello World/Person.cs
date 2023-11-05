using System;

// Name space: Container for related classes
namespace Fundamentals
{
    public class Person
    {
        // Attributes
        public String FirstName;
        public string LastName;
        public int Age;

        //Public methods
        public void Introduce()
        {
            Console.WriteLine("My name is " + FirstName + " " + LastName);
        }

    }
}
