using System;
using Xunit;

namespace jaytwo.Rounding.Tests.TimeQuantizerTests.TimeSpanTests.FloorTests;

public class SecondsTests : TimeSpanQuantizeTests
{
    [Theory]
    [MemberData(nameof(FloorCases))]
    public void Floor_Seconds_Returns_Expected(double value, double expected)
        => SecondsTest(value, expected, x => TimeQuantizer.FloorSeconds(x));

    [Theory]
    [MemberData(nameof(FloorCases))]
    public void Quantize_Floor_Seconds_Returns_Expected(double value, double expected)
        => SecondsTest(value, expected, x => TimeQuantizer.Quantize(x, TimePrecision.Second, QuantizationMode.Floor));

    [Theory]
    [MemberData(nameof(FloorCases))]
    public void QuantizeSeconds_Floor_Returns_Expected(double value, double expected)
        => SecondsTest(value, expected, x => TimeQuantizer.QuantizeSeconds(x, QuantizationMode.Floor));

    [Theory]
    [MemberData(nameof(FloorCases))]
    public void Instance_Quantize_Floor_Seconds_Returns_Expected(double value, double expected)
        => SecondsTest(value, expected, x => new TimeQuantizer(TimePrecision.Second, QuantizationMode.Floor).Quantize(x));

    [Theory]
    [MemberData(nameof(FloorCases))]
    public void Extension_Floor_Seconds_Returns_Expected(double value, double expected)
        => SecondsTest(value, expected, x => x.FloorSeconds());

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(FloorCases))]
    public void Nullable_Floor_Seconds_Returns_Expected(double? value, double? expected)
        => Nullable_SecondsTest(value, expected, x => TimeQuantizer.FloorSeconds(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(FloorCases))]
    public void Nullable_Quantize_Floor_Seconds_Returns_Expected(double? value, double? expected)
        => Nullable_SecondsTest(value, expected, x => TimeQuantizer.Quantize(x, TimePrecision.Second, QuantizationMode.Floor));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(FloorCases))]
    public void Nullable_QuantizeSeconds_Floor_Returns_Expected(double? value, double? expected)
        => Nullable_SecondsTest(value, expected, x => TimeQuantizer.QuantizeSeconds(x, QuantizationMode.Floor));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(FloorCases))]
    public void Nullable_Instance_Quantize_Floor_Seconds_Returns_Expected(double? value, double? expected)
        => Nullable_SecondsTest(value, expected, x => new TimeQuantizer(TimePrecision.Second, QuantizationMode.Floor).Quantize(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(FloorCases))]
    public void Nullable_Extension_Floor_Seconds_Returns_Expected(double? value, double? expected)
        => Nullable_SecondsTest(value, expected, x => x.FloorSeconds());
}
