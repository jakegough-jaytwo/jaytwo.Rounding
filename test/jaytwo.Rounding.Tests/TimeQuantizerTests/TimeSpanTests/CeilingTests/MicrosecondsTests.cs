using System;
using Xunit;

namespace jaytwo.Rounding.Tests.TimeQuantizerTests.TimeSpanTests.CeilingTests;

#if NET7_0_OR_GREATER
public class MicrosecondsTests : TimeSpanQuantizeTests
{
    [Theory]
    [MemberData(nameof(CeilingCases))]
    public void Ceiling_Microseconds_Returns_Expected(double value, double expected)
        => MicrosecondsTest(value, expected, x => TimeQuantizer.CeilingMicroseconds(x));

    [Theory]
    [MemberData(nameof(CeilingCases))]
    public void Quantize_Ceiling_Microseconds_Returns_Expected(double value, double expected)
        => MicrosecondsTest(value, expected, x => TimeQuantizer.Quantize(x, TimePrecision.Microsecond, QuantizationMode.Ceiling));

    [Theory]
    [MemberData(nameof(CeilingCases))]
    public void QuantizeMicroseconds_Ceiling_Returns_Expected(double value, double expected)
        => MicrosecondsTest(value, expected, x => TimeQuantizer.QuantizeMicroseconds(x, QuantizationMode.Ceiling));

    [Theory]
    [MemberData(nameof(CeilingCases))]
    public void Instance_Quantize_Ceiling_Microseconds_Returns_Expected(double value, double expected)
        => MicrosecondsTest(value, expected, x => new TimeQuantizer(TimePrecision.Microsecond, QuantizationMode.Ceiling).Quantize(x));

    [Theory]
    [MemberData(nameof(CeilingCases))]
    public void Extension_Ceiling_Microseconds_Returns_Expected(double value, double expected)
        => MicrosecondsTest(value, expected, x => x.CeilingMicroseconds());

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(CeilingCases))]
    public void Nullable_Ceiling_Microseconds_Returns_Expected(double? value, double? expected)
        => Nullable_MicrosecondsTest(value, expected, x => TimeQuantizer.CeilingMicroseconds(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(CeilingCases))]
    public void Nullable_Quantize_Ceiling_Microseconds_Returns_Expected(double? value, double? expected)
        => Nullable_MicrosecondsTest(value, expected, x => TimeQuantizer.Quantize(x, TimePrecision.Microsecond, QuantizationMode.Ceiling));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(CeilingCases))]
    public void Nullable_QuantizeMicroseconds_Ceiling_Returns_Expected(double? value, double? expected)
        => Nullable_MicrosecondsTest(value, expected, x => TimeQuantizer.QuantizeMicroseconds(x, QuantizationMode.Ceiling));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(CeilingCases))]
    public void Nullable_Instance_Quantize_Ceiling_Microseconds_Returns_Expected(double? value, double? expected)
        => Nullable_MicrosecondsTest(value, expected, x => new TimeQuantizer(TimePrecision.Microsecond, QuantizationMode.Ceiling).Quantize(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(CeilingCases))]
    public void Nullable_Extension_Ceiling_Microseconds_Returns_Expected(double? value, double? expected)
        => Nullable_MicrosecondsTest(value, expected, x => x.CeilingMicroseconds());
}
#endif
