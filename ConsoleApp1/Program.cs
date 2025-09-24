// See https://aka.ms/new-console-template for more information
using System;
using System.Runtime.CompilerServices;

namespace HelloWorld
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            while (true)
            {
                Console.WriteLine("\nMiniCalculator & GradeChecker by Feil Jasper Doria!\n");
                string menu = """
                === MINI UTILITY===
                1. Grade Calculator
                2. Grade Checker
                3. Exit
                """
                ;
                Console.WriteLine(menu);
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        GradeCalculator();
                        break;
                    case 2:
                        GradeChecker();
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                }
            }
        }
        public static void GradeCalculator()
        {

            Console.WriteLine("Kindly type your grade for a certain subject.");
            int grade = Convert.ToInt32(Console.ReadLine());


            if (grade >= 90)
            {
                Console.WriteLine("Your grade is A.");
            }
            else if (grade >= 80 && grade <= 89)
            {
                Console.WriteLine("Your grade is B.");
            }
            else if (grade >= 70 || grade <= 79)
            {
                Console.WriteLine("Your grade is c.");
            }
            else if (grade >= 60 || grade <= 69)
            {
                Console.WriteLine("Your grade is D.");
            }
            else
            {
                Console.WriteLine("Your grade is F.");
            }

        }
        public static void GradeChecker()
        {
            int[] number = new int[2];
            
            Console.WriteLine("Type 2 Numbers please..");
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Number " + (i + 1) + ": ");
                number[i] = Convert.ToInt32(Console.ReadLine());
            }   
            Console.WriteLine($"Invalid Format {e}");
            
            bool validity = false;
            while (!validity)
            {
                Console.WriteLine("Please choose an operator for your chosen numbers.");
                Console.WriteLine(@"
                1. Addition
                2. Subtraction
                3. Multiplication
                4. Division
                ");
                try
                {
                    string option = Console.ReadLine();
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input, please type in string");
                }
            }
            switch (option)
                {
                    case "addition":
                        Console.WriteLine("Result: " + (number[0] + number[1]));
                        break;
                    case "subtraction":
                        Console.WriteLine("Result: " + (number[0] - number[1]));
                        break;
                    case "multiplication":
                        Console.WriteLine("Result: " + (number[0] * number[1]));
                        break;
                    case "division":
                        Console.WriteLine("Result: " + (number[0] / number[1]));
                        break;
                }
        }
    }
}