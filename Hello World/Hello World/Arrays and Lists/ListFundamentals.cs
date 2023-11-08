using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World.Arrays_and_Lists
{
  
    /// <summary>
    /// A list is a data structure for storing a number of objects for the same time. We use a list when we don't know
    /// ahead of time how many ojects are we going to store in that list.
    /// </summary>
    public class ListFundamentals
    {
        //? Attributes
        private List<int> numbers = new List<int>() { 1, 2, 3, 4};

        /// <summary>
        /// When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.
        ///     If no one likes your post, it doesn't display anything
        ///     If only one person likes your post, it displays: [Friend's Name] likes your post.
        ///     If two people like your post, it displays: [Friend 1] and [Friend 2] like your post.
        ///     If more than two people like your post, it displays: [Friend 1], [Friend 2] and [Number of Other People] others like your post.
        ///
        /// This method continuously ask the user to enter different names, until the user presses Enter (without supplying a name). Depending on the number of names
        /// provided, display a message based on the above pattern
        /// </summary>
        public void PostingReactions()
        {
            List<String> names = new List<string>();

            //* Store the names in a List
            while (true)
            {
                Console.WriteLine("Please enter a name or press Enter to exit: ");
                var name = Console.ReadLine();
                //* Check if the String is empty:
                if (String.IsNullOrEmpty(name))
                    break;
                names.Add(name);
            }
            
            //* Check the reactions display message
            //     If no one likes your post, it doesn't display anything
            if (names.Count > 2)
                Console.WriteLine(string.Format("{0}, {1} and {2} others like your post.", names[0], names[1], names.Count() - 1));
            //     If two people like your post, it displays: [Friend 1] and [Friend 2] like your post.
            else if (names.Count == 2)
                Console.WriteLine(string.Format("{0} and {1} like your post.", names[0], names[1]));
            //     If only one person likes your post, it displays: [Friend's Name] likes your post.
            else
                Console.WriteLine(string.Format("{0} likes our post.", names[0]));
        }

        /// <summary>
        /// Asks the user to enter their name, uses an array to reverse the name and then stores the result in a new string.
        /// Displays the reversed name on the console.
        /// </summary>
        /// <param name="name"></param>
        public String reverseName()
        {
            //? Local variables
            var inversedName ="";
            var charPosition = 0;
            
            //? Inputs
            Console.WriteLine("Please enter your name: ");
            var name = Console.ReadLine();
            var characters = new char[name.Length];

            //? Operations
            //* Iterate over the name in reverse order and store each character in an array
            for (int i = name.Length - 1; i >= 0; i--)
                characters[charPosition++] = name.ToCharArray()[i];
            
            //? Output
            return inversedName = new string(characters);
        }

        /// <summary>
        /// Asks the user to continuously enter a number or type "Quit" to exit. The list of numbers may include duplicates.
        /// Displays the unique numbers that the user has entered
        /// </summary>
        public void uniqueNumbers()
        {
            //? Local variables
            var numbers = new List<int>();
            var input = "";
            int number;

            //? Operations:
            while (true)
            {
                Console.WriteLine("Please enter a number or press \"Quit\": ");
                input = Console.ReadLine();
                
                //* If the user types any form of quit, the loop will break
                if (input.Trim().ToLower().Equals("quit"))
                    break;
                
                //* Convert the input to int and only store it in the List if it does not already exist.
                number = Convert.ToInt32(input);
                if (!numbers.Contains(number))
                    numbers.Add(number);
            }
            
            //? Output
            //* Sort the List and print its values
            numbers.Sort();
            foreach (var value in numbers)
                Console.Write(value + " ");
        }
        
        /// <summary>
        /// Asks the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10).
        /// If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try;
        /// otherwise, display the 3 smallest numbers in the list.
        /// </summary>
        public void smallestNumbers()
        {
            //? Local Variables
            string[] elements;
            var numbers = new List<int>();

            while (true)
            {
                //? Iputs
                Console.WriteLine("Please supply a list of five comma separated numbers (e.g. 5, 1, 9, 2, 10): ");
                var input = Console.ReadLine();
                
                
                //*Check if the user enter a valid input and store it in the elements array
                if (!String.IsNullOrWhiteSpace(input))
                {
                    //* Store the elements of the input in the elements array separating them by a ,
                    elements = input.Split(',');

                    //* If the list is smaller than 5 elements, exit the loop
                    if (elements.Length < 5)
                    {
                        Console.WriteLine("Invalid list, please try again");
                        break;
                    }
                    
                    //* Transfer the items in the elements array to the numbers array
                    foreach (var character in elements)
                        numbers.Add(Convert.ToInt32(character));
                    //?Outcome:
                    //* Display the 3 smallest numbers in the list
                    numbers.Sort();
            
                    for (int i = 0; i <= 2; i++)
                        Console.Write(numbers[i]);
                }
                break;
            }
        }
        
        
        public void addNumber()
        {
            numbers.Add(1);
            numbers.AddRange(new int[3] {5,6,7});

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
        
        /// <summary>
        /// In c# we are not allowed to modify our collection inside a for each loop. Instead we must use a for i loop
        /// </summary>
        /// <param name="value"></param>
        public void removeAllValues(int value)
        {
            //!In c# we are not allowed to modify our collection inside a for each loop. Instead we must use a for i loop
            //! {
            //!    if (number == value)
            //!         numbers.Remove(number);
            //!}
            
            //* Instead we must use a for loop:
            for (int index = 0; index < numbers.Count; index++)
                if (numbers[index] == value)
                    numbers.Remove(numbers[index]);
            
        }
    }
}
