namespace ObjectOrientedProgramming.Polymorphism
{
    /// <summary>
    /// Virtual Keyword: Gives us the ability to change the implementation of a method in a subclass
    /// Override: Allows us to override a inherited method
    /// </summary>
    public class Shape
    {
        //? Properties
        public int Width { get; set; }
        public int Height { get; set; }
        public Position Position { get; set; }
    
        //?Public methods
        
        /*
         * Defines the concept of drawing a shape. However, how we draw each shape will be different.
         * So we must add the virtual keyword so this method must be overwritten by the subclasses of Shape.
         */
        public virtual void Draw()
        {
            
        }
        
    }
}