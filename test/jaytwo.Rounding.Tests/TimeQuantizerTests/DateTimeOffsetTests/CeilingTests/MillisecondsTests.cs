using Xunit;

namespace jaytwo.Rounding.Tests.TimeQuantizerTests.DateTimeOffsetTests.CeilingTests;

public class MillisecondsTests : DateTimeOffsetQuantizeTests
{
    [Theory]
    [MemberData(nameof(CeilingMillisecondCases))]
    public void CeilingMilliseconds_Returns_Expected(string inputStr, string expectedStr)
        => QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.CeilingMilliseconds(x));

    [Theory]
    [MemberData(nameof(CeilingMillisecondCases))]
    public void Quantize_Millisecond_Ceiling_Returns_Expected(string inputStr, string expectedStr)
        => QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.Quantize(x, TimePrecision.Millisecond, QuantizationMode.Ceiling));

    [Theory]
    [MemberData(nameof(CeilingMillisecondCases))]
    public void QuantizeMilliseconds_Ceiling_Returns_Expected(string inputStr, string expectedStr)
        => QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.QuantizeMilliseconds(x, QuantizationMode.Ceiling));

    [Theory]
    [MemberData(nameof(CeilingMillisecondCases))]
    public void Instance_Quantize_Millisecond_Ceiling_Returns_Expected(string inputStr, string expectedStr)
        => QuantizeTest(inputStr, expectedStr, x => new TimeQuantizer(TimePrecision.Millisecond, QuantizationMode.Ceiling).Quantize(x));

    [Theory]
    [MemberData(nameof(CeilingMillisecondCases))]
    public void Extension_CeilingMilliseconds_Returns_Expected(string inputStr, string expectedStr)
        => QuantizeTest(inputStr, expectedStr, x => x.CeilingMilliseconds());

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(CeilingMillisecondCases))]
    public void Nullable_CeilingMilliseconds_Returns_Expected(string inputStr, string expectedStr)
        => Nullable_QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.CeilingMilliseconds(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(CeilingMillisecondCases))]
    public void Nullable_Quantize_Millisecond_Ceiling_Returns_Expected(string inputStr, string expectedStr)
        => Nullable_QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.Quantize(x, TimePrecision.Millisecond, QuantizationMode.Ceiling));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(CeilingMillisecondCases))]
    public void Nullable_QuantizeMilliseconds_Ceiling_Returns_Expected(string inputStr, string expectedStr)
        => Nullable_QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.QuantizeMilliseconds(x, QuantizationMode.Ceiling));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(CeilingMillisecondCases))]
    public void Nullable_Instance_Quantize_Millisecond_Ceiling_Returns_Expected(string inputStr, string expectedStr)
        => Nullable_QuantizeTest(inputStr, expectedStr, x => new TimeQuantizer(TimePrecision.Millisecond, QuantizationMode.Ceiling).Quantize(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(CeilingMillisecondCases))]
    public void Nullable_Extension_CeilingMilliseconds_Returns_Expected(string inputStr, string expectedStr)
        => Nullable_QuantizeTest(inputStr, expectedStr, x => x?.CeilingMilliseconds());
}
