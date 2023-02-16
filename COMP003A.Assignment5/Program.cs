/*
 * Author:  Christian Amith
 * Course:  COMP-003A-L01
 * Purpose: Code for 5th week assignment
 */

using System.Collections.Generic;

namespace COMP003A.Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintSeperator();
            PrintSeperator("Triangle Section");
            PrintSeperator();

            Console.Write("Enter a single character: ");
            char inputCharacter = Convert.ToChar(Console.ReadLine());
            Console.Write("Enter a positive whole number: ");
            int size = Convert.ToInt32(Console.ReadLine());
            TriangleBuilder(inputCharacter, size);

        }

        /// <summary>
        /// Method without parameters and return value
        /// </summary>
        static void PrintSeperator()
        {
            string border = new string('*', 50);
            Console.WriteLine(border);
        }

        /// <summary>
        /// Method overloading with one parameter but no return value
        /// </summary>
        /// <param name="parameter1"></param>
        static void PrintSeperator(string parameter1)
        {
            Console.WriteLine("\t" + parameter1);
        }

        /// <summary>
        /// Method for making a triangle that points to the right with custom parameters
        /// </summary>
        /// <param name="inputCharacter"></param>
        /// <param name="size"></param>
        static void TriangleBuilder(char inputCharacter, int size)  // DOES NOT WORK!!!! FIX THIS LATER <-------------------------------------------
        {
            for (int i = 0; i <= size; i++)
            {
                for (int k = 0; k <= i; k++)
                {
                    Console.Write(inputCharacter);
                }    
                Console.WriteLine();
            }
            for (int i = 0; i <= size; i++)
            {
                for (int k = 0; k <= i - 1; k++)
                {
                    Console.Write(inputCharacter);
                }    
                Console.WriteLine();
            }
        }
    }
}