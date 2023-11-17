using System;

namespace ObjectOrientedProgramming.Polymorphism
{
    public class Circle : Shape
    {
        public override void Draw()
        {
            //* We can write any code related to the subclass in here: 
            Console.WriteLine("Draw a circle: ");
            //* Base is reference to the parent class:
            base.Draw();
        }
    }
}