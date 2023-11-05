using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World.Arrays
{

    public class ArrayFundamentals
    {
         /*
          *  Each row has the exact same number of columns
          * [0,1,2,3,4]
          * [0,1,2,3,4]
          * 0,1,2,3,4]
          */        
        public void RectangularArray()
        {
            //Local variables
            var rows = 3;
            var columns = 5;
            
            //Ways of create a rectangular array
            var matrix1 = new int[rows, columns];

            var matrix2 = new int[3, 5]
            {
                {1,2,3,4,5},
                {6,7,8,9,10},
                {11,12,13,14,15}
            };

            //Access an element of the array in row 2, column 4.
            var result = matrix2[2, 4];

        }


       
        /*
         * The number of columns in each row can be different. It can be seen as a single dimensional array
         *  in which each element is in turn a single dimensional array
         * [0,1,2,3]
         * [0,1,2,3,4]
         * [0,1,2]
         */ 
       
        public void JaggedArray()
        {
            //We use two squared brackets to represent a Jagged Array:
                // In the first squared bracket we specify the number of elements in the top level array
            var jaggedArray = new int[3][];

            //Then we must initialize each element of the Jagged Array to a different array
            jaggedArray[0] = new int[4];
            jaggedArray[0] = new int[5];
            jaggedArray[0] = new int[3];

            //Access an element of the array in row 2, column 4.
            var result = jaggedArray[2][4];
        }

        /// <summary>
        /// Clear clears the values inside the specified indexes:
        ///     With integer values it set them to 0
        ///     With bool values it set them to false
        ///     With String or other Objects it sets them to null
        /// 
        /// </summary>
        public void clearMethod()
        {
            var numbers = new[] { 3, 7, 9, 2, 14, 6 };
            Array.Clear(numbers,0,2);


            Console.WriteLine("Effect of clear");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            
        }
    }
}
