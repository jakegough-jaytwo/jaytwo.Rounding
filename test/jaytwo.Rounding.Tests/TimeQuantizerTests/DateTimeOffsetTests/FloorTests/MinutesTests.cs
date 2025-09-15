using Xunit;

namespace jaytwo.Rounding.Tests.TimeQuantizerTests.DateTimeOffsetTests.FloorTests;

public class MinutesTests : DateTimeOffsetQuantizeTests
{
    [Theory]
    [MemberData(nameof(FloorMinuteCases))]
    public void FloorMinutes_Returns_Expected(string inputStr, string expectedStr)
        => QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.FloorMinutes(x));

    [Theory]
    [MemberData(nameof(FloorMinuteCases))]
    public void Quantize_Minute_Floor_Returns_Expected(string inputStr, string expectedStr)
        => QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.Quantize(x, TimePrecision.Minute, QuantizationMode.Floor));

    [Theory]
    [MemberData(nameof(FloorMinuteCases))]
    public void QuantizeMinutes_Floor_Returns_Expected(string inputStr, string expectedStr)
        => QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.QuantizeMinutes(x, QuantizationMode.Floor));

    [Theory]
    [MemberData(nameof(FloorMinuteCases))]
    public void Instance_Quantize_Minute_Floor_Returns_Expected(string inputStr, string expectedStr)
        => QuantizeTest(inputStr, expectedStr, x => new TimeQuantizer(TimePrecision.Minute, QuantizationMode.Floor).Quantize(x));

    [Theory]
    [MemberData(nameof(FloorMinuteCases))]
    public void Extension_FloorMinutes_Returns_Expected(string inputStr, string expectedStr)
        => QuantizeTest(inputStr, expectedStr, x => x.FloorMinutes());

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(FloorMinuteCases))]
    public void Nullable_FloorMinutes_Returns_Expected(string inputStr, string expectedStr)
        => Nullable_QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.FloorMinutes(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(FloorMinuteCases))]
    public void Nullable_Quantize_Minute_Floor_Returns_Expected(string inputStr, string expectedStr)
        => Nullable_QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.Quantize(x, TimePrecision.Minute, QuantizationMode.Floor));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(FloorMinuteCases))]
    public void Nullable_QuantizeMinutes_Floor_Returns_Expected(string inputStr, string expectedStr)
        => Nullable_QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.QuantizeMinutes(x, QuantizationMode.Floor));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(FloorMinuteCases))]
    public void Nullable_Instance_Quantize_Minute_Floor_Returns_Expected(string inputStr, string expectedStr)
        => Nullable_QuantizeTest(inputStr, expectedStr, x => new TimeQuantizer(TimePrecision.Minute, QuantizationMode.Floor).Quantize(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(FloorMinuteCases))]
    public void Nullable_Extension_FloorMinutes_Returns_Expected(string inputStr, string expectedStr)
        => Nullable_QuantizeTest(inputStr, expectedStr, x => x?.FloorMinutes());
}
