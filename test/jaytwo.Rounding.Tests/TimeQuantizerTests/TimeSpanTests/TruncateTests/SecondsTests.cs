using System;
using Xunit;

namespace jaytwo.Rounding.Tests.TimeQuantizerTests.TimeSpanTests.TruncateTests;

public class SecondsTests : TimeSpanQuantizeTests
{
    [Theory]
    [MemberData(nameof(TruncateCases))]
    public void Truncate_Seconds_Returns_Expected(double value, double expected)
        => SecondsTest(value, expected, x => TimeQuantizer.TruncateSeconds(x));

    [Theory]
    [MemberData(nameof(TruncateCases))]
    public void Quantize_Truncate_Seconds_Returns_Expected(double value, double expected)
        => SecondsTest(value, expected, x => TimeQuantizer.Quantize(x, TimePrecision.Second, QuantizationMode.Truncate));

    [Theory]
    [MemberData(nameof(TruncateCases))]
    public void QuantizeSeconds_Truncate_Returns_Expected(double value, double expected)
        => SecondsTest(value, expected, x => TimeQuantizer.QuantizeSeconds(x, QuantizationMode.Truncate));

    [Theory]
    [MemberData(nameof(TruncateCases))]
    public void Instance_Quantize_Truncate_Seconds_Returns_Expected(double value, double expected)
        => SecondsTest(value, expected, x => new TimeQuantizer(TimePrecision.Second, QuantizationMode.Truncate).Quantize(x));

    [Theory]
    [MemberData(nameof(TruncateCases))]
    public void Extension_Truncate_Seconds_Returns_Expected(double value, double expected)
        => SecondsTest(value, expected, x => x.TruncateSeconds());

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TruncateCases))]
    public void Nullable_Truncate_Seconds_Returns_Expected(double? value, double? expected)
        => Nullable_SecondsTest(value, expected, x => TimeQuantizer.TruncateSeconds(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TruncateCases))]
    public void Nullable_Quantize_Truncate_Seconds_Returns_Expected(double? value, double? expected)
        => Nullable_SecondsTest(value, expected, x => TimeQuantizer.Quantize(x, TimePrecision.Second, QuantizationMode.Truncate));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TruncateCases))]
    public void Nullable_QuantizeSeconds_Truncate_Returns_Expected(double? value, double? expected)
        => Nullable_SecondsTest(value, expected, x => TimeQuantizer.QuantizeSeconds(x, QuantizationMode.Truncate));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TruncateCases))]
    public void Nullable_Instance_Quantize_Truncate_Seconds_Returns_Expected(double? value, double? expected)
        => Nullable_SecondsTest(value, expected, x => new TimeQuantizer(TimePrecision.Second, QuantizationMode.Truncate).Quantize(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TruncateCases))]
    public void Nullable_Extension_Truncate_Seconds_Returns_Expected(double? value, double? expected)
        => Nullable_SecondsTest(value, expected, x => x.TruncateSeconds());
}
