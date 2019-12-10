using FluentAssertions;
using Luxonish;
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
            actual.ToEpochTime(EpochTimeKind.Milliseconds).Should().Be(milliseconds);

        }

        /*

            test("DateTime.fromMillis(ms) accepts a zone option", () => {
              const value = 391147200000,
                dateTime = DateTime.fromMillis(value, { zone: "America/Santiago" });

              expect(dateTime.valueOf()).toBe(value);
              expect(dateTime.zoneName).toBe("America/Santiago");
            });

            test("DateTime.fromMillis accepts the default locale", () => {
              withDefaultLocale("fr", () => expect(DateTime.fromMillis(391147200000).locale).toBe("fr"));
            });

            test("DateTime.fromMillis(ms) throws InvalidArgumentError for non-numeric input", () => {
              expect(() => DateTime.fromMillis("slurp")).toThrow();
            });

            test("DateTime.fromMillis(ms) does not accept out-of-bounds numbers", () => {
              expect(DateTime.fromMillis(-8.64e15 - 1).isValid).toBe(false);
              expect(DateTime.fromMillis(8.64e15 + 1).isValid).toBe(false);
            });

         */
    }
}
