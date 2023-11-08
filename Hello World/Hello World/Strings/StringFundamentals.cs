using System;
using System.Collections.Generic;
using System.Text;

namespace Fundamentals.Strings
{
    public class StringFundamentals
    {

        /// <summary>
        /// Takes a full name and returns the first and last name
        /// </summary>
        /// <param name="fullName"></param>
        public void splitFullName(String fullName)
        {
            //* Split() takes a delimiter to split a and stores its result in an array
            var names = fullName.Split(' ');
            
            Console.WriteLine($"Your first name is {names[0]} and your last name is {names[1]}");
        }

        /// <summary>
        /// To convert a number to String we have two options:
        ///     Integer.Parse(String)
        ///     Convert.ToInt32(String)
        ///
        /// Convert is the preferred one because if the string is null or empty, it will automatically map it
        /// to 0. Avoding errirs in our code
        /// </summary>
        /// <param name="stringNumber"></param>
        /// <returns></returns>
        public int convertToNumeric(String stringNumber)
        {
            return Convert.ToInt32(stringNumber);
        }

        /// <summary>
        /// To get the summary we take into account the word boundaries. The algorithm counts the number of words that
        /// roughly fits in 20 characters
        /// </summary>
        /// <param name="longText"></param>
        /// <param name="summaryLength"></param> The user has the option of setting the summary lenght, if it does not
        /// provide a value, it will have a default value of 20.
        /// 
        public void SummarizeText(String longText, int summaryLength = 20)
        {
            
            //* Check if the length of the long text is bellow a given threshold
            if (longText.Length < summaryLength)
                Console.WriteLine(longText);
            
            //*Split the long text into words using a single space as separator. This ensures that the algorithm won't
            //* cut a word in half
            var words = longText.Split(' ');
            var totalCharacters = 0;
            //* Dynamically store the summary in a string
            var summaryWords = new List<string>();
            
            //* Iterate over the String array and for each word count its number of characters. If we get to 20, that
            //* will be the boundary of our summary
            foreach (var word in words)
            {
                //* Add the current word to the summary list:
                summaryWords.Add(word);
                //* We add +1 because of the space after each word
                totalCharacters += word.Length + 1;
                
                //* Once the number of characters exceed the defined summary length it exits the loop.
                if (totalCharacters > summaryLength)
                    break;
            }
            
            //* Create a String and join all the words in the summary list using a white space
            //* Join concatenates all the elements of a string array, using the specified separator between each element and returns a String element
            var summary = String.Join(" ", summaryWords) + "...";

            Console.WriteLine(summary);
        }

        /// <summary>
        ///String Builder represents a mutable String. They are very handy to create and manipulate strings but
        /// it does not contain any of the searching operations of the Strings. Instead it offers a number of
        /// manipulation methods.
        /// 
        /// All the methods of String builder return a String builder with the new modified string. This means we can
        /// chain multiple sequential methods
        /// 
        /// </summary>
        public void StringBuilderFundamentals(String text)
        {
            var builder = new StringBuilder();
            
     
            builder
                //*Append to the String builder '-' ten times
                .Append('-', 10)
                //*Append a new line to the String builder
                .AppendLine()
                .Append("Header")
                .AppendLine()
                .Append('-', 10);

            builder
                //* Remove 10 characters from index 0
                .Remove(0, 10)
                //* Insert the given string starting from index 0
                .Insert(0, new string('-', 10));

            Console.WriteLine("First character: " + builder[0]);

        }
    }
}