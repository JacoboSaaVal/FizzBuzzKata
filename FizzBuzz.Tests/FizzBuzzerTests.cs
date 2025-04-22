using Xunit;
using FizzBuzz;

namespace FizzBuzz.Tests;

public class FizzBuzzerTests
{
    [Theory]
    [InlineData(1, "1")]
    [InlineData(3, "Fizz")]
    [InlineData(5, "Buzz")]
    [InlineData(15, "FizzBuzz")]
    [InlineData(16, "16")]
    public void GetValue_ReturnsExpectedResult(int input, string expected)
    {
        var result = FizzBuzzer.GetValue(input);
        Assert.Equal(expected, result);
    }
}