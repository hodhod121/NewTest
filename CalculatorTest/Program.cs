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
        public static double[] array;
        public static string val;
        static void Duplicates()
        {
            bool TryAgain = true;

            int count = 0;
            while (TryAgain)
            {
                val = Console.ReadLine();
                val = val.Trim();
                if (val.Length < 3 || !val.Contains(','))
                {
                    count++;
                }
                StringBuilder sb = new StringBuilder(val);
                int sbLength = sb.Length;
                for (int i = 0; i < sbLength; i++)
                {
                    if (sb[i] == ' ')
                    {
                        sb.Remove(sb[i], 1);
                        sbLength--;
                    }
                }
                val = sb.ToString();
                string[] digits = val.Split(",");
                for (int i = 0; i < digits.Length; i++)
                {
                    StringBuilder st = new StringBuilder(digits[i]);
                    st.Replace(".", ",");
                    digits[i] = st.ToString();
                }
                foreach (string digit in digits)
                {

                    if (!(double.TryParse(digit.ToString(), out var parsedNumber)))
                    {
                        count++;
                        break;
                    }
                }
                if (count == 0)
                {
                    array = new double[digits.Length];
                    for (int i = 0; i < digits.Length; i++)
                    {
                        array[i] = Double.Parse(digits[i].Trim());
                    }
                    TryAgain = false;
                }
                else
                {
                    Console.WriteLine("You have to enter more than one valid number and put ',' between them");
                    count = 0;
                }
            }
        }
        private static string Addition()
        {
            Console.Clear();
            Console.WriteLine("Enter your numbers you want to add,put ',' between them");
            Console.WriteLine("For example 2.3,5.6 or -3.2,+5.6");
            Duplicates();
            Console.WriteLine($"Result: {calc.Add(array)}");
            Console.Write("\r\nPress Enter to return to Main Menu");
            return Console.ReadLine();
        }
        private static string Subtraction()
        {
            Console.Clear();
            Console.WriteLine("Enter your numbers you want to subtract,put ',' between them");
            Console.WriteLine("For example 2.3,5.6 or -3.2,+5.6");
            Duplicates();
            Console.WriteLine($"Result: {calc.Subtract(array)}");
            Console.Write("\r\nPress Enter to return to Main Menu");
            return Console.ReadLine();
        }
        private static string Multipliaction()
        {
            Console.Clear();
            Console.WriteLine("Enter your numbers you want to multiply,put ',' between them");
            Console.WriteLine("For example 2.3,5.6 or -3.2,+5.6");
            Duplicates();
            Console.WriteLine($"Result: {calc.Multiply(array)}");
            Console.Write("\r\nPress Enter to return to Main Menu");
            return Console.ReadLine();
        }
        private static string Division()
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