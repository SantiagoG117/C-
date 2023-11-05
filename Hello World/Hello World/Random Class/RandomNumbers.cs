using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World.Random_Class
{
    internal class RandomNumbers
    {
        //Attributes:
        private Random random = new Random();

        //Methods

        /// <summary>
        /// Returns a random number
        /// </summary>
        public void nextMethod()
        {
            for (int i = 0; i < 10; i++)
            
                Console.WriteLine(random.Next());


            for (int i = 0; i < 10; i++)
                //Random numbers between 1 and 10
                Console.WriteLine(random.Next(1, 10));
        }
        /// <summary>
        /// Random password: Each character is represented by a numberic value. In the ASSCI code the 
        /// underscore letters have a range from 97 (a) to 122 (z). So if we create a random number between
        /// these range of values and cast it to a character, we will get a random character. If we do this a 
        /// number of times we can build a random string.
        /// 
        /// In C# we cannot create a String object and set its individual characters using a random character. Instead we must store
        /// the result of the random characters in an array and then create the String based on the array
        /// </summary>
        public void randomPasswordGenerator()
        {
            //Local variables:
            var aInASCII = 97;
            var zInASCII = 122;
            const int PASSWORDLENGTH = 10;
            var characters = new char[PASSWORDLENGTH];

            for (int i = 0; i < PASSWORDLENGTH; i++)
                //We use Console.Write because we don't want to print the character in a new line. 
                characters[i] = (char)random.Next(aInASCII, zInASCII);

            //Create the String based on the character array
            var password = new string(characters);

            //Console.WriteLine help separate the message "Press any key to continue" in the console
            Console.WriteLine(password);
        }
    }
}
