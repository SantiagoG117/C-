namespace ObjectOrientedProgramming.Methods
{
    public class CalculatorParamsModifier
    {
        //?Attributes
       
        //?Constructor

        //?methods
        
        /// <summary>
        /// A method with a varying number of parameters:
        /// Allows us to simply pass the numbers we wish to add without having to explicitly add the new array
        /// keyword
        /// </summary>
        /// <param name="numbers"> Takes a varying number of numbers</param>
        /// <returns>The sum of the parameters</returns>
        public int Add(params int[] numbers)
        {
            var sum = 0;
            foreach (var number in numbers)
                sum += number;

            return sum;
        }

    }
}