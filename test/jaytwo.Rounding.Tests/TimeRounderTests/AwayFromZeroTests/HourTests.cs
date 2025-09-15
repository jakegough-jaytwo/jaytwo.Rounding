using Xunit;

namespace jaytwo.Rounding.Tests.TimeRounderTests.AwayFromZeroTests;

public class HourTests : AwayFromZeroTestCases
{
    [Theory]
    [MemberData(nameof(TestCases))]
    public void NearestHour_Returns_Expected(double value, double expected)
        => AssertNearestHour(value, expected, x => TimeRounder.NearestHour(x, RoundingMode));

    [Theory]
    [MemberData(nameof(TestCases))]
    public void Round_Hour_Returns_Expected(double value, double expected)
        => AssertNearestHour(value, expected, x => TimeRounder.Round(x, TimePrecision.Hour, RoundingMode));

    [Theory]
    [MemberData(nameof(TestCases))]
    public void Instance_Round_Hour_Returns_Expected(double value, double expected)
        => AssertNearestHour(value, expected, x => new TimeRounder(TimePrecision.Hour, RoundingMode).Round(x));

    [Theory]
    [MemberData(nameof(TestCases))]
    public void Extension_NearestHour_Returns_Expected(double value, double expected)
        => AssertNearestHour(value, expected, x => x.NearestHour(RoundingMode));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TestCases))]
    public void Nullable_NearestHour_Returns_Expected(double? value, double? expected)
        => NullableAssertNearestHour(value, expected, x => TimeRounder.NearestHour(x, RoundingMode));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TestCases))]
    public void Nullable_Round_Hour_Returns_Expected(double? value, double? expected)
        => NullableAssertNearestHour(value, expected, x => TimeRounder.Round(x, TimePrecision.Hour, RoundingMode));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TestCases))]
    public void Nullable_Instance_Round_Hour_Returns_Expected(double? value, double? expected)
        => NullableAssertNearestHour(value, expected, x => new TimeRounder(TimePrecision.Hour, RoundingMode).Round(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TestCases))]
    public void Nullable_Extension_NearestHour_Returns_Expected(double? value, double? expected)
        => NullableAssertNearestHour(value, expected, x => x.NearestHour(RoundingMode));
}
