using Xunit;

namespace jaytwo.Rounding.Tests.TimeQuantizerTests.DateTimeTests.TruncateTests;

public class MinutesTests : DateTimeQuantizeTests
{
    [Theory]
    [MemberData(nameof(TruncateMinuteCases))]
    public void TruncateMinutes_Returns_Expected(string inputStr, string expectedStr)
        => QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.TruncateMinutes(x));

    [Theory]
    [MemberData(nameof(TruncateMinuteCases))]
    public void Quantize_Minute_Truncate_Returns_Expected(string inputStr, string expectedStr)
        => QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.Quantize(x, TimePrecision.Minute, QuantizationMode.Truncate));

    [Theory]
    [MemberData(nameof(TruncateMinuteCases))]
    public void QuantizeMinutes_Truncate_Returns_Expected(string inputStr, string expectedStr)
        => QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.QuantizeMinutes(x, QuantizationMode.Truncate));

    [Theory]
    [MemberData(nameof(TruncateMinuteCases))]
    public void Instance_Quantize_Minute_Truncate_Returns_Expected(string inputStr, string expectedStr)
        => QuantizeTest(inputStr, expectedStr, x => new TimeQuantizer(TimePrecision.Minute, QuantizationMode.Truncate).Quantize(x));

    [Theory]
    [MemberData(nameof(TruncateMinuteCases))]
    public void Extension_TruncateMinutes_Returns_Expected(string inputStr, string expectedStr)
        => QuantizeTest(inputStr, expectedStr, x => x.TruncateMinutes());

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TruncateMinuteCases))]
    public void Nullable_TruncateMinutes_Returns_Expected(string inputStr, string expectedStr)
        => Nullable_QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.TruncateMinutes(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TruncateMinuteCases))]
    public void Nullable_Quantize_Minute_Truncate_Returns_Expected(string inputStr, string expectedStr)
        => Nullable_QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.Quantize(x, TimePrecision.Minute, QuantizationMode.Truncate));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TruncateMinuteCases))]
    public void Nullable_QuantizeMinutes_Truncate_Returns_Expected(string inputStr, string expectedStr)
        => Nullable_QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.QuantizeMinutes(x, QuantizationMode.Truncate));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TruncateMinuteCases))]
    public void Nullable_Instance_Quantize_Minute_Truncate_Returns_Expected(string inputStr, string expectedStr)
        => Nullable_QuantizeTest(inputStr, expectedStr, x => new TimeQuantizer(TimePrecision.Minute, QuantizationMode.Truncate).Quantize(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TruncateMinuteCases))]
    public void Nullable_Extension_TruncateMinutes_Returns_Expected(string inputStr, string expectedStr)
        => Nullable_QuantizeTest(inputStr, expectedStr, x => x?.TruncateMinutes());
}
