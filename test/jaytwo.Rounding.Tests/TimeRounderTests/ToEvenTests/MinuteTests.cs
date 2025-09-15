using Xunit;

namespace jaytwo.Rounding.Tests.TimeRounderTests.ToEvenTests;

public class MinuteTests : ToEvenTestCases
{
    [Theory]
    [MemberData(nameof(TestCases))]
    public void NearestMinute_Returns_Expected(double value, double expected)
        => AssertNearestMinute(value, expected, x => TimeRounder.NearestMinute(x, RoundingMode));

    [Theory]
    [MemberData(nameof(TestCases))]
    public void Round_Minute_Returns_Expected(double value, double expected)
        => AssertNearestMinute(value, expected, x => TimeRounder.Round(x, TimePrecision.Minute, RoundingMode));

    [Theory]
    [MemberData(nameof(TestCases))]
    public void Instance_Round_Minute_Returns_Expected(double value, double expected)
        => AssertNearestMinute(value, expected, x => new TimeRounder(TimePrecision.Minute, RoundingMode).Round(x));

    [Theory]
    [MemberData(nameof(TestCases))]
    public void Extension_NearestMinute_Returns_Expected(double value, double expected)
        => AssertNearestMinute(value, expected, x => x.NearestMinute(RoundingMode));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TestCases))]
    public void Nullable_NearestMinute_Returns_Expected(double? value, double? expected)
        => NullableAssertNearestMinute(value, expected, x => TimeRounder.NearestMinute(x, RoundingMode));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TestCases))]
    public void Nullable_Round_Minute_Returns_Expected(double? value, double? expected)
        => NullableAssertNearestMinute(value, expected, x => TimeRounder.Round(x, TimePrecision.Minute, RoundingMode));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TestCases))]
    public void Nullable_Instance_Round_Minute_Returns_Expected(double? value, double? expected)
        => NullableAssertNearestMinute(value, expected, x => new TimeRounder(TimePrecision.Minute, RoundingMode).Round(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TestCases))]
    public void Nullable_Extension_NearestMinute_Returns_Expected(double? value, double? expected)
        => NullableAssertNearestMinute(value, expected, x => x.NearestMinute(RoundingMode));
}
