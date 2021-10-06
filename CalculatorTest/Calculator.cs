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
            double sum = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                sum -= array[i];
            }
            return sum;
        }

        public double Multiply(double[] array)
        {
            double sum = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                sum *= array[i];
            }
            return sum;
        }

        public double Divide(double x, double y)
        {
            if (y != 0)
            {
                return x / y;
            }
            else
            {
                return double.MaxValue;
            }
        }
    }
}

