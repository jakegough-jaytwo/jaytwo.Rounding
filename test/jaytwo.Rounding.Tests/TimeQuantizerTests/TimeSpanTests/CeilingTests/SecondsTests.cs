using System;
using Xunit;

namespace jaytwo.Rounding.Tests.TimeQuantizerTests.TimeSpanTests.CeilingTests;

public class SecondsTests : TimeSpanQuantizeTests
{
    [Theory]
    [MemberData(nameof(CeilingCases))]
    public void Ceiling_Seconds_Returns_Expected(double value, double expected)
        => SecondsTest(value, expected, x => TimeQuantizer.CeilingSeconds(x));

    [Theory]
    [MemberData(nameof(CeilingCases))]
    public void Quantize_Ceiling_Seconds_Returns_Expected(double value, double expected)
        => SecondsTest(value, expected, x => TimeQuantizer.Quantize(x, TimePrecision.Second, QuantizationMode.Ceiling));

    [Theory]
    [MemberData(nameof(CeilingCases))]
    public void QuantizeSeconds_Ceiling_Returns_Expected(double value, double expected)
        => SecondsTest(value, expected, x => TimeQuantizer.QuantizeSeconds(x, QuantizationMode.Ceiling));

    [Theory]
    [MemberData(nameof(CeilingCases))]
    public void Instance_Quantize_Ceiling_Seconds_Returns_Expected(double value, double expected)
        => SecondsTest(value, expected, x => new TimeQuantizer(TimePrecision.Second, QuantizationMode.Ceiling).Quantize(x));

    [Theory]
    [MemberData(nameof(CeilingCases))]
    public void Extension_Ceiling_Seconds_Returns_Expected(double value, double expected)
        => SecondsTest(value, expected, x => x.CeilingSeconds());

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(CeilingCases))]
    public void Nullable_Ceiling_Seconds_Returns_Expected(double? value, double? expected)
        => Nullable_SecondsTest(value, expected, x => TimeQuantizer.CeilingSeconds(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(CeilingCases))]
    public void Nullable_Quantize_Ceiling_Seconds_Returns_Expected(double? value, double? expected)
        => Nullable_SecondsTest(value, expected, x => TimeQuantizer.Quantize(x, TimePrecision.Second, QuantizationMode.Ceiling));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(CeilingCases))]
    public void Nullable_QuantizeSeconds_Ceiling_Returns_Expected(double? value, double? expected)
        => Nullable_SecondsTest(value, expected, x => TimeQuantizer.QuantizeSeconds(x, QuantizationMode.Ceiling));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(CeilingCases))]
    public void Nullable_Instance_Quantize_Ceiling_Seconds_Returns_Expected(double? value, double? expected)
        => Nullable_SecondsTest(value, expected, x => new TimeQuantizer(TimePrecision.Second, QuantizationMode.Ceiling).Quantize(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(CeilingCases))]
    public void Nullable_Extension_Ceiling_Seconds_Returns_Expected(double? value, double? expected)
        => Nullable_SecondsTest(value, expected, x => x.CeilingSeconds());
}
