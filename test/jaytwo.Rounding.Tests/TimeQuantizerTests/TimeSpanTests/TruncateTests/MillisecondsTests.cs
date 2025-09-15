using System;
using Xunit;

namespace jaytwo.Rounding.Tests.TimeQuantizerTests.TimeSpanTests.TruncateTests;

public class MillisecondsTests : TimeSpanQuantizeTests
{
    [Theory]
    [MemberData(nameof(TruncateCases))]
    public void Truncate_Milliseconds_Returns_Expected(double value, double expected)
        => MillisecondsTest(value, expected, x => TimeQuantizer.TruncateMilliseconds(x));

    [Theory]
    [MemberData(nameof(TruncateCases))]
    public void Quantize_Truncate_Milliseconds_Returns_Expected(double value, double expected)
        => MillisecondsTest(value, expected, x => TimeQuantizer.Quantize(x, TimePrecision.Millisecond, QuantizationMode.Truncate));

    [Theory]
    [MemberData(nameof(TruncateCases))]
    public void QuantizeMilliseconds_Truncate_Returns_Expected(double value, double expected)
        => MillisecondsTest(value, expected, x => TimeQuantizer.QuantizeMilliseconds(x, QuantizationMode.Truncate));

    [Theory]
    [MemberData(nameof(TruncateCases))]
    public void Instance_Quantize_Truncate_Milliseconds_Returns_Expected(double value, double expected)
        => MillisecondsTest(value, expected, x => new TimeQuantizer(TimePrecision.Millisecond, QuantizationMode.Truncate).Quantize(x));

    [Theory]
    [MemberData(nameof(TruncateCases))]
    public void Extension_Truncate_Milliseconds_Returns_Expected(double value, double expected)
        => MillisecondsTest(value, expected, x => x.TruncateMilliseconds());

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TruncateCases))]
    public void Nullable_Truncate_Milliseconds_Returns_Expected(double? value, double? expected)
        => Nullable_MillisecondsTest(value, expected, x => TimeQuantizer.TruncateMilliseconds(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TruncateCases))]
    public void Nullable_Quantize_Truncate_Milliseconds_Returns_Expected(double? value, double? expected)
        => Nullable_MillisecondsTest(value, expected, x => TimeQuantizer.Quantize(x, TimePrecision.Millisecond, QuantizationMode.Truncate));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TruncateCases))]
    public void Nullable_QuantizeMilliseconds_Truncate_Returns_Expected(double? value, double? expected)
        => Nullable_MillisecondsTest(value, expected, x => TimeQuantizer.QuantizeMilliseconds(x, QuantizationMode.Truncate));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TruncateCases))]
    public void Nullable_Instance_Quantize_Truncate_Milliseconds_Returns_Expected(double? value, double? expected)
        => Nullable_MillisecondsTest(value, expected, x => new TimeQuantizer(TimePrecision.Millisecond, QuantizationMode.Truncate).Quantize(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TruncateCases))]
    public void Nullable_Extension_Truncate_Milliseconds_Returns_Expected(double? value, double? expected)
        => Nullable_MillisecondsTest(value, expected, x => x.TruncateMilliseconds());
}
