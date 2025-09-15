using Xunit;

namespace jaytwo.Rounding.Tests.TimeQuantizerTests.DateTimeOffsetTests.FloorTests;

public class MillisecondsTests : DateTimeOffsetQuantizeTests
{
    [Theory]
    [MemberData(nameof(FloorMillisecondCases))]
    public void FloorMilliseconds_Returns_Expected(string inputStr, string expectedStr)
        => QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.FloorMilliseconds(x));

    [Theory]
    [MemberData(nameof(FloorMillisecondCases))]
    public void Quantize_Millisecond_Floor_Returns_Expected(string inputStr, string expectedStr)
        => QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.Quantize(x, TimePrecision.Millisecond, QuantizationMode.Floor));

    [Theory]
    [MemberData(nameof(FloorMillisecondCases))]
    public void QuantizeMilliseconds_Floor_Returns_Expected(string inputStr, string expectedStr)
        => QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.QuantizeMilliseconds(x, QuantizationMode.Floor));

    [Theory]
    [MemberData(nameof(FloorMillisecondCases))]
    public void Instance_Quantize_Millisecond_Floor_Returns_Expected(string inputStr, string expectedStr)
        => QuantizeTest(inputStr, expectedStr, x => new TimeQuantizer(TimePrecision.Millisecond, QuantizationMode.Floor).Quantize(x));

    [Theory]
    [MemberData(nameof(FloorMillisecondCases))]
    public void Extension_FloorMilliseconds_Returns_Expected(string inputStr, string expectedStr)
        => QuantizeTest(inputStr, expectedStr, x => x.FloorMilliseconds());

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(FloorMillisecondCases))]
    public void Nullable_FloorMilliseconds_Returns_Expected(string inputStr, string expectedStr)
        => Nullable_QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.FloorMilliseconds(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(FloorMillisecondCases))]
    public void Nullable_Quantize_Millisecond_Floor_Returns_Expected(string inputStr, string expectedStr)
        => Nullable_QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.Quantize(x, TimePrecision.Millisecond, QuantizationMode.Floor));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(FloorMillisecondCases))]
    public void Nullable_QuantizeMilliseconds_Floor_Returns_Expected(string inputStr, string expectedStr)
        => Nullable_QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.QuantizeMilliseconds(x, QuantizationMode.Floor));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(FloorMillisecondCases))]
    public void Nullable_Instance_Quantize_Millisecond_Floor_Returns_Expected(string inputStr, string expectedStr)
        => Nullable_QuantizeTest(inputStr, expectedStr, x => new TimeQuantizer(TimePrecision.Millisecond, QuantizationMode.Floor).Quantize(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(FloorMillisecondCases))]
    public void Nullable_Extension_FloorMilliseconds_Returns_Expected(string inputStr, string expectedStr)
        => Nullable_QuantizeTest(inputStr, expectedStr, x => x?.FloorMilliseconds());
}
