using System;
using Xunit;

namespace jaytwo.Rounding.Tests.TimeQuantizerTests.TimeSpanTests.FloorTests;

public class MillisecondsTests : TimeSpanQuantizeTests
{
    [Theory]
    [MemberData(nameof(FloorCases))]
    public void Floor_Milliseconds_Returns_Expected(double value, double expected)
        => MillisecondsTest(value, expected, x => TimeQuantizer.FloorMilliseconds(x));

    [Theory]
    [MemberData(nameof(FloorCases))]
    public void Quantize_Floor_Milliseconds_Returns_Expected(double value, double expected)
        => MillisecondsTest(value, expected, x => TimeQuantizer.Quantize(x, TimePrecision.Millisecond, QuantizationMode.Floor));

    [Theory]
    [MemberData(nameof(FloorCases))]
    public void QuantizeMilliseconds_Floor_Returns_Expected(double value, double expected)
        => MillisecondsTest(value, expected, x => TimeQuantizer.QuantizeMilliseconds(x, QuantizationMode.Floor));

    [Theory]
    [MemberData(nameof(FloorCases))]
    public void Instance_Quantize_Floor_Milliseconds_Returns_Expected(double value, double expected)
        => MillisecondsTest(value, expected, x => new TimeQuantizer(TimePrecision.Millisecond, QuantizationMode.Floor).Quantize(x));

    [Theory]
    [MemberData(nameof(FloorCases))]
    public void Extension_Floor_Milliseconds_Returns_Expected(double value, double expected)
        => MillisecondsTest(value, expected, x => x.FloorMilliseconds());

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(FloorCases))]
    public void Nullable_Floor_Milliseconds_Returns_Expected(double? value, double? expected)
        => Nullable_MillisecondsTest(value, expected, x => TimeQuantizer.FloorMilliseconds(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(FloorCases))]
    public void Nullable_Quantize_Floor_Milliseconds_Returns_Expected(double? value, double? expected)
        => Nullable_MillisecondsTest(value, expected, x => TimeQuantizer.Quantize(x, TimePrecision.Millisecond, QuantizationMode.Floor));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(FloorCases))]
    public void Nullable_QuantizeMilliseconds_Floor_Returns_Expected(double? value, double? expected)
        => Nullable_MillisecondsTest(value, expected, x => TimeQuantizer.QuantizeMilliseconds(x, QuantizationMode.Floor));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(FloorCases))]
    public void Nullable_Instance_Quantize_Floor_Milliseconds_Returns_Expected(double? value, double? expected)
        => Nullable_MillisecondsTest(value, expected, x => new TimeQuantizer(TimePrecision.Millisecond, QuantizationMode.Floor).Quantize(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(FloorCases))]
    public void Nullable_Extension_Floor_Milliseconds_Returns_Expected(double? value, double? expected)
        => Nullable_MillisecondsTest(value, expected, x => x.FloorMilliseconds());
}
