using System;
using Xunit;

namespace jaytwo.Rounding.Tests.TimeQuantizerTests.TimeSpanTests.TruncateTests;

public class DaysTests : TimeSpanQuantizeTests
{
    [Theory]
    [MemberData(nameof(TruncateCases))]
    public void Truncate_Days_Returns_Expected(double value, double expected)
        => DaysTest(value, expected, x => TimeQuantizer.TruncateDays(x));

    [Theory]
    [MemberData(nameof(TruncateCases))]
    public void Quantize_Truncate_Days_Returns_Expected(double value, double expected)
        => DaysTest(value, expected, x => TimeQuantizer.Quantize(x, TimePrecision.Day, QuantizationMode.Truncate));

    [Theory]
    [MemberData(nameof(TruncateCases))]
    public void QuantizeDays_Truncate_Returns_Expected(double value, double expected)
        => DaysTest(value, expected, x => TimeQuantizer.QuantizeDays(x, QuantizationMode.Truncate));

    [Theory]
    [MemberData(nameof(TruncateCases))]
    public void Instance_Quantize_Truncate_Days_Returns_Expected(double value, double expected)
        => DaysTest(value, expected, x => new TimeQuantizer(TimePrecision.Day, QuantizationMode.Truncate).Quantize(x));

    [Theory]
    [MemberData(nameof(TruncateCases))]
    public void Extension_Truncate_Days_Returns_Expected(double value, double expected)
        => DaysTest(value, expected, x => x.TruncateDays());

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TruncateCases))]
    public void Nullable_Truncate_Days_Returns_Expected(double? value, double? expected)
        => Nullable_DaysTest(value, expected, x => TimeQuantizer.TruncateDays(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TruncateCases))]
    public void Nullable_Quantize_Truncate_Days_Returns_Expected(double? value, double? expected)
        => Nullable_DaysTest(value, expected, x => TimeQuantizer.Quantize(x, TimePrecision.Day, QuantizationMode.Truncate));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TruncateCases))]
    public void Nullable_QuantizeDays_Truncate_Returns_Expected(double? value, double? expected)
        => Nullable_DaysTest(value, expected, x => TimeQuantizer.QuantizeDays(x, QuantizationMode.Truncate));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TruncateCases))]
    public void Nullable_Instance_Quantize_Truncate_Days_Returns_Expected(double? value, double? expected)
        => Nullable_DaysTest(value, expected, x => new TimeQuantizer(TimePrecision.Day, QuantizationMode.Truncate).Quantize(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TruncateCases))]
    public void Nullable_Extension_Truncate_Days_Returns_Expected(double? value, double? expected)
        => Nullable_DaysTest(value, expected, x => x.TruncateDays());
}
