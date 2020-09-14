/// Homework No. 2		Exercise Part 2
/// File Name: FahrenheitToCelsius
/// @author: Evan Sinclair
/// Date:  Sept 14, 2020
///
/// Problem Statement: Turn a temperature from Fahrenheit to Celsius
/// 
/// 
/// Overall Plan:
/// 1)Prompt user for a Temperature and store as a double
/// 2)Use equation to convert into Celsius
/// 3)Round temperature using Math.Round()
/// 4)Output converted temperature
///
///


using System;

namespace Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Prompt user for a temp in F
            Console.WriteLine("Enter a temperature in degrees Fahrenheit");
            
            // Read input and convert to double
            double fTemp = Convert.ToDouble(Console.ReadLine());
            
            // Calculate temp in C
            double cTemp = (fTemp - 32) * 5 / 9;

            // Round
            cTemp = Math.Round(cTemp, 2);

            // Output information
            Console.WriteLine(fTemp + " degrees Fahrenheit is equal to " + cTemp + " degrees Celsius ");
        }
    }
}
