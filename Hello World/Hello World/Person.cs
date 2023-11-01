using System;

// Name space: Container for related classes
namespace Hello_World
{
    public class Person
    {
        // Attributes
        public String FirstName;
        public string LastName;

        //Public methods
        public void Introduce()
        {
            Console.WriteLine("My name is " + FirstName + " " + LastName);
        }

    }
}
