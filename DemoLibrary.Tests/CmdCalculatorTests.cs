using CmdLineCalculator;
using Xunit;

namespace CmdCalculator.Tests
{
    public class CmdCalculatorTests
    {
        [Theory]
        [InlineData(4, 3, 7)]
        [InlineData(21, 5.25, 26.25)]
        [InlineData(double.MaxValue, 5, double.MaxValue)]
        public void ShouldAdd(double x, double y, double expected)
        {
            // Arrange

            // Act
            double actual = Calculator.Add(x, y);

            // Assert
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(20, 3, 17)]
        [InlineData(21, 5.25, 15.75)]
        public void ShouldSubstract(double x, double y, double expected)
        {
            // Arrange

            // Act
            double actual = Calculator.Substract(x, y);

            // Assert
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(8, 4, 2)]  
        [InlineData(100, 4, 25)]
        public void ShouldDivide(double x, double y, double expected)
        {
            // Arrange

            // Act
            double actual = Calculator.Divide(x, y);

            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void ShouldDivideByZero()
        {
            // Arrange
            double expected = 0;

            // Act
            double actual = Calculator.Divide(5, 0);

            // Assert
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(4, 3, 12)]
        [InlineData(6.5, 4, 26)]
        public void ShouldMultiply(double x, double y, double expected)
        {
            // Arrange

            // Act
            double actual = Calculator.Multiply(x, y);

            // Assert
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(4, 3, 64)]
        [InlineData(25, 2, 625)]
        public void ShouldPowerRaise(double x, double y, double expected)
        {
            // Arrange

            // Act
            double actual = Calculator.PowerRaise(x, y);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
