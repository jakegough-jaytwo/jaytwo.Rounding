using System;
using Xunit;

namespace jaytwo.Rounding.Tests.TimeQuantizerTests.TimeSpanTests.TruncateTests;

public class HoursTests : TimeSpanQuantizeTests
{
    [Theory]
    [MemberData(nameof(TruncateCases))]
    public void Truncate_Hours_Returns_Expected(double value, double expected)
        => HoursTest(value, expected, x => TimeQuantizer.TruncateHours(x));

    [Theory]
    [MemberData(nameof(TruncateCases))]
    public void Quantize_Truncate_Hours_Returns_Expected(double value, double expected)
        => HoursTest(value, expected, x => TimeQuantizer.Quantize(x, TimePrecision.Hour, QuantizationMode.Truncate));

    [Theory]
    [MemberData(nameof(TruncateCases))]
    public void QuantizeHours_Truncate_Returns_Expected(double value, double expected)
        => HoursTest(value, expected, x => TimeQuantizer.QuantizeHours(x, QuantizationMode.Truncate));

    [Theory]
    [MemberData(nameof(TruncateCases))]
    public void Instance_Quantize_Truncate_Hours_Returns_Expected(double value, double expected)
        => HoursTest(value, expected, x => new TimeQuantizer(TimePrecision.Hour, QuantizationMode.Truncate).Quantize(x));

    [Theory]
    [MemberData(nameof(TruncateCases))]
    public void Extension_Truncate_Hours_Returns_Expected(double value, double expected)
        => HoursTest(value, expected, x => x.TruncateHours());

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TruncateCases))]
    public void Nullable_Truncate_Hours_Returns_Expected(double? value, double? expected)
        => Nullable_HoursTest(value, expected, x => TimeQuantizer.TruncateHours(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TruncateCases))]
    public void Nullable_Quantize_Truncate_Hours_Returns_Expected(double? value, double? expected)
        => Nullable_HoursTest(value, expected, x => TimeQuantizer.Quantize(x, TimePrecision.Hour, QuantizationMode.Truncate));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TruncateCases))]
    public void Nullable_QuantizeHours_Truncate_Returns_Expected(double? value, double? expected)
        => Nullable_HoursTest(value, expected, x => TimeQuantizer.QuantizeHours(x, QuantizationMode.Truncate));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TruncateCases))]
    public void Nullable_Instance_Quantize_Truncate_Hours_Returns_Expected(double? value, double? expected)
        => Nullable_HoursTest(value, expected, x => new TimeQuantizer(TimePrecision.Hour, QuantizationMode.Truncate).Quantize(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TruncateCases))]
    public void Nullable_Extension_Truncate_Hours_Returns_Expected(double? value, double? expected)
        => Nullable_HoursTest(value, expected, x => x.TruncateHours());
}
