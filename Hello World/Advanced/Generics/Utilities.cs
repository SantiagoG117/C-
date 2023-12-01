using System;

namespace Advanced.Generics
{
    /// <summary>
    /// Constraints: Limit the type of the Key a value to a certain data type or class
    /// We can apply 5 types of contraints:
    ///     Interface constraint: where T : I comparable
    ///     Class constraint : where T : Product
    ///     Value type constraint: where T : struct
    ///     Reference type constraint: where T : class
    ///     Default constructor constraint : where T : new()
    ///
    /// In this class we are applying the interface constraint
    ///     
    /// </summary>
    public class Utilities
    {
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        /// <summary>
        /// Constraint the arguments of the method to implement the IComparable interface, so they can be compared.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public T Max<T>(T a, T b) where T : IComparable
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
        
        
    }
}