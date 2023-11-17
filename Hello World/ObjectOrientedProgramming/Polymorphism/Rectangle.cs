using System;

namespace ObjectOrientedProgramming.Polymorphism
{
    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a rectangle");
            base.Draw();
        }
    }
}