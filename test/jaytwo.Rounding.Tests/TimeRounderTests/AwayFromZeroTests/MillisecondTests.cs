using Xunit;

namespace jaytwo.Rounding.Tests.TimeRounderTests.AwayFromZeroTests;

public class MillisecondTests : AwayFromZeroTestCases
{
    [Theory]
    [MemberData(nameof(TestCases))]
    public void NearestMillisecond_Returns_Expected(double value, double expected)
        => AssertNearestMillisecond(value, expected, x => TimeRounder.NearestMillisecond(x, RoundingMode));

    [Theory]
    [MemberData(nameof(TestCases))]
    public void Round_Millisecond_Returns_Expected(double value, double expected)
        => AssertNearestMillisecond(value, expected, x => TimeRounder.Round(x, TimePrecision.Millisecond, RoundingMode));

    [Theory]
    [MemberData(nameof(TestCases))]
    public void Instance_Round_Millisecond_Returns_Expected(double value, double expected)
        => AssertNearestMillisecond(value, expected, x => new TimeRounder(TimePrecision.Millisecond, RoundingMode).Round(x));

    [Theory]
    [MemberData(nameof(TestCases))]
    public void Extension_NearestMillisecond_Returns_Expected(double value, double expected)
        => AssertNearestMillisecond(value, expected, x => x.NearestMillisecond(RoundingMode));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TestCases))]
    public void Nullable_NearestMillisecond_Returns_Expected(double? value, double? expected)
        => NullableAssertNearestMillisecond(value, expected, x => TimeRounder.NearestMillisecond(x, RoundingMode));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TestCases))]
    public void Nullable_Round_Millisecond_Returns_Expected(double? value, double? expected)
        => NullableAssertNearestMillisecond(value, expected, x => TimeRounder.Round(x, TimePrecision.Millisecond, RoundingMode));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TestCases))]
    public void Nullable_Instance_Round_Millisecond_Returns_Expected(double? value, double? expected)
        => NullableAssertNearestMillisecond(value, expected, x => new TimeRounder(TimePrecision.Millisecond, RoundingMode).Round(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TestCases))]
    public void Nullable_Extension_NearestMillisecond_Returns_Expected(double? value, double? expected)
        => NullableAssertNearestMillisecond(value, expected, x => x.NearestMillisecond(RoundingMode));
}
