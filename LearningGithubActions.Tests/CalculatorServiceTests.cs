using LearningGithubActions.Api;
using Xunit;

namespace LearningGithubActions.Tests;

public class CalculatorServiceTests
{
    private readonly CalculatorService _calculator;

    public CalculatorServiceTests()
    {
        _calculator = new CalculatorService();
    }

    [Fact]
    public void Sum_Should_Return_5_When_2_And_3()
    {
        // Arrange
        int a = 2;
        int b = 3;

        // Act
        var result = _calculator.Sum(a, b);

        // Assert
        Assert.Equal(5, result);
    }

    [Fact]
    public void Sum_Should_Return_15_When_10_And_5()
    {
        // Arrange
        int a = 10;
        int b = 5;

        // Act
        var result = _calculator.Sum(a, b);

        // Assert
        Assert.Equal(15, result);
    }

    [Fact]
    public void Sum_Should_Return_0_When_Both_Are_Zero()
    {
        var result = _calculator.Sum(0, 0);

        Assert.Equal(0, result);
    }

    [Fact]
    public void Sum_Should_Return_Negative_Value()
    {
        var result = _calculator.Sum(-5, -8);

        Assert.Equal(-13, result);
    }
}
