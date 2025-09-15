using Xunit;

namespace jaytwo.Rounding.Tests.TimeRounderTests.AwayFromZeroTests;

public class MicrosecondTests : AwayFromZeroTestCases
{
    [Theory]
    [MemberData(nameof(TestCases))]
    public void NearestMicrosecond_Returns_Expected(double value, double expected)
        => AssertNearestMicrosecond(value, expected, x => TimeRounder.NearestMicrosecond(x, RoundingMode));

    [Theory]
    [MemberData(nameof(TestCases))]
    public void Round_Microsecond_Returns_Expected(double value, double expected)
        => AssertNearestMicrosecond(value, expected, x => TimeRounder.Round(x, TimePrecision.Microsecond, RoundingMode));

    [Theory]
    [MemberData(nameof(TestCases))]
    public void Instance_Round_Microsecond_Returns_Expected(double value, double expected)
        => AssertNearestMicrosecond(value, expected, x => new TimeRounder(TimePrecision.Microsecond, RoundingMode).Round(x));

    [Theory]
    [MemberData(nameof(TestCases))]
    public void Extension_NearestMicrosecond_Returns_Expected(double value, double expected)
        => AssertNearestMicrosecond(value, expected, x => x.NearestMicrosecond(RoundingMode));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TestCases))]
    public void Nullable_NearestMicrosecond_Returns_Expected(double? value, double? expected)
        => NullableAssertNearestMicrosecond(value, expected, x => TimeRounder.NearestMicrosecond(x, RoundingMode));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TestCases))]
    public void Nullable_Round_Microsecond_Returns_Expected(double? value, double? expected)
        => NullableAssertNearestMicrosecond(value, expected, x => TimeRounder.Round(x, TimePrecision.Microsecond, RoundingMode));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TestCases))]
    public void Nullable_Instance_Round_Microsecond_Returns_Expected(double? value, double? expected)
        => NullableAssertNearestMicrosecond(value, expected, x => new TimeRounder(TimePrecision.Microsecond, RoundingMode).Round(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TestCases))]
    public void Nullable_Extension_NearestMicrosecond_Returns_Expected(double? value, double? expected)
        => NullableAssertNearestMicrosecond(value, expected, x => x.NearestMicrosecond(RoundingMode));
}
