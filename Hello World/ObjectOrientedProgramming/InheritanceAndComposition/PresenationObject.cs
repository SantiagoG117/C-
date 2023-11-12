using System;

namespace ObjectOrientedProgramming.InheritanceAndComposition
{
    public class PresenationObject
    {
        //?Properties
        public int Width { get; set; }
        public int Height { get; set; }
        
        //?Public methods
        public void Copy()
        {
            Console.WriteLine("Object copied to clipboard");
        }

        public void Duplicate()
        {
            Console.WriteLine("Object was duplicated");
        }
    }
}