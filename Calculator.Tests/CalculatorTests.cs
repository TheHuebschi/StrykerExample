using FluentAssertions;

namespace Calculator.Tests;

public class CalculatorTests
{
    [Theory]
    [InlineData(5, 5, 10)]
    public void Calculator_Add_ReturnsExpectedResult(int firstSummand, int secondSummand, int expectedResult)
    {
        // Arrange
        var testee = new Calculator();

        // Act
        var result = testee.Add(firstSummand, secondSummand);

        // Assert
        result.Should().Be(expectedResult);
    }
    
    [Theory]
    [InlineData(5, 5, 0)]
    public void Calculator_Subtract_ReturnsExpectedResult(int minuend, int subtrahend, int expectedResult)
    {
        // Arrange
        var testee = new Calculator();

        // Act
        var result = testee.Subtract(minuend, subtrahend);

        // Assert
        result.Should().Be(expectedResult);
    }
    
    [Theory]
    [InlineData(1, 1, 1)]
    public void Calculator_Multiply_ReturnsExpectedResult(int firstFactor, int secondFactor, int expectedResult)
    {
        // Arrange
        var testee = new Calculator();

        // Act
        var result = testee.Multiply(firstFactor, secondFactor);

        // Assert
        result.Should().Be(expectedResult);
    }
    
    [Theory]
    [InlineData(1, 1, 1)]
    public void Calculator_Divide_ReturnsExpectedResult(int dividend, int divisor, int expectedResult)
    {
        // Arrange
        var testee = new Calculator();

        // Act
        var result = testee.Divide(dividend, divisor);

        // Assert
        result.Result.Should().Be(expectedResult);
    }
    
    [Theory]
    [InlineData(1, 1, 0)]
    public void Calculator_Divide_ReturnsExpectedRemainder(int dividend, int divisor, int expectedRemainder)
    {
        // Arrange
        var testee = new Calculator();

        // Act
        var result = testee.Divide(dividend, divisor);

        // Assert
        result.Remainder.Should().Be(expectedRemainder);
    }
    
    [Fact]
    public void Calculator_Divide_WhenDivisorZero_ThrowsDivideByZeroException()
    {
        // Arrange
        int dividend = 1;
        int divisor = 0;
        var testee = new Calculator();

        // Act
        Action act = () => testee.Divide(dividend, divisor);

        // Assert
        act.Should().Throw<DivideByZeroException>();
    }
}