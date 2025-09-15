using Xunit;

namespace jaytwo.Rounding.Tests.TimeQuantizerTests.DateTimeTests.FloorTests;

public class SecondsTests : DateTimeQuantizeTests
{
    [Theory]
    [MemberData(nameof(FloorSecondCases))]
    public void FloorSeconds_Returns_Expected(string inputStr, string expectedStr)
        => QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.FloorSeconds(x));

    [Theory]
    [MemberData(nameof(FloorSecondCases))]
    public void Quantize_Second_Floor_Returns_Expected(string inputStr, string expectedStr)
        => QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.Quantize(x, TimePrecision.Second, QuantizationMode.Floor));

    [Theory]
    [MemberData(nameof(FloorSecondCases))]
    public void QuantizeSeconds_Floor_Returns_Expected(string inputStr, string expectedStr)
        => QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.QuantizeSeconds(x, QuantizationMode.Floor));

    [Theory]
    [MemberData(nameof(FloorSecondCases))]
    public void Instance_Quantize_Second_Floor_Returns_Expected(string inputStr, string expectedStr)
        => QuantizeTest(inputStr, expectedStr, x => new TimeQuantizer(TimePrecision.Second, QuantizationMode.Floor).Quantize(x));

    [Theory]
    [MemberData(nameof(FloorSecondCases))]
    public void Extension_FloorSeconds_Returns_Expected(string inputStr, string expectedStr)
        => QuantizeTest(inputStr, expectedStr, x => x.FloorSeconds());

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(FloorSecondCases))]
    public void Nullable_FloorSeconds_Returns_Expected(string inputStr, string expectedStr)
        => Nullable_QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.FloorSeconds(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(FloorSecondCases))]
    public void Nullable_Quantize_Second_Floor_Returns_Expected(string inputStr, string expectedStr)
        => Nullable_QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.Quantize(x, TimePrecision.Second, QuantizationMode.Floor));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(FloorSecondCases))]
    public void Nullable_QuantizeSeconds_Floor_Returns_Expected(string inputStr, string expectedStr)
        => Nullable_QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.QuantizeSeconds(x, QuantizationMode.Floor));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(FloorSecondCases))]
    public void Nullable_Instance_Quantize_Second_Floor_Returns_Expected(string inputStr, string expectedStr)
        => Nullable_QuantizeTest(inputStr, expectedStr, x => new TimeQuantizer(TimePrecision.Second, QuantizationMode.Floor).Quantize(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(FloorSecondCases))]
    public void Nullable_Extension_FloorSeconds_Returns_Expected(string inputStr, string expectedStr)
        => Nullable_QuantizeTest(inputStr, expectedStr, x => x?.FloorSeconds());
}
