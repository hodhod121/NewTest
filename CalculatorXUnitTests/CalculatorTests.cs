using CalculatorTest;
using System;
using Xunit;

namespace CalculatorXUnitTests
{
    public class CalculatorTests
    {
        public static Calculator calculator = new Calculator();
        [Theory]
        [InlineData(new double[] { 2, 6 }, 8)]
        [InlineData(new double[] { 32.55, 2.22 }, 34.77)]
        public void Add_(double[] array, double expected)
        {
            // Arrange

            // Act
            double actual = calculator.Add(array);

            // Assert
            Assert.Equal(expected, actual, 2);
        }
        [Theory]
        [InlineData(new double[] { 2, 6 }, -4)]
        [InlineData(new double[] { 32.55, 2.22 }, 30.33)]
        public void Subtract_(double[] array, double expected)
        {
            // Arrange

            // Act
            double actual = calculator.Subtract(array);

            // Assert
            Assert.Equal(expected, actual, 2);
        }
        [Theory]
        [InlineData(2, 8, 16)]
        [InlineData(32.55, 2.22, 72.26)]
        public void Multiply_(double x, double y, double expected)
        {
            // Arrange

            // Act
            double actual = calculator.Multiply(x, y);

            // Assert
            Assert.Equal(expected, actual, 2);
        }


        [Theory]
        [InlineData(8, 4, 2)]
        [InlineData(32.55, 2.22, 14.66)]
        public void Divide_(double x, double y, double expected)
        {
            // Arrange

            // Act
            double actual = calculator.Divide(x, y);

            // Assert
            Assert.Equal(expected, actual, 2);
        }

        [Fact]
        public void Divide_ByZero()
        {
            // Arrange
            double expected = double.MaxValue;

            // Act
            double actual = calculator.Divide(3, 0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
