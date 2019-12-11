using FluentAssertions;
using Luxonish;
using Luxonish.Zones;
using Tests.Utility;
using Xunit;

namespace Tests.DateTime
{
    [Trait(Trait.Category, Trait.UnitTest)]
    public class ToZone
    {
        [Fact]
        public void WithSameZone_ReturnSelf()
        {
            // arrange
            var now = System.DateTime.Now;
            var input = Luxonish.DateTime.FromSystemDateTime(now);
            var zone = Zone.Default;

            // act
            var actual = input.ToZone(zone);

            // assert
            actual.Should().Be(input);
        }
        [Fact]
        public void WithDifferentZone_ReturnAdjustedTime()
        {
            // arrange
            var now = System.DateTime.Now;
            var input = Luxonish.DateTime.FromSystemDateTime(now);
            var zone = new WindowsZone("Pacific Standard Time");

            // act
            var actual = input.ToZone(zone);

            // assert
            actual.ToMilliseconds().Should().Be(input.ToMilliseconds());  // Same actual time
            actual.Hour.Should().NotBe(input.Hour);                         // Different local time
        }

    }
}
