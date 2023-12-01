using System;

namespace Advanced.LambdaExpressions
{
    /// <summary>
    /// A lambda expression is an anonymous method with
    ///     No access modifier
    ///     No name
    ///     No return statement
    /// They are use for convinience. They allows us to write less code to achieve the same thing.
    ///
    /// The structure of a lambda is:
    /// arguments => expression
    ///     With no arguments:
    ///     () => expression
    ///     One argument:
    ///     x => expression
    ///     multiple arguments
    ///     (x,y,z) => expression
    /// 
    /// 
    /// 
    /// </summary>
    public class Lambdas
    {
        public int Square(int number)
        {
            return number * number;
        }
        
        //?Lets apply this same method with lambdas:
        
        /*
         * To call a lamda, we need to assign it to a delegate. We use Func:
         *      System.Func<>: Points to a method that returns a value
         *      Func<argument, return data type>
         */
        private Func<int, int> SquareLambdas = number => number*number;
    }
}