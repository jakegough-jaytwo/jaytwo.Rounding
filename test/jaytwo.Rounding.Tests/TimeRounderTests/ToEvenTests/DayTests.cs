using Xunit;

namespace jaytwo.Rounding.Tests.TimeRounderTests.ToEvenTests;

public class DayTests : ToEvenTestCases
{
    [Theory]
    [MemberData(nameof(TestCases))]
    public void NearestDay_Returns_Expected(double value, double expected)
        => AssertNearestDay(value, expected, x => TimeRounder.NearestDay(x, RoundingMode));

    [Theory]
    [MemberData(nameof(TestCases))]
    public void Round_Day_Returns_Expected(double value, double expected)
        => AssertNearestDay(value, expected, x => TimeRounder.Round(x, TimePrecision.Day, RoundingMode));

    [Theory]
    [MemberData(nameof(TestCases))]
    public void Instance_Round_Day_Returns_Expected(double value, double expected)
        => AssertNearestDay(value, expected, x => new TimeRounder(TimePrecision.Day, RoundingMode).Round(x));

    [Theory]
    [MemberData(nameof(TestCases))]
    public void Extension_NearestDay_Returns_Expected(double value, double expected)
        => AssertNearestDay(value, expected, x => x.NearestDay(RoundingMode));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TestCases))]
    public void Nullable_NearestDay_Returns_Expected(double? value, double? expected)
        => NullableAssertNearestDay(value, expected, x => TimeRounder.NearestDay(x, RoundingMode));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TestCases))]
    public void Nullable_Round_Day_Returns_Expected(double? value, double? expected)
        => NullableAssertNearestDay(value, expected, x => TimeRounder.Round(x, TimePrecision.Day, RoundingMode));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TestCases))]
    public void Nullable_Instance_Round_Day_Returns_Expected(double? value, double? expected)
        => NullableAssertNearestDay(value, expected, x => new TimeRounder(TimePrecision.Day, RoundingMode).Round(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TestCases))]
    public void Nullable_Extension_NearestDay_Returns_Expected(double? value, double? expected)
        => NullableAssertNearestDay(value, expected, x => x.NearestDay(RoundingMode));
}
