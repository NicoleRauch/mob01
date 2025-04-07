using NUnit.Framework;

namespace fizzbuzz;

[TestFixture]
public class FizzBuzzTest
{

    [Test]
    public void Given_1_Returns_1()
    {
        // Arrange
        var fizzBuzz = new FizzBuzz();

        // Act
        var result = fizzBuzz.Get(1);

        // Assert
        Assert.Equal("1", result);
    }
}