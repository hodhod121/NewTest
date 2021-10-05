using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTest
{
    public class Calculator
    {
        public double Add(double[] array)
        {
            return array.Sum();
        }

        public double Subtract(double[] array)
        {
            return array[0] - array[1];
        }

        public double Multiply(double x, double y)
        {
            return x * y;
        }

        public double Divide(double x, double y)
        {
            if (y != 0)
            {
                return x / y;
            }
            else
            {
                // Custom business logic for divide by zero
                return double.MaxValue;
            }
        }
    }
}

