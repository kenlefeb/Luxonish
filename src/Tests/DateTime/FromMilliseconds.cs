using FluentAssertions;
using Luxonish;
using Luxonish.Zones;
using System;
using Tests.Utility;
using Xunit;

namespace Tests.DateTime
{
    [Trait(Trait.Category, Trait.UnitTest)]
    public class FromMilliseconds
    {

        [Theory]
        [InlineData(391147200000)]
        [InlineData(0)]
        public void FromMilliseconds_CreatesDateTime(long milliseconds)
        {
            // act
            var actual = Luxonish.DateTime.FromMilliseconds(milliseconds);

            // assert
            actual.ToMilliseconds().Should().Be(milliseconds);

        }

        [Fact]
        public void WithDefaultLocale_UsesLocale()
        {
            // arrange
            var settings = new Settings { DefaultLocale = "fr" };

            // act
            var actual = Luxonish.DateTime.FromMilliseconds(391147200000, settings: settings);

            // assert
            actual.Locale.Should().Be("fr", because: "DateTime.FromMilliseconds(milliseconds) should use the default locale setting");
        }

        [Fact]
        public void WithDefaultNumberingSystem_UsesNumberingSystem()
        {
            // arrange
            var settings = Settings.Default;
            settings["DefaultNumberingSystem"] = "beng";

            // act
            var actual = Luxonish.DateTime.FromMilliseconds(391147200000, settings: settings);

            // assert
            actual.NumberingSystem.Should().Be("beng", because: "DateTime.CreateLocal() should use the default numbering system");
        }

        [Fact]
        public void WithDefaultOutputCalendar_UsesOutputCalendar()
        {
            // arrange
            var settings = Settings.Default;
            settings["DefaultOutputCalendar"] = "hebrew";

            // act
            var actual = Luxonish.DateTime.FromMilliseconds(391147200000, settings: settings);

            // assert
            actual.OutputCalendar.Should().Be("hebrew", because: "DateTime.CreateLocal() should use the default output calendar");
        }

        [Fact]
        public void WithZone_UsesZone()
        {
            // arrange test
            var input = new System.DateTime(1982, 4, 25, 0, 0, 0, DateTimeKind.Local);

            // act
            var actual = Luxonish.DateTime.FromMilliseconds(391147200000, new IanaZone("America/Santiago"));

            // assert
            actual.ZoneName.Should().Be("America/Santiago", because: "DateTime.FromSystemDateTime(date) should accept a zone option");
        }
    }
}
