using Xunit;

namespace jaytwo.Rounding.Tests.TimeQuantizerTests.DateTimeTests.TruncateTests;

public class SecondsTests : DateTimeQuantizeTests
{
    [Theory]
    [MemberData(nameof(TruncateSecondCases))]
    public void TruncateSeconds_Returns_Expected(string inputStr, string expectedStr)
        => QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.TruncateSeconds(x));

    [Theory]
    [MemberData(nameof(TruncateSecondCases))]
    public void Quantize_Second_Truncate_Returns_Expected(string inputStr, string expectedStr)
        => QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.Quantize(x, TimePrecision.Second, QuantizationMode.Truncate));

    [Theory]
    [MemberData(nameof(TruncateSecondCases))]
    public void QuantizeSeconds_Truncate_Returns_Expected(string inputStr, string expectedStr)
        => QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.QuantizeSeconds(x, QuantizationMode.Truncate));

    [Theory]
    [MemberData(nameof(TruncateSecondCases))]
    public void Instance_Quantize_Second_Truncate_Returns_Expected(string inputStr, string expectedStr)
        => QuantizeTest(inputStr, expectedStr, x => new TimeQuantizer(TimePrecision.Second, QuantizationMode.Truncate).Quantize(x));

    [Theory]
    [MemberData(nameof(TruncateSecondCases))]
    public void Extension_TruncateSeconds_Returns_Expected(string inputStr, string expectedStr)
        => QuantizeTest(inputStr, expectedStr, x => x.TruncateSeconds());

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TruncateSecondCases))]
    public void Nullable_TruncateSeconds_Returns_Expected(string inputStr, string expectedStr)
        => Nullable_QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.TruncateSeconds(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TruncateSecondCases))]
    public void Nullable_Quantize_Second_Truncate_Returns_Expected(string inputStr, string expectedStr)
        => Nullable_QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.Quantize(x, TimePrecision.Second, QuantizationMode.Truncate));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TruncateSecondCases))]
    public void Nullable_QuantizeSeconds_Truncate_Returns_Expected(string inputStr, string expectedStr)
        => Nullable_QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.QuantizeSeconds(x, QuantizationMode.Truncate));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TruncateSecondCases))]
    public void Nullable_Instance_Quantize_Second_Truncate_Returns_Expected(string inputStr, string expectedStr)
        => Nullable_QuantizeTest(inputStr, expectedStr, x => new TimeQuantizer(TimePrecision.Second, QuantizationMode.Truncate).Quantize(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TruncateSecondCases))]
    public void Nullable_Extension_TruncateSeconds_Returns_Expected(string inputStr, string expectedStr)
        => Nullable_QuantizeTest(inputStr, expectedStr, x => x?.TruncateSeconds());
}
