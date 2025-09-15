using System;
using Xunit;

namespace jaytwo.Rounding.Tests.TimeQuantizerTests.TimeSpanTests.FloorTests;

public class HoursTests : TimeSpanQuantizeTests
{
    [Theory]
    [MemberData(nameof(FloorCases))]
    public void Floor_Hours_Returns_Expected(double value, double expected)
        => HoursTest(value, expected, x => TimeQuantizer.FloorHours(x));

    [Theory]
    [MemberData(nameof(FloorCases))]
    public void Quantize_Floor_Hours_Returns_Expected(double value, double expected)
        => HoursTest(value, expected, x => TimeQuantizer.Quantize(x, TimePrecision.Hour, QuantizationMode.Floor));

    [Theory]
    [MemberData(nameof(FloorCases))]
    public void QuantizeHours_Floor_Returns_Expected(double value, double expected)
        => HoursTest(value, expected, x => TimeQuantizer.QuantizeHours(x, QuantizationMode.Floor));

    [Theory]
    [MemberData(nameof(FloorCases))]
    public void Instance_Quantize_Floor_Hours_Returns_Expected(double value, double expected)
        => HoursTest(value, expected, x => new TimeQuantizer(TimePrecision.Hour, QuantizationMode.Floor).Quantize(x));

    [Theory]
    [MemberData(nameof(FloorCases))]
    public void Extension_Floor_Hours_Returns_Expected(double value, double expected)
        => HoursTest(value, expected, x => x.FloorHours());

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(FloorCases))]
    public void Nullable_Floor_Hours_Returns_Expected(double? value, double? expected)
        => Nullable_HoursTest(value, expected, x => TimeQuantizer.FloorHours(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(FloorCases))]
    public void Nullable_Quantize_Floor_Hours_Returns_Expected(double? value, double? expected)
        => Nullable_HoursTest(value, expected, x => TimeQuantizer.Quantize(x, TimePrecision.Hour, QuantizationMode.Floor));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(FloorCases))]
    public void Nullable_QuantizeHours_Floor_Returns_Expected(double? value, double? expected)
        => Nullable_HoursTest(value, expected, x => TimeQuantizer.QuantizeHours(x, QuantizationMode.Floor));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(FloorCases))]
    public void Nullable_Instance_Quantize_Floor_Hours_Returns_Expected(double? value, double? expected)
        => Nullable_HoursTest(value, expected, x => new TimeQuantizer(TimePrecision.Hour, QuantizationMode.Floor).Quantize(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(FloorCases))]
    public void Nullable_Extension_Floor_Hours_Returns_Expected(double? value, double? expected)
        => Nullable_HoursTest(value, expected, x => x.FloorHours());
}
