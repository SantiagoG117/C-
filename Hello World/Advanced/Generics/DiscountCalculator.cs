namespace Advanced.Generics
{
    /// <summary>
    /// Constraints: Limit the type of the Key a value to a certain data type or class
    /// We can apply 5 types of constraints:
    ///     Interface constraint: where T : I comparable
    ///     Class constraint : where T : Product
    ///     Value type constraint: where T : struct
    ///     Reference type constraint: where T : class
    ///     Default constructor constraint : where T : new()
    ///
    /// In this class we are applying the class constraint
    /// </summary>
    /// <typeparam name="TProduct"></typeparam>
    public class DiscountCalculator<TProduct> where TProduct : Product
    {
        /// <summary>
        /// Gets an object of type Product or any of its subclasses
        ///
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public float CalculateDiscount(TProduct product)
        {
            return product.Price;

        }
    }
}