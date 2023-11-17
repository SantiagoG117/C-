using System;

namespace ObjectOrientedProgramming.InheritanceAndComposition
{
    /// <summary>
    /// Text inherits from PresentationObject
    /// 
    /// </summary>
    public class Text : Shape
    {
        //?Properties
        public int FontSize { get; set; }
        public string FontName { get; set; }
       
    }
}