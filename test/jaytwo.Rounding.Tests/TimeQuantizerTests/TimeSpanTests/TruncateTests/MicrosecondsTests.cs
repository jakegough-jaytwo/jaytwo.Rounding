using System;
using Xunit;

namespace jaytwo.Rounding.Tests.TimeQuantizerTests.TimeSpanTests.TruncateTests;

public class MicrosecondsTests : TimeSpanQuantizeTests
{
    [Theory]
    [MemberData(nameof(TruncateCases))]
    public void Truncate_Microseconds_Returns_Expected(double value, double expected)
        => MicrosecondsTest(value, expected, x => TimeQuantizer.TruncateMicroseconds(x));

    [Theory]
    [MemberData(nameof(TruncateCases))]
    public void Quantize_Truncate_Microseconds_Returns_Expected(double value, double expected)
        => MicrosecondsTest(value, expected, x => TimeQuantizer.Quantize(x, TimePrecision.Microsecond, QuantizationMode.Truncate));

    [Theory]
    [MemberData(nameof(TruncateCases))]
    public void QuantizeMicroseconds_Truncate_Returns_Expected(double value, double expected)
        => MicrosecondsTest(value, expected, x => TimeQuantizer.QuantizeMicroseconds(x, QuantizationMode.Truncate));

    [Theory]
    [MemberData(nameof(TruncateCases))]
    public void Instance_Quantize_Truncate_Microseconds_Returns_Expected(double value, double expected)
        => MicrosecondsTest(value, expected, x => new TimeQuantizer(TimePrecision.Microsecond, QuantizationMode.Truncate).Quantize(x));

    [Theory]
    [MemberData(nameof(TruncateCases))]
    public void Extension_Truncate_Microseconds_Returns_Expected(double value, double expected)
        => MicrosecondsTest(value, expected, x => x.TruncateMicroseconds());

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TruncateCases))]
    public void Nullable_Truncate_Microseconds_Returns_Expected(double? value, double? expected)
        => Nullable_MicrosecondsTest(value, expected, x => TimeQuantizer.TruncateMicroseconds(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TruncateCases))]
    public void Nullable_Quantize_Truncate_Microseconds_Returns_Expected(double? value, double? expected)
        => Nullable_MicrosecondsTest(value, expected, x => TimeQuantizer.Quantize(x, TimePrecision.Microsecond, QuantizationMode.Truncate));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TruncateCases))]
    public void Nullable_QuantizeMicroseconds_Truncate_Returns_Expected(double? value, double? expected)
        => Nullable_MicrosecondsTest(value, expected, x => TimeQuantizer.QuantizeMicroseconds(x, QuantizationMode.Truncate));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TruncateCases))]
    public void Nullable_Instance_Quantize_Truncate_Microseconds_Returns_Expected(double? value, double? expected)
        => Nullable_MicrosecondsTest(value, expected, x => new TimeQuantizer(TimePrecision.Microsecond, QuantizationMode.Truncate).Quantize(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TruncateCases))]
    public void Nullable_Extension_Truncate_Microseconds_Returns_Expected(double? value, double? expected)
        => Nullable_MicrosecondsTest(value, expected, x => x.TruncateMicroseconds());
}
