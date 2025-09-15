using System;
using Xunit;

namespace jaytwo.Rounding.Tests.TimeQuantizerTests.TimeSpanTests.CeilingTests;

public class MinutesTests : TimeSpanQuantizeTests
{
    [Theory]
    [MemberData(nameof(CeilingCases))]
    public void Ceiling_Minutes_Returns_Expected(double value, double expected)
        => MinutesTest(value, expected, x => TimeQuantizer.CeilingMinutes(x));

    [Theory]
    [MemberData(nameof(CeilingCases))]
    public void Quantize_Ceiling_Minutes_Returns_Expected(double value, double expected)
        => MinutesTest(value, expected, x => TimeQuantizer.Quantize(x, TimePrecision.Minute, QuantizationMode.Ceiling));

    [Theory]
    [MemberData(nameof(CeilingCases))]
    public void QuantizeMinutes_Ceiling_Returns_Expected(double value, double expected)
        => MinutesTest(value, expected, x => TimeQuantizer.QuantizeMinutes(x, QuantizationMode.Ceiling));

    [Theory]
    [MemberData(nameof(CeilingCases))]
    public void Instance_Quantize_Ceiling_Minutes_Returns_Expected(double value, double expected)
        => MinutesTest(value, expected, x => new TimeQuantizer(TimePrecision.Minute, QuantizationMode.Ceiling).Quantize(x));

    [Theory]
    [MemberData(nameof(CeilingCases))]
    public void Extension_Ceiling_Minutes_Returns_Expected(double value, double expected)
        => MinutesTest(value, expected, x => x.CeilingMinutes());

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(CeilingCases))]
    public void Nullable_Ceiling_Minutes_Returns_Expected(double? value, double? expected)
        => Nullable_MinutesTest(value, expected, x => TimeQuantizer.CeilingMinutes(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(CeilingCases))]
    public void Nullable_Quantize_Ceiling_Minutes_Returns_Expected(double? value, double? expected)
        => Nullable_MinutesTest(value, expected, x => TimeQuantizer.Quantize(x, TimePrecision.Minute, QuantizationMode.Ceiling));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(CeilingCases))]
    public void Nullable_QuantizeMinutes_Ceiling_Returns_Expected(double? value, double? expected)
        => Nullable_MinutesTest(value, expected, x => TimeQuantizer.QuantizeMinutes(x, QuantizationMode.Ceiling));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(CeilingCases))]
    public void Nullable_Instance_Quantize_Ceiling_Minutes_Returns_Expected(double? value, double? expected)
        => Nullable_MinutesTest(value, expected, x => new TimeQuantizer(TimePrecision.Minute, QuantizationMode.Ceiling).Quantize(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(CeilingCases))]
    public void Nullable_Extension_Ceiling_Minutes_Returns_Expected(double? value, double? expected)
        => Nullable_MinutesTest(value, expected, x => x.CeilingMinutes());
}
