using System;
using Xunit;

namespace jaytwo.Rounding.Tests.TimeQuantizerTests.TimeSpanTests.CeilingTests;

public class HoursTests : TimeSpanQuantizeTests
{
    [Theory]
    [MemberData(nameof(CeilingCases))]
    public void Ceiling_Hours_Returns_Expected(double value, double expected)
        => HoursTest(value, expected, x => TimeQuantizer.CeilingHours(x));

    [Theory]
    [MemberData(nameof(CeilingCases))]
    public void Quantize_Ceiling_Hours_Returns_Expected(double value, double expected)
        => HoursTest(value, expected, x => TimeQuantizer.Quantize(x, TimePrecision.Hour, QuantizationMode.Ceiling));

    [Theory]
    [MemberData(nameof(CeilingCases))]
    public void QuantizeHours_Ceiling_Returns_Expected(double value, double expected)
        => HoursTest(value, expected, x => TimeQuantizer.QuantizeHours(x, QuantizationMode.Ceiling));

    [Theory]
    [MemberData(nameof(CeilingCases))]
    public void Instance_Quantize_Ceiling_Hours_Returns_Expected(double value, double expected)
        => HoursTest(value, expected, x => new TimeQuantizer(TimePrecision.Hour, QuantizationMode.Ceiling).Quantize(x));

    [Theory]
    [MemberData(nameof(CeilingCases))]
    public void Extension_Ceiling_Hours_Returns_Expected(double value, double expected)
        => HoursTest(value, expected, x => x.CeilingHours());

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(CeilingCases))]
    public void Nullable_Ceiling_Hours_Returns_Expected(double? value, double? expected)
        => Nullable_HoursTest(value, expected, x => TimeQuantizer.CeilingHours(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(CeilingCases))]
    public void Nullable_Quantize_Ceiling_Hours_Returns_Expected(double? value, double? expected)
        => Nullable_HoursTest(value, expected, x => TimeQuantizer.Quantize(x, TimePrecision.Hour, QuantizationMode.Ceiling));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(CeilingCases))]
    public void Nullable_QuantizeHours_Ceiling_Returns_Expected(double? value, double? expected)
        => Nullable_HoursTest(value, expected, x => TimeQuantizer.QuantizeHours(x, QuantizationMode.Ceiling));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(CeilingCases))]
    public void Nullable_Instance_Quantize_Ceiling_Hours_Returns_Expected(double? value, double? expected)
        => Nullable_HoursTest(value, expected, x => new TimeQuantizer(TimePrecision.Hour, QuantizationMode.Ceiling).Quantize(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(CeilingCases))]
    public void Nullable_Extension_Ceiling_Hours_Returns_Expected(double? value, double? expected)
        => Nullable_HoursTest(value, expected, x => x.CeilingHours());
}
