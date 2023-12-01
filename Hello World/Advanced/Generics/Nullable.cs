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
    /// In this class we are applying a constraint to a value type
    ///
    /// Value types (int, double, etc) cannot be null. We can use this class to give our value types the
    /// ability to be nullable
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Nullable<T> where T : struct
    {
        //?Fields
        private object _value;
        //?Properties
        public bool HasValue
        {
            get { return _value != null; }
        }
        
        //?Constructor
        //*Initialize the value type and return its value
        public Nullable(T value)
        {
            _value = value;
        }

        //*Does not initialize the value type and therefore returns its default value
        public Nullable()
        {
        }

        //? Methods:
        /// <summary>
        /// If an object is initialize, we return its value. Otherwise it will return its default value
        /// number = 5 -> Returns 5.
        /// number; -> default value: 0
        /// </summary>
        /// <returns></returns>
        public T GetValueOrDefault()
        {
            if (HasValue)
            {
                return (T)_value;
            }

            //* Returns the default value of the parameter
            return default(T);
        }
        
    }
}