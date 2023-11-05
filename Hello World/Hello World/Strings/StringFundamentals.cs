using System;
using System.Reflection;


namespace Fundamentals.Strings
{
    public class StringFundamentals
    {
        //Attributes
        /// <summary>
        /// All primitive types and classes are mapped to a typed in the .NET framework 
        /// 
        /// String -> String class in the .NET framework (If we want to use this class, we must import the System namespace)
        /// string -> Keyword in C#
        /// 
        /// There is no difference between both keywords. Both return the same outcome.
        /// </summary>
        String firstName = "Santiago";
        string lastName = "Garcia";

        //Methods

        /// <summary>
        /// Format is a static method of the String class
        /// It defines a template for the format string where each placeholder is used to represent each of the arguments
        /// What ever we write between the curly brackets will be printed.
        /// </summary>
        public void FormatMethod()
        {
          
            Console.WriteLine(string.Format("{0} {1}", firstName, lastName));
        }

        /// <summary>
        /// We can join the items of an array or other data structures into a single string using the join method.
        /// We must specify a separator, which will be printed aswell.
        /// </summary>
        public void JoinMethod()
        {
            var completeName = new String[3] {"Santiago", "Garcia", "Perez"};
            Console.WriteLine(string.Join(" ", completeName));
        }

        /// <summary>
        /// Verbatim allows us to write the message we wish to print without the need of special escape characters. This is specially useful when we
        /// want to print a URL path. If we wish to print a backslash character "\" we must prefix it with another backslash. This may present problems 
        /// when we wish to write URL paths like "c:\projects\\project1\folder1"
        /// 
        /// We use verbatim in this scenario. We just need to ad a @ at the beginning of the string
        /// </summary>

        public void VerbatimMethod()
        {
            string text = 
                @"Hi Santiago!
Look into the following paths:
c:\folder1\file1
c:\filder2\file1";

            Console.WriteLine(text);
        }
    }
}
