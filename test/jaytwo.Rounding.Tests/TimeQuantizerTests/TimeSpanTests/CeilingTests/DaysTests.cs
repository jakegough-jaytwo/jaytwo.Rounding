using System;
using Xunit;

namespace jaytwo.Rounding.Tests.TimeQuantizerTests.TimeSpanTests.CeilingTests;

public class DaysTests : TimeSpanQuantizeTests
{
    [Theory]
    [MemberData(nameof(CeilingCases))]
    public void Ceiling_Days_Returns_Expected(double value, double expected)
        => DaysTest(value, expected, x => TimeQuantizer.CeilingDays(x));

    [Theory]
    [MemberData(nameof(CeilingCases))]
    public void Quantize_Ceiling_Days_Returns_Expected(double value, double expected)
        => DaysTest(value, expected, x => TimeQuantizer.Quantize(x, TimePrecision.Day, QuantizationMode.Ceiling));

    [Theory]
    [MemberData(nameof(CeilingCases))]
    public void QuantizeDays_Ceiling_Returns_Expected(double value, double expected)
        => DaysTest(value, expected, x => TimeQuantizer.QuantizeDays(x, QuantizationMode.Ceiling));

    [Theory]
    [MemberData(nameof(CeilingCases))]
    public void Instance_Quantize_Ceiling_Days_Returns_Expected(double value, double expected)
        => DaysTest(value, expected, x => new TimeQuantizer(TimePrecision.Day, QuantizationMode.Ceiling).Quantize(x));

    [Theory]
    [MemberData(nameof(CeilingCases))]
    public void Extension_Ceiling_Days_Returns_Expected(double value, double expected)
        => DaysTest(value, expected, x => x.CeilingDays());

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(CeilingCases))]
    public void Nullable_Ceiling_Days_Returns_Expected(double? value, double? expected)
        => Nullable_DaysTest(value, expected, x => TimeQuantizer.CeilingDays(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(CeilingCases))]
    public void Nullable_Quantize_Ceiling_Days_Returns_Expected(double? value, double? expected)
        => Nullable_DaysTest(value, expected, x => TimeQuantizer.Quantize(x, TimePrecision.Day, QuantizationMode.Ceiling));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(CeilingCases))]
    public void Nullable_QuantizeDays_Ceiling_Returns_Expected(double? value, double? expected)
        => Nullable_DaysTest(value, expected, x => TimeQuantizer.QuantizeDays(x, QuantizationMode.Ceiling));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(CeilingCases))]
    public void Nullable_Instance_Quantize_Ceiling_Days_Returns_Expected(double? value, double? expected)
        => Nullable_DaysTest(value, expected, x => new TimeQuantizer(TimePrecision.Day, QuantizationMode.Ceiling).Quantize(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(CeilingCases))]
    public void Nullable_Extension_Ceiling_Days_Returns_Expected(double? value, double? expected)
        => Nullable_DaysTest(value, expected, x => x.CeilingDays());
}
