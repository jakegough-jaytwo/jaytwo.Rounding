using Xunit;

namespace jaytwo.Rounding.Tests.TimeRounderTests.AwayFromZeroTests;

public class SecondTests : AwayFromZeroTestCases
{
    [Theory]
    [MemberData(nameof(TestCases))]
    public void NearestSecond_Returns_Expected(double value, double expected)
        => AssertNearestSecond(value, expected, x => TimeRounder.NearestSecond(x, RoundingMode));

    [Theory]
    [MemberData(nameof(TestCases))]
    public void Round_Second_Returns_Expected(double value, double expected)
        => AssertNearestSecond(value, expected, x => TimeRounder.Round(x, TimePrecision.Second, RoundingMode));

    [Theory]
    [MemberData(nameof(TestCases))]
    public void Instance_Round_Second_Returns_Expected(double value, double expected)
        => AssertNearestSecond(value, expected, x => new TimeRounder(TimePrecision.Second, RoundingMode).Round(x));

    [Theory]
    [MemberData(nameof(TestCases))]
    public void Extension_NearestSecond_Returns_Expected(double value, double expected)
        => AssertNearestSecond(value, expected, x => x.NearestSecond(RoundingMode));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TestCases))]
    public void Nullable_NearestSecond_Returns_Expected(double? value, double? expected)
        => NullableAssertNearestSecond(value, expected, x => TimeRounder.NearestSecond(x, RoundingMode));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TestCases))]
    public void Nullable_Round_Second_Returns_Expected(double? value, double? expected)
        => NullableAssertNearestSecond(value, expected, x => TimeRounder.Round(x, TimePrecision.Second, RoundingMode));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TestCases))]
    public void Nullable_Instance_Round_Second_Returns_Expected(double? value, double? expected)
        => NullableAssertNearestSecond(value, expected, x => new TimeRounder(TimePrecision.Second, RoundingMode).Round(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TestCases))]
    public void Nullable_Extension_NearestSecond_Returns_Expected(double? value, double? expected)
        => NullableAssertNearestSecond(value, expected, x => x.NearestSecond(RoundingMode));
}
