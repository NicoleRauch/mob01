using NUnit.Framework;
using fizzbuzz;

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
        Assert.That(result, Is.EqualTo("1"));
    }
}