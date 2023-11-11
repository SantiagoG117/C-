using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedProgramming.Methods;

namespace ObjectOrientedProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var calculator = new CalculatorParamsModifier();
            Console.WriteLine(calculator.Add(1, 2, 3, 4));
            Console.WriteLine(calculator.Add(1, 2, 3));
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1));
            
        }
    }
}
