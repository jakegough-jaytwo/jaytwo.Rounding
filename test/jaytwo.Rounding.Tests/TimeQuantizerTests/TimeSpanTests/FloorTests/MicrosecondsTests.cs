using System;
using Xunit;

namespace jaytwo.Rounding.Tests.TimeQuantizerTests.TimeSpanTests.FloorTests;

#if NET7_0_OR_GREATER
public class MicrosecondsTests : TimeSpanQuantizeTests
{
    [Theory]
    [MemberData(nameof(FloorCases))]
    public void Floor_Microseconds_Returns_Expected(double value, double expected)
        => MicrosecondsTest(value, expected, x => TimeQuantizer.FloorMicroseconds(x));

    [Theory]
    [MemberData(nameof(FloorCases))]
    public void Quantize_Floor_Microseconds_Returns_Expected(double value, double expected)
        => MicrosecondsTest(value, expected, x => TimeQuantizer.Quantize(x, TimePrecision.Microsecond, QuantizationMode.Floor));

    [Theory]
    [MemberData(nameof(FloorCases))]
    public void QuantizeMicroseconds_Floor_Returns_Expected(double value, double expected)
        => MicrosecondsTest(value, expected, x => TimeQuantizer.QuantizeMicroseconds(x, QuantizationMode.Floor));

    [Theory]
    [MemberData(nameof(FloorCases))]
    public void Instance_Quantize_Floor_Microseconds_Returns_Expected(double value, double expected)
        => MicrosecondsTest(value, expected, x => new TimeQuantizer(TimePrecision.Microsecond, QuantizationMode.Floor).Quantize(x));

    [Theory]
    [MemberData(nameof(FloorCases))]
    public void Extension_Floor_Microseconds_Returns_Expected(double value, double expected)
        => MicrosecondsTest(value, expected, x => x.FloorMicroseconds());

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(FloorCases))]
    public void Nullable_Floor_Microseconds_Returns_Expected(double? value, double? expected)
        => Nullable_MicrosecondsTest(value, expected, x => TimeQuantizer.FloorMicroseconds(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(FloorCases))]
    public void Nullable_Quantize_Floor_Microseconds_Returns_Expected(double? value, double? expected)
        => Nullable_MicrosecondsTest(value, expected, x => TimeQuantizer.Quantize(x, TimePrecision.Microsecond, QuantizationMode.Floor));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(FloorCases))]
    public void Nullable_QuantizeMicroseconds_Floor_Returns_Expected(double? value, double? expected)
        => Nullable_MicrosecondsTest(value, expected, x => TimeQuantizer.QuantizeMicroseconds(x, QuantizationMode.Floor));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(FloorCases))]
    public void Nullable_Instance_Quantize_Floor_Microseconds_Returns_Expected(double? value, double? expected)
        => Nullable_MicrosecondsTest(value, expected, x => new TimeQuantizer(TimePrecision.Microsecond, QuantizationMode.Floor).Quantize(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(FloorCases))]
    public void Nullable_Extension_Floor_Microseconds_Returns_Expected(double? value, double? expected)
        => Nullable_MicrosecondsTest(value, expected, x => x.FloorMicroseconds());
}
#endif
