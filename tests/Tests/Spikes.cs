using AutoFixture;
using AutoFixture.Xunit2;
using Tests.Utility;
using Xunit;

namespace Tests
{
    [Trait(Trait.Category, Trait.UnitTest)]
    public class Spikes
    {
        [Fact]
        public void IntroductoryFact()
        {
            // Arrange
            var fixture = new Fixture();
            var expectedNumber = fixture.Create<int>();
            var sut = fixture.Create<MyClass>();

            // Act
            var result = sut.Echo(expectedNumber);

            // Assert
            Assert.Equal(expectedNumber, result);
        }

        [Theory, AutoData]
        public void IntroductoryTheory(int expectedNumber, MyClass sut)
        {
            int result = sut.Echo(expectedNumber);
            Assert.Equal(expectedNumber, result);
        }
    }

    public class MyClass
    {
        public int Echo(in int number)
        {
            return number;
        }
    }
}
