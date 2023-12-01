namespace Advanced.Delegates
/*
 * A delegate is an object that knows how to call a method or a group of methods.
 * It works as a reference or a pointer to a function.
 *
 * This technique allows us to design extensible and flexible applications (For example Frameworks)
 *
 *    * In the .NET framework we hve two delegates that are generic:
             *      System.Action<>: Points to a method that returns void
             *      System.Func<>: Points to a method that returns a value 
 */
{
    
    /// <summary>
    /// In our Photo processor framework we want to create the ability to add new filters without having to
    /// compile and redeploy the class everytime a new filter is created.
    /// </summary>
    public class PhotoProcessor
    {
        
        /// <summary>
        /// We must define the signature of the method that the delegate will be responsible for calling.
        /// An instance of our delegate can hold a pointer (or reference) to a function or a group of functions
        /// with a signature: public void functionName(Photo photo)
        /// 
        /// </summary>
        public delegate void PhotoFilterHandler(Photo photo);
        
        
        
        /// <summary>
        /// This method does not know what filter will be applied. It is the responsibility of the user
        /// of this method to determine the filters that he wants to use. 
        /// </summary>
        /// <param name="path"></param>
        /// <param name="filterHandler"></param>
        public void Process(string path, PhotoFilterHandler filterHandler)
        {
            
            
                
            var photo = Photo.Load(path);

            filterHandler(photo);


        }
    }
}