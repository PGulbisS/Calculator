using System;
using Xunit;

namespace calculatordemo.Test
{
    public class Calculator
    {
        [Fact]
        public void GetTwoNumbers_WhenNumbersSum_ThenReturnSum()
        {
            //If two numbers sum, then return "sum"
            //If two numbers subtrack, then return "minuss"
            //If two numbers multiply, then return "multiply"
            //If two numbers divide, then return "divide"
            //Arrange
            var calculator = new calculator();
            //Act
            var result = calculatordemo.calculator.GetNumbers(1);
            //Assert
            Assert.Equal("1", result);
        }

        [Fact]
        public void GetTwoNumbers_WhenNumbersSubtrack_ThenReturnMinuss()
        {
            //Arrange
            var calculator = new calculator();
            //Act
            var result = calculatordemo.calculator.GetNumbers(10);
            //Assert
            Assert.Equal("minuss", result);
        }
        [Fact]
        public void GetTwoNumbers_WhenNumbersMultiply_ThenReturnMultiply()
        {
            //Arrange
            var calculator = new calculator();
            //Act
            var result = calculatordemo.calculator.GetNumbers(0);
            //Assert
            Assert.Equal("multiply", result);
        }
        [Theory]
        [InlineData(100)]
        [InlineData(50)]
        [InlineData(20)]
        public void GetTwoNumbers_WhenNumbersDivide_ThenReturnDivide(int testableNumber)
        {
            //Arrange
            var calculator = new calculator();
            //Act
            var result = calculatordemo.calculator.GetNumbers(testableNumber);
            //Assert
            Assert.Equal("divide", result);
        }

    }
}
