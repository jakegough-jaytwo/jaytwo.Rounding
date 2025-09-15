using System;
using Xunit;

namespace jaytwo.Rounding.Tests.TimeQuantizerTests.TimeSpanTests.TruncateTests;

public class MinutesTests : TimeSpanQuantizeTests
{
    [Theory]
    [MemberData(nameof(TruncateCases))]
    public void Truncate_Minutes_Returns_Expected(double value, double expected)
        => MinutesTest(value, expected, x => TimeQuantizer.TruncateMinutes(x));

    [Theory]
    [MemberData(nameof(TruncateCases))]
    public void Quantize_Truncate_Minutes_Returns_Expected(double value, double expected)
        => MinutesTest(value, expected, x => TimeQuantizer.Quantize(x, TimePrecision.Minute, QuantizationMode.Truncate));

    [Theory]
    [MemberData(nameof(TruncateCases))]
    public void QuantizeMinutes_Truncate_Returns_Expected(double value, double expected)
        => MinutesTest(value, expected, x => TimeQuantizer.QuantizeMinutes(x, QuantizationMode.Truncate));

    [Theory]
    [MemberData(nameof(TruncateCases))]
    public void Instance_Quantize_Truncate_Minutes_Returns_Expected(double value, double expected)
        => MinutesTest(value, expected, x => new TimeQuantizer(TimePrecision.Minute, QuantizationMode.Truncate).Quantize(x));

    [Theory]
    [MemberData(nameof(TruncateCases))]
    public void Extension_Truncate_Minutes_Returns_Expected(double value, double expected)
        => MinutesTest(value, expected, x => x.TruncateMinutes());

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TruncateCases))]
    public void Nullable_Truncate_Minutes_Returns_Expected(double? value, double? expected)
        => Nullable_MinutesTest(value, expected, x => TimeQuantizer.TruncateMinutes(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TruncateCases))]
    public void Nullable_Quantize_Truncate_Minutes_Returns_Expected(double? value, double? expected)
        => Nullable_MinutesTest(value, expected, x => TimeQuantizer.Quantize(x, TimePrecision.Minute, QuantizationMode.Truncate));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TruncateCases))]
    public void Nullable_QuantizeMinutes_Truncate_Returns_Expected(double? value, double? expected)
        => Nullable_MinutesTest(value, expected, x => TimeQuantizer.QuantizeMinutes(x, QuantizationMode.Truncate));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TruncateCases))]
    public void Nullable_Instance_Quantize_Truncate_Minutes_Returns_Expected(double? value, double? expected)
        => Nullable_MinutesTest(value, expected, x => new TimeQuantizer(TimePrecision.Minute, QuantizationMode.Truncate).Quantize(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TruncateCases))]
    public void Nullable_Extension_Truncate_Minutes_Returns_Expected(double? value, double? expected)
        => Nullable_MinutesTest(value, expected, x => x.TruncateMinutes());
}
