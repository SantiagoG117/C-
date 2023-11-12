using System;

namespace ObjectOrientedProgramming.Classes
{
    /// <summary>
    ///Naming conventions:
    ///
    /// Classes and their methods:
    ///     PascalCase: First letter of every word is Uppercase
    ///
    /// Fields:
    ///     _camelCase prefixed with an underline: The first letter of the first word is lower case but the first letter of the rest of the words will be uppercase
    ///
    /// Properties (Pascal):
    ///     A class member that provides and encapsulates a getter/setter for accessing a field
    ///     As a best practice we must declare fields as private and create public properties to provide access to them
    /// 
    /// </summary>
    public class PersonTraditionalClass
    {
        //? Auto-properties: Properties with no logic. Internally, the C# compiler creates a private field for us 
        //? called _birthdate with a getter and a setter. If we don't wish to provide a setter for a given fied, we can
        //? set the setter as private
        public DateTime Birthdate { get; private set; }
        public string Name { get; set; }
        
        //?Constructor
        public PersonTraditionalClass(DateTime birthdate)
        {
            Birthdate = birthdate;
        }
        
        //?Calculated properties: Properties with some logic
        public int age
        {
            get
            {
                TimeSpan timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days / 365;

                return years;
            }
        }
        
        
    }
}