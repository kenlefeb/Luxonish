using FluentAssertions;
using Luxonish;
using Luxonish.Zones;
using System;
using Tests.Utility;
using Xunit;

namespace Tests.DateTime
{
    [Trait(Trait.Category, Trait.UnitTest)]
    public class FromDateTime
    {
        [Fact]
        public void ClonesDateTime()
        {
            // arrange test
            var input = new System.DateTime(1982, 4, 25, 0, 0, 0, DateTimeKind.Local);

            // act
            var actual = Luxonish.DateTime.FromSystemDateTime(input);

            // assert
            actual.ToMilliseconds().Should().Be(input.ToMilliseconds(), because: "DateTime.FromSystemDateTime(date) should clone the date");
        }

        [Fact]
        public void WithZone_UsesZone()
        {
            // arrange test
            var input = new System.DateTime(1982, 4, 25, 0, 0, 0, DateTimeKind.Local);

            // act
            var actual = Luxonish.DateTime.FromSystemDateTime(input, new IanaZone("America/Santiago"));

            // assert
            actual.ZoneName.Should().Be("America/Santiago", because: "DateTime.FromSystemDateTime(date) should accept a zone option");
        }
    }
}
