using Xunit;

namespace jaytwo.Rounding.Tests.TimeQuantizerTests.DateTimeTests.TruncateTests;

public class MillisecondsTests : DateTimeQuantizeTests
{
    [Theory]
    [MemberData(nameof(TruncateMillisecondCases))]
    public void TruncateMilliseconds_Returns_Expected(string inputStr, string expectedStr)
        => QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.TruncateMilliseconds(x));

    [Theory]
    [MemberData(nameof(TruncateMillisecondCases))]
    public void Quantize_Millisecond_Truncate_Returns_Expected(string inputStr, string expectedStr)
        => QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.Quantize(x, TimePrecision.Millisecond, QuantizationMode.Truncate));

    [Theory]
    [MemberData(nameof(TruncateMillisecondCases))]
    public void QuantizeMilliseconds_Truncate_Returns_Expected(string inputStr, string expectedStr)
        => QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.QuantizeMilliseconds(x, QuantizationMode.Truncate));

    [Theory]
    [MemberData(nameof(TruncateMillisecondCases))]
    public void Instance_Quantize_Millisecond_Truncate_Returns_Expected(string inputStr, string expectedStr)
        => QuantizeTest(inputStr, expectedStr, x => new TimeQuantizer(TimePrecision.Millisecond, QuantizationMode.Truncate).Quantize(x));

    [Theory]
    [MemberData(nameof(TruncateMillisecondCases))]
    public void Extension_TruncateMilliseconds_Returns_Expected(string inputStr, string expectedStr)
        => QuantizeTest(inputStr, expectedStr, x => x.TruncateMilliseconds());

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TruncateMillisecondCases))]
    public void Nullable_TruncateMilliseconds_Returns_Expected(string inputStr, string expectedStr)
        => Nullable_QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.TruncateMilliseconds(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TruncateMillisecondCases))]
    public void Nullable_Quantize_Millisecond_Truncate_Returns_Expected(string inputStr, string expectedStr)
        => Nullable_QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.Quantize(x, TimePrecision.Millisecond, QuantizationMode.Truncate));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TruncateMillisecondCases))]
    public void Nullable_QuantizeMilliseconds_Truncate_Returns_Expected(string inputStr, string expectedStr)
        => Nullable_QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.QuantizeMilliseconds(x, QuantizationMode.Truncate));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TruncateMillisecondCases))]
    public void Nullable_Instance_Quantize_Millisecond_Truncate_Returns_Expected(string inputStr, string expectedStr)
        => Nullable_QuantizeTest(inputStr, expectedStr, x => new TimeQuantizer(TimePrecision.Millisecond, QuantizationMode.Truncate).Quantize(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TruncateMillisecondCases))]
    public void Nullable_Extension_TruncateMilliseconds_Returns_Expected(string inputStr, string expectedStr)
        => Nullable_QuantizeTest(inputStr, expectedStr, x => x?.TruncateMilliseconds());
}
