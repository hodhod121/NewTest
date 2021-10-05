using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace CalculatorTest
{
    class Program
    {
        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }
        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine(" 0) Exit");
            Console.WriteLine(" 1) Addition");
            Console.WriteLine(" 2) Subtraction");
            Console.WriteLine(" 3) Multiplication");
            Console.WriteLine(" 4) Division");

            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "0":
                    return false;
                case "1":
                    Addition();
                    return true;
                case "2":
                    Subtraction();
                    return true;
                case "3":
                    Multipliaction();
                    return true;
                case "4":
                    Division();
                    return true;
                default:
                    return true;
            }
        }
        public static double output_1 = 0;
        public static double output_2 = 0;
        public static Calculator calc = new();
        static void Duplicates()
        {
            Console.Clear();
            Console.WriteLine("Enter your first number");
            string val_1 = Console.ReadLine();
            while (!double.TryParse(val_1, out output_1))
            {
                Console.WriteLine("Enter a valid number");
                val_1 = Console.ReadLine();
            }
            Console.WriteLine("Enter your second number");


            string val_2 = Console.ReadLine();
            while (!double.TryParse(val_2, out output_2))
            {
                Console.WriteLine("Enter a valid number");
                val_2 = Console.ReadLine();
            }
        }


        private static string Addition()
        {
            Duplicates();
            double[] array = new double[2] { output_1, output_2 };
            Console.WriteLine($"Result: {calc.Add(array)}");
            Console.Write("\r\nPress Enter to return to Main Menu");
            return Console.ReadLine();
        }
        private static string Subtraction()
        {
            Duplicates();
            double[] array = new double[2] { output_1, output_2 };
            Console.WriteLine($"Result: {calc.Subtract(array)}");
            Console.Write("\r\nPress Enter to return to Main Menu");
            return Console.ReadLine();
        }
        private static string Multipliaction()
        {
            Duplicates();
            Console.WriteLine($"Result: {calc.Multiply(output_1, output_2)}");
            Console.Write("\r\nPress Enter to return to Main Menu");
            return Console.ReadLine();
        }
        private static string Division()
        {
            Duplicates();
            if (output_2 != 0)
            {
                Console.WriteLine($"Result: {calc.Divide(output_1, output_2)}");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine(double.MaxValue);
                Console.WriteLine("Result is not valid, because division by zero is not valid in mathematics.");
            }

            Console.Write("\r\nPress Enter to return to Main Menu");
            return Console.ReadLine();
        }
    }
}
