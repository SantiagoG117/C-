using System;

namespace ObjectOrientedProgramming.InheritanceAndComposition
{
    /// <summary>
    /// Text inherits from PresentationObject
    /// 
    /// </summary>
    public class Text : PresenationObject
    {
        //?Properties
        public int FontSize { get; set; }
        public string FontName { get; set; }
        
        //?Public methods:
        public void AddHyperlink(string url)
        {
            Console.WriteLine("We added a link to " + url);
        }
    }
}