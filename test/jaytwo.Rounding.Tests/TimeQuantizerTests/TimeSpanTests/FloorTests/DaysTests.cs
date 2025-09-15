using System;
using Xunit;

namespace jaytwo.Rounding.Tests.TimeQuantizerTests.TimeSpanTests.FloorTests;

public class DaysTests : TimeSpanQuantizeTests
{
    [Theory]
    [MemberData(nameof(FloorCases))]
    public void Floor_Days_Returns_Expected(double value, double expected)
        => DaysTest(value, expected, x => TimeQuantizer.FloorDays(x));

    [Theory]
    [MemberData(nameof(FloorCases))]
    public void Quantize_Floor_Days_Returns_Expected(double value, double expected)
        => DaysTest(value, expected, x => TimeQuantizer.Quantize(x, TimePrecision.Day, QuantizationMode.Floor));

    [Theory]
    [MemberData(nameof(FloorCases))]
    public void QuantizeDays_Floor_Returns_Expected(double value, double expected)
        => DaysTest(value, expected, x => TimeQuantizer.QuantizeDays(x, QuantizationMode.Floor));

    [Theory]
    [MemberData(nameof(FloorCases))]
    public void Instance_Quantize_Floor_Days_Returns_Expected(double value, double expected)
        => DaysTest(value, expected, x => new TimeQuantizer(TimePrecision.Day, QuantizationMode.Floor).Quantize(x));

    [Theory]
    [MemberData(nameof(FloorCases))]
    public void Extension_Floor_Days_Returns_Expected(double value, double expected)
        => DaysTest(value, expected, x => x.FloorDays());

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(FloorCases))]
    public void Nullable_Floor_Days_Returns_Expected(double? value, double? expected)
        => Nullable_DaysTest(value, expected, x => TimeQuantizer.FloorDays(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(FloorCases))]
    public void Nullable_Quantize_Floor_Days_Returns_Expected(double? value, double? expected)
        => Nullable_DaysTest(value, expected, x => TimeQuantizer.Quantize(x, TimePrecision.Day, QuantizationMode.Floor));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(FloorCases))]
    public void Nullable_QuantizeDays_Floor_Returns_Expected(double? value, double? expected)
        => Nullable_DaysTest(value, expected, x => TimeQuantizer.QuantizeDays(x, QuantizationMode.Floor));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(FloorCases))]
    public void Nullable_Instance_Quantize_Floor_Days_Returns_Expected(double? value, double? expected)
        => Nullable_DaysTest(value, expected, x => new TimeQuantizer(TimePrecision.Day, QuantizationMode.Floor).Quantize(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(FloorCases))]
    public void Nullable_Extension_Floor_Days_Returns_Expected(double? value, double? expected)
        => Nullable_DaysTest(value, expected, x => x.FloorDays());
}
