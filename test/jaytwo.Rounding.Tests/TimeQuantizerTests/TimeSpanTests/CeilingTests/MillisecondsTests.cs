using System;
using Xunit;

namespace jaytwo.Rounding.Tests.TimeQuantizerTests.TimeSpanTests.CeilingTests;

public class MillisecondsTests : TimeSpanQuantizeTests
{
    [Theory]
    [MemberData(nameof(CeilingCases))]
    public void Ceiling_Milliseconds_Returns_Expected(double value, double expected)
        => MillisecondsTest(value, expected, x => TimeQuantizer.CeilingMilliseconds(x));

    [Theory]
    [MemberData(nameof(CeilingCases))]
    public void Quantize_Ceiling_Milliseconds_Returns_Expected(double value, double expected)
        => MillisecondsTest(value, expected, x => TimeQuantizer.Quantize(x, TimePrecision.Millisecond, QuantizationMode.Ceiling));

    [Theory]
    [MemberData(nameof(CeilingCases))]
    public void QuantizeMilliseconds_Ceiling_Returns_Expected(double value, double expected)
        => MillisecondsTest(value, expected, x => TimeQuantizer.QuantizeMilliseconds(x, QuantizationMode.Ceiling));

    [Theory]
    [MemberData(nameof(CeilingCases))]
    public void Instance_Quantize_Ceiling_Milliseconds_Returns_Expected(double value, double expected)
        => MillisecondsTest(value, expected, x => new TimeQuantizer(TimePrecision.Millisecond, QuantizationMode.Ceiling).Quantize(x));

    [Theory]
    [MemberData(nameof(CeilingCases))]
    public void Extension_Ceiling_Milliseconds_Returns_Expected(double value, double expected)
        => MillisecondsTest(value, expected, x => x.CeilingMilliseconds());

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(CeilingCases))]
    public void Nullable_Ceiling_Milliseconds_Returns_Expected(double? value, double? expected)
        => Nullable_MillisecondsTest(value, expected, x => TimeQuantizer.CeilingMilliseconds(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(CeilingCases))]
    public void Nullable_Quantize_Ceiling_Milliseconds_Returns_Expected(double? value, double? expected)
        => Nullable_MillisecondsTest(value, expected, x => TimeQuantizer.Quantize(x, TimePrecision.Millisecond, QuantizationMode.Ceiling));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(CeilingCases))]
    public void Nullable_QuantizeMilliseconds_Ceiling_Returns_Expected(double? value, double? expected)
        => Nullable_MillisecondsTest(value, expected, x => TimeQuantizer.QuantizeMilliseconds(x, QuantizationMode.Ceiling));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(CeilingCases))]
    public void Nullable_Instance_Quantize_Ceiling_Milliseconds_Returns_Expected(double? value, double? expected)
        => Nullable_MillisecondsTest(value, expected, x => new TimeQuantizer(TimePrecision.Millisecond, QuantizationMode.Ceiling).Quantize(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(CeilingCases))]
    public void Nullable_Extension_Ceiling_Milliseconds_Returns_Expected(double? value, double? expected)
        => Nullable_MillisecondsTest(value, expected, x => x.CeilingMilliseconds());
}
