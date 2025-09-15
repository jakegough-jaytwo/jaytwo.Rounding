using System;
using Xunit;

namespace jaytwo.Rounding.Tests.TimeQuantizerTests.TimeSpanTests.FloorTests;

public class MinutesTests : TimeSpanQuantizeTests
{
    [Theory]
    [MemberData(nameof(FloorCases))]
    public void Floor_Minutes_Returns_Expected(double value, double expected)
        => MinutesTest(value, expected, x => TimeQuantizer.FloorMinutes(x));

    [Theory]
    [MemberData(nameof(FloorCases))]
    public void Quantize_Floor_Minutes_Returns_Expected(double value, double expected)
        => MinutesTest(value, expected, x => TimeQuantizer.Quantize(x, TimePrecision.Minute, QuantizationMode.Floor));

    [Theory]
    [MemberData(nameof(FloorCases))]
    public void QuantizeMinutes_Floor_Returns_Expected(double value, double expected)
        => MinutesTest(value, expected, x => TimeQuantizer.QuantizeMinutes(x, QuantizationMode.Floor));

    [Theory]
    [MemberData(nameof(FloorCases))]
    public void Instance_Quantize_Floor_Minutes_Returns_Expected(double value, double expected)
        => MinutesTest(value, expected, x => new TimeQuantizer(TimePrecision.Minute, QuantizationMode.Floor).Quantize(x));

    [Theory]
    [MemberData(nameof(FloorCases))]
    public void Extension_Floor_Minutes_Returns_Expected(double value, double expected)
        => MinutesTest(value, expected, x => x.FloorMinutes());

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(FloorCases))]
    public void Nullable_Floor_Minutes_Returns_Expected(double? value, double? expected)
        => Nullable_MinutesTest(value, expected, x => TimeQuantizer.FloorMinutes(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(FloorCases))]
    public void Nullable_Quantize_Floor_Minutes_Returns_Expected(double? value, double? expected)
        => Nullable_MinutesTest(value, expected, x => TimeQuantizer.Quantize(x, TimePrecision.Minute, QuantizationMode.Floor));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(FloorCases))]
    public void Nullable_QuantizeMinutes_Floor_Returns_Expected(double? value, double? expected)
        => Nullable_MinutesTest(value, expected, x => TimeQuantizer.QuantizeMinutes(x, QuantizationMode.Floor));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(FloorCases))]
    public void Nullable_Instance_Quantize_Floor_Minutes_Returns_Expected(double? value, double? expected)
        => Nullable_MinutesTest(value, expected, x => new TimeQuantizer(TimePrecision.Minute, QuantizationMode.Floor).Quantize(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(FloorCases))]
    public void Nullable_Extension_Floor_Minutes_Returns_Expected(double? value, double? expected)
        => Nullable_MinutesTest(value, expected, x => x.FloorMinutes());
}
