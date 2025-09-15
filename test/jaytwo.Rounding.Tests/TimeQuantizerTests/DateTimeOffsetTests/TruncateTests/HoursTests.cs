using Xunit;

namespace jaytwo.Rounding.Tests.TimeQuantizerTests.DateTimeOffsetTests.TruncateTests;

public class HoursTests : DateTimeOffsetQuantizeTests
{
    [Theory]
    [MemberData(nameof(TruncateHourCases))]
    public void TruncateHours_Returns_Expected(string inputStr, string expectedStr)
        => QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.TruncateHours(x));

    [Theory]
    [MemberData(nameof(TruncateHourCases))]
    public void Quantize_Hour_Truncate_Returns_Expected(string inputStr, string expectedStr)
        => QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.Quantize(x, TimePrecision.Hour, QuantizationMode.Truncate));

    [Theory]
    [MemberData(nameof(TruncateHourCases))]
    public void QuantizeHours_Truncate_Returns_Expected(string inputStr, string expectedStr)
        => QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.QuantizeHours(x, QuantizationMode.Truncate));

    [Theory]
    [MemberData(nameof(TruncateHourCases))]
    public void Instance_Quantize_Hour_Truncate_Returns_Expected(string inputStr, string expectedStr)
        => QuantizeTest(inputStr, expectedStr, x => new TimeQuantizer(TimePrecision.Hour, QuantizationMode.Truncate).Quantize(x));

    [Theory]
    [MemberData(nameof(TruncateHourCases))]
    public void Extension_TruncateHours_Returns_Expected(string inputStr, string expectedStr)
        => QuantizeTest(inputStr, expectedStr, x => x.TruncateHours());

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TruncateHourCases))]
    public void Nullable_TruncateHours_Returns_Expected(string inputStr, string expectedStr)
        => Nullable_QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.TruncateHours(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TruncateHourCases))]
    public void Nullable_Quantize_Hour_Truncate_Returns_Expected(string inputStr, string expectedStr)
        => Nullable_QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.Quantize(x, TimePrecision.Hour, QuantizationMode.Truncate));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TruncateHourCases))]
    public void Nullable_QuantizeHours_Truncate_Returns_Expected(string inputStr, string expectedStr)
        => Nullable_QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.QuantizeHours(x, QuantizationMode.Truncate));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TruncateHourCases))]
    public void Nullable_Instance_Quantize_Hour_Truncate_Returns_Expected(string inputStr, string expectedStr)
        => Nullable_QuantizeTest(inputStr, expectedStr, x => new TimeQuantizer(TimePrecision.Hour, QuantizationMode.Truncate).Quantize(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TruncateHourCases))]
    public void Nullable_Extension_TruncateHours_Returns_Expected(string inputStr, string expectedStr)
        => Nullable_QuantizeTest(inputStr, expectedStr, x => x?.TruncateHours());
}
