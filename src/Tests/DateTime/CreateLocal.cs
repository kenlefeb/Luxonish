using FluentAssertions;
using Luxonish;
using Tests.Utility;
using Xunit;

namespace Tests.DateTime
{
    [Trait(Trait.Category, Trait.UnitTest)]
    public class CreateLocal
    {
        [Fact]
        public void NoParameters_ReturnsNow()
        {
            // act
            var actual = Luxonish.DateTime.CreateLocal();

            // assert
            actual.ToSystemDateTime().Should().BeCloseTo(System.DateTime.Now, because: "DateTime.CreateLocal() should return today's date");
        }

        [Fact]
        public void WithYear_ReturnsBeginningOfYear()
        {
            // act
            var actual = Luxonish.DateTime.CreateLocal(2017);

            // assert
            actual.Year.Should().Be(2017, because: "DateTime.CreateLocal(2017) is the beginning of the year");
            actual.Month.Should().Be(1);
            actual.Day.Should().Be(1);
            actual.Hour.Should().Be(0);
            actual.Minute.Should().Be(0);
            actual.Second.Should().Be(0);
            actual.Millisecond.Should().Be(0);
        }

        [Fact]
        public void WithYearAndMonth_ReturnsBeginningOfMonth()
        {
            // act
            var actual = Luxonish.DateTime.CreateLocal(2017, 6);

            // assert
            actual.Year.Should().Be(2017, because: "DateTime.CreateLocal(2017, 6) is the beginning of the month");
            actual.Month.Should().Be(6);
            actual.Day.Should().Be(1);
            actual.Hour.Should().Be(0);
            actual.Minute.Should().Be(0);
            actual.Second.Should().Be(0);
            actual.Millisecond.Should().Be(0);
        }

        [Fact]
        public void WithYearMonthAndDay_ReturnsBeginningOfDay()
        {
            // act
            var actual = Luxonish.DateTime.CreateLocal(2017, 6, 12);

            // assert
            actual.Year.Should().Be(2017, because: "DateTime.CreateLocal(2017, 6, 12) is the beginning of 6/12");
            actual.Month.Should().Be(6);
            actual.Day.Should().Be(12);
            actual.Hour.Should().Be(0);
            actual.Minute.Should().Be(0);
            actual.Second.Should().Be(0);
            actual.Millisecond.Should().Be(0);
        }

        [Fact]
        public void WithYearMonthDayAndHour_ReturnsBeginningOfHour()
        {
            // act
            var actual = Luxonish.DateTime.CreateLocal(2017, 6, 12, 5);

            // assert
            actual.Year.Should().Be(2017, because: "DateTime.CreateLocal(2017, 6, 12, 5) is the beginning of the hour");
            actual.Month.Should().Be(6);
            actual.Day.Should().Be(12);
            actual.Hour.Should().Be(5);
            actual.Minute.Should().Be(0);
            actual.Second.Should().Be(0);
            actual.Millisecond.Should().Be(0);
        }

        [Fact]
        public void WithYearMonthDayHourAndMinute_ReturnsBeginningOfMinute()
        {
            // act
            var actual = Luxonish.DateTime.CreateLocal(2017, 6, 12, 5, 25);

            // assert
            actual.Year.Should().Be(2017, because: "DateTime.CreateLocal(2017, 6, 12, 5, 25) is the beginning of the minute");
            actual.Month.Should().Be(6);
            actual.Day.Should().Be(12);
            actual.Hour.Should().Be(5);
            actual.Minute.Should().Be(25);
            actual.Second.Should().Be(0);
            actual.Millisecond.Should().Be(0);
        }

        [Fact]
        public void WithYearMonthDayHourMinuteAndSecond_ReturnsBeginningOfSecond()
        {
            // act
            var actual = Luxonish.DateTime.CreateLocal(2017, 6, 12, 5, 25, 16);

            // assert
            actual.Year.Should().Be(2017, because: "DateTime.CreateLocal(2017, 6, 12, 5, 25, 16) is the beginning of the second");
            actual.Month.Should().Be(6);
            actual.Day.Should().Be(12);
            actual.Hour.Should().Be(5);
            actual.Minute.Should().Be(25);
            actual.Second.Should().Be(16);
            actual.Millisecond.Should().Be(0);
        }

        [Fact]
        public void WithYearMonthDayHourMinuteSecondAndMillisecond_ReturnsInstant()
        {
            // act
            var actual = Luxonish.DateTime.CreateLocal(2017, 6, 12, 5, 25, 16, 255);

            // assert
            actual.Year.Should().Be(2017, because: "DateTime.CreateLocal(2017, 6, 12, 5, 25, 16, 255) is right down to the millisecond");
            actual.Month.Should().Be(6);
            actual.Day.Should().Be(12);
            actual.Hour.Should().Be(5);
            actual.Minute.Should().Be(25);
            actual.Second.Should().Be(16);
            actual.Millisecond.Should().Be(255);
        }

        [Fact]
        public void WithDefaultLocale_UsesLocale()
        {
            // arrange
            var settings = new Settings { DefaultLocale = "fr" };

            // act
            var actual = Luxonish.DateTime.CreateLocal(settings: settings);

            // assert
            actual.Locale.Should().Be("fr", because: "DateTime.local accepts the default locale");
        }

        [Fact]
        public void WithDefaultNumberingSystem_UsesNumberingSystem()
        {
            // arrange
            var settings = Settings.Default;
            settings["DefaultNumberingSystem"] = "beng";

            // act
            var actual = Luxonish.DateTime.CreateLocal(settings: settings);

            // assert
            actual.NumberingSystem.Should().Be("beng", because: "DateTime.local accepts the default numbering system");
        }

        [Fact]
        public void WithDefaultOutputCalendar_UsesOutputCalendar()
        {
            // arrange
            var settings = Settings.Default;
            settings["DefaultOutputCalendar"] = "hebrew";

            // act
            var actual = Luxonish.DateTime.CreateLocal(settings: settings);

            // assert
            actual.OutputCalendar.Should().Be("hebrew", because: "DateTime.local accepts the default output calendar");
        }
    }
}
