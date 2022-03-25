using Calculators;
using System;
using Xunit;

namespace CalculatorsTest;

public class CalculatorTest
{
    [Fact]
    public void Add_AddTwoNumbers_ReturnsResult()
    {
        //Arrange
        var calculator = new Calculator();
        var number1 = 5f;
        var number2 = 10f;
        
        //Act
         var result = calculator.Add(number1, number2);
        
        //Assert
        Assert.Equal(15, result);
    }
    
    [Fact]
    public void Sub_SubstractTwoNumbers_ReturnsResult()
    {
        //Arrange
        var calculator = new Calculator();
        var number1 = 7f;
        var number2 = 2f;
        
        //Act
        var result = calculator.Sub(number1, number2);
        
        //Assert
        Assert.Equal(5, result);
    }
    
    [Theory]
    [InlineData(10,3)]
    [InlineData(5,4)]
    [InlineData(6,4)]
    public void Mul_MultiplyTwoNumbers_ReturnsResult(float number1, float number2)
    {
        //Arrange
        var calculator = new Calculator();
        var expected = number1 * number2;
        
        //Act
        var result = calculator.Mul(number1, number2);
        
        //Assert
        Assert.Equal(expected, result);
    }
    
    [Theory]
    [InlineData(10,2)]
    [InlineData(5,4)]
    [InlineData(6,2)]
    public void Div_DivideTwoNumbers_ReturnsResult(float number1, float number2)
    {
        //Arrange
        var calculator = new Calculator();
        var expected = number1 / number2;

        //Act
        var result = calculator.Div(number1, number2);
        
        //Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Div_DivideByZero_ShouldThrowException()
    {
        //Arrange
        var calculator = new Calculator();
        var number1 = 5;
        var zero = 0;
        
        //Act
        var exception = Assert.Throws<DivideByZeroException>(() => calculator.Div(number1, zero));

        //Assert
        Assert.NotNull(exception);
        Assert.Equal("Attempted to divide by zero.", exception.Message);
    }
    
}