using Xunit;

namespace jaytwo.Rounding.Tests.TimeQuantizerTests.DateTimeTests.CeilingTests;

public class SecondsTests : DateTimeQuantizeTests
{
    [Theory]
    [MemberData(nameof(CeilingSecondCases))]
    public void CeilingSeconds_Returns_Expected(string inputStr, string expectedStr)
        => QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.CeilingSeconds(x));

    [Theory]
    [MemberData(nameof(CeilingSecondCases))]
    public void Quantize_Second_Ceiling_Returns_Expected(string inputStr, string expectedStr)
        => QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.Quantize(x, TimePrecision.Second, QuantizationMode.Ceiling));

    [Theory]
    [MemberData(nameof(CeilingSecondCases))]
    public void QuantizeSeconds_Ceiling_Returns_Expected(string inputStr, string expectedStr)
        => QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.QuantizeSeconds(x, QuantizationMode.Ceiling));

    [Theory]
    [MemberData(nameof(CeilingSecondCases))]
    public void Instance_Quantize_Second_Ceiling_Returns_Expected(string inputStr, string expectedStr)
        => QuantizeTest(inputStr, expectedStr, x => new TimeQuantizer(TimePrecision.Second, QuantizationMode.Ceiling).Quantize(x));

    [Theory]
    [MemberData(nameof(CeilingSecondCases))]
    public void Extension_CeilingSeconds_Returns_Expected(string inputStr, string expectedStr)
        => QuantizeTest(inputStr, expectedStr, x => x.CeilingSeconds());

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(CeilingSecondCases))]
    public void Nullable_CeilingSeconds_Returns_Expected(string inputStr, string expectedStr)
        => Nullable_QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.CeilingSeconds(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(CeilingSecondCases))]
    public void Nullable_Quantize_Second_Ceiling_Returns_Expected(string inputStr, string expectedStr)
        => Nullable_QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.Quantize(x, TimePrecision.Second, QuantizationMode.Ceiling));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(CeilingSecondCases))]
    public void Nullable_QuantizeSeconds_Ceiling_Returns_Expected(string inputStr, string expectedStr)
        => Nullable_QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.QuantizeSeconds(x, QuantizationMode.Ceiling));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(CeilingSecondCases))]
    public void Nullable_Instance_Quantize_Second_Ceiling_Returns_Expected(string inputStr, string expectedStr)
        => Nullable_QuantizeTest(inputStr, expectedStr, x => new TimeQuantizer(TimePrecision.Second, QuantizationMode.Ceiling).Quantize(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(CeilingSecondCases))]
    public void Nullable_Extension_CeilingSeconds_Returns_Expected(string inputStr, string expectedStr)
        => Nullable_QuantizeTest(inputStr, expectedStr, x => x?.CeilingSeconds());
}
