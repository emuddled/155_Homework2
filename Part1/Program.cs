/// Homework No. 2		Exercise Part 1
/// File Name: PigLatin
/// @author: Evan Sinclair
/// Date:  Sept 14, 2020
///
/// Problem Statement: Change a name into Pig Latin and capitalize it
/// 
/// 
/// Overall Plan:
/// 1)save the first letter in each name
/// 2)create pigliatin names using char.ToUpper() on the second character in the name + substring from the third position + first letter + "ay"
/// 3)Output pig latin names
///
///




using System;


using System;

namespace Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "evan";
            string secondName = "sinclair";

            
            // process first name
            string firstLetter = firstName.Substring(0, 1);
            string pigFirst = char.ToUpper(firstName[1]) + firstName.Substring(2) + firstLetter + "ay";

            // process second name
            firstLetter = secondName.Substring(0, 1);
            string pigSecond = char.ToUpper(secondName[1]) + secondName.Substring(2) + firstLetter + "ay";


            Console.WriteLine(pigFirst + " " + pigSecond);

        }
    }
}
