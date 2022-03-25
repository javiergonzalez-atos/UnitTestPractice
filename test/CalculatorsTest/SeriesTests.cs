using Calculators;
using Xunit;
using Moq;

namespace CalculatorsTest;

public class SeriesTests
{
    [Fact]
    public void Fibonacci_Should_ReturnsSum()
    {
        //Arrange
        var mockCalculator = new Mock<ICalculator>();
        mockCalculator.Setup(c => c.Add(It.IsAny<int>(), It.IsAny<int>()))
                      .Returns<int,int>((a,b) => a+b);;
        
        var series = new Series(mockCalculator.Object);
        
        
 
        //Act
        var result = series.Fibonacci(5);

        //Assert
        Assert.Equal(5, result);
    }

    [Fact]
    public void Factorial_Should_ReturnsMultiplication()
    {
        //Arrange
        var mockCalculator = new Mock<ICalculator>();

        mockCalculator.Setup(c => c.Mul(It.IsAny<int>(), It.IsAny<int>()))
                      .Returns<int,int>((a,b) => a*b);;

        var series = new Series(mockCalculator.Object);
        
        //Act
        var result = series.Factorial(4);

        //Assert
        Assert.Equal(24, result);
    }
}