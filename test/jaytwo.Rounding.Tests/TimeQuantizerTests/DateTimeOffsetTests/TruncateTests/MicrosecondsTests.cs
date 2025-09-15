using Xunit;

namespace jaytwo.Rounding.Tests.TimeQuantizerTests.DateTimeOffsetTests.TruncateTests;

public class MicrosecondsTests : DateTimeOffsetQuantizeTests
{
    [Theory]
    [MemberData(nameof(TruncateMicrosecondCases))]
    public void TruncateMicroseconds_Returns_Expected(string inputStr, string expectedStr)
        => QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.TruncateMicroseconds(x));

    [Theory]
    [MemberData(nameof(TruncateMicrosecondCases))]
    public void Quantize_Microsecond_Truncate_Returns_Expected(string inputStr, string expectedStr)
        => QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.Quantize(x, TimePrecision.Microsecond, QuantizationMode.Truncate));

    [Theory]
    [MemberData(nameof(TruncateMicrosecondCases))]
    public void QuantizeMicroseconds_Truncate_Returns_Expected(string inputStr, string expectedStr)
        => QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.QuantizeMicroseconds(x, QuantizationMode.Truncate));

    [Theory]
    [MemberData(nameof(TruncateMicrosecondCases))]
    public void Instance_Quantize_Microsecond_Truncate_Returns_Expected(string inputStr, string expectedStr)
        => QuantizeTest(inputStr, expectedStr, x => new TimeQuantizer(TimePrecision.Microsecond, QuantizationMode.Truncate).Quantize(x));

    [Theory]
    [MemberData(nameof(TruncateMicrosecondCases))]
    public void Extension_TruncateMicroseconds_Returns_Expected(string inputStr, string expectedStr)
        => QuantizeTest(inputStr, expectedStr, x => x.TruncateMicroseconds());

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TruncateMicrosecondCases))]
    public void Nullable_TruncateMicroseconds_Returns_Expected(string inputStr, string expectedStr)
        => Nullable_QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.TruncateMicroseconds(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TruncateMicrosecondCases))]
    public void Nullable_Quantize_Microsecond_Truncate_Returns_Expected(string inputStr, string expectedStr)
        => Nullable_QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.Quantize(x, TimePrecision.Microsecond, QuantizationMode.Truncate));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TruncateMicrosecondCases))]
    public void Nullable_QuantizeMicroseconds_Truncate_Returns_Expected(string inputStr, string expectedStr)
        => Nullable_QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.QuantizeMicroseconds(x, QuantizationMode.Truncate));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TruncateMicrosecondCases))]
    public void Nullable_Instance_Quantize_Microsecond_Truncate_Returns_Expected(string inputStr, string expectedStr)
        => Nullable_QuantizeTest(inputStr, expectedStr, x => new TimeQuantizer(TimePrecision.Microsecond, QuantizationMode.Truncate).Quantize(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TruncateMicrosecondCases))]
    public void Nullable_Extension_TruncateMicroseconds_Returns_Expected(string inputStr, string expectedStr)
        => Nullable_QuantizeTest(inputStr, expectedStr, x => x?.TruncateMicroseconds());
}
