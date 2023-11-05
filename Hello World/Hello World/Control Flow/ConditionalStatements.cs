using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World.Control_Flow
{

    public class ConditionalStatements
    {

        public void switchOperator(Seasons season)
        {
            switch (season)
            {
                // Case scenario: in Fall and Winter, it gets colder
                case Seasons.Fall:
                case Seasons.Winter:
                    Console.WriteLine("It is coold");
                    break;

                case Seasons.Spring:
                    Console.WriteLine("It is Spring! Warm weather is comming!");
                    break;

                case Seasons.Summer:
                    Console.WriteLine("It is Summer! Time to show that Bikini ;) ");
                    break;

                default:
                    Console.WriteLine("I don't understand that season");
                    break;
            }
        }
        
        /// <summary>
        /// Ask the user to enter the speed limit. Once set, the program should ask for the speed of a car.
        /// If the value is above the speed limit, the program should calculate the number of demerit points:
        ///     For every 5 km/hr above the speed limit, 1 demerit point should be incurred and displayed in the console
        ///     If the number of demerit points is above 12, the program should display License Suspended. 
        /// </summary>
        public void SpeedCamera(int points)
        {
            //Local variables
            int speedLimit;
            int carSpeed;
            int kmPerDemeritPoints = 5;
            
            //Inputs
            
            // When reading inputs from the console it is better to use the ReadLine operator rather than the Read operator. 
            // Read operator doesn't have a line break, so it ignores the last statement. Now, ReadLine returns a String,
            // so if we are dealing with a numeric value, an implicit cast must be done using the Convert class.
            Console.WriteLine("Please enter the speed limit: ");
            speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the speed of the car: ");
            carSpeed = Convert.ToInt32(Console.ReadLine());


            //Calculations and outcome
            if (carSpeed < speedLimit)
                Console.WriteLine("Speed within speed limits.");
            else
            {
                points = (carSpeed - speedLimit) / kmPerDemeritPoints;
                Console.WriteLine("You have " + points + " demerit points");
                if (points >= 12)
                    Console.WriteLine("License Suspended");
            }

            
            
            
            









        }
    }
}
