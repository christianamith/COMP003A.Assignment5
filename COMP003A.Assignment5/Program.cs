﻿/*
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
            IsoscelesTriangleBuilder(inputCharacter, size);

            PrintSeperator();
            PrintSeperator("Favorite Characters Section");
            PrintSeperator();

            CharacterInfo("pascal", 1631);
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
            Console.WriteLine($"\t{parameter1}");
        }

        /// <summary>
        /// Method for making a triangle that points to the right with custom parameters
        /// </summary>
        /// <param name="inputCharacter"></param>
        /// <param name="size"></param>
        static void IsoscelesTriangleBuilder(char inputCharacter, int size)
        {
            for (int i = 0; i <= size - 1; i++)
            {
                for (int k = 0; k <= i; k++)
                {
                    Console.Write(inputCharacter);
                }    
                Console.WriteLine();
            }
            for (int i = size; i >= 0; i--)
            {
                for (int k = 0; k <= i; k++)
                {
                    Console.Write(inputCharacter);
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Subtracts year value input in console from current year
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        static int AgeCalculator(int year)
        {
            int age = DateTime.Now.Year - year;
            return age;
        }

        /// <summary>
        /// Calls AgeCalculator to subtract birthYear given from current year
        /// </summary>
        /// <param name="name"></param>
        /// <param name="birthYear"></param>
        static void CharacterInfo(string name, int birthYear)
        {
            int age = AgeCalculator(birthYear);
            Console.WriteLine($"{name} is {age} years old!");
        }


    }
}