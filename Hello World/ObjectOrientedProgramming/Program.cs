using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedProgramming.Classes;
using ObjectOrientedProgramming.InheritanceAndComposition;
using ObjectOrientedProgramming.InterfacesAndTestability;
using ObjectOrientedProgramming.Methods;
using ObjectOrientedProgramming.Polymorphism;
using Shape = ObjectOrientedProgramming.Polymorphism.Shape;

namespace ObjectOrientedProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var orderProcessor = new OrderProcessor(new ShippingCalculator());
            var order = new Order { DatePlaced = DateTime.Now, TotalPrice = 100f };
            orderProcessor.Process(order);
            
        }
    }
}
