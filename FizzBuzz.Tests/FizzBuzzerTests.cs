using Xunit;
using FizzBuzz;

namespace FizzBuzz.Tests;

public class FizzBuzzerTests
{
    [Theory]
    [InlineData(1, "1")]
    [InlineData(2, "2")]
    [InlineData(4, "4")]
    public void GetValue_ReturnsNumber_WhenNotDivisibleBy3Or5(int input, string expected)
    {
        var result = FizzBuzzer.GetValue(input);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(3)]
    [InlineData(6)]
    [InlineData(9)]
    public void GetValue_ReturnsFizz_WhenDivisibleBy3(int input)
    {
        var result = FizzBuzzer.GetValue(input);
        Assert.Equal("Fizz", result);
    }

    [Theory]
    [InlineData(5)]
    [InlineData(10)]
    [InlineData(20)]
    public void GetValue_ReturnsBuzz_WhenDivisibleBy5(int input)
    {
        var result = FizzBuzzer.GetValue(input);
        Assert.Equal("Buzz", result);
    }

    [Theory]
    [InlineData(15)]
    [InlineData(30)]
    [InlineData(45)]
    public void GetValue_ReturnsFizzBuzz_WhenDivisibleBy3And5(int input)
    {
        var result = FizzBuzzer.GetValue(input);
        Assert.Equal("FizzBuzz", result);
    }
}