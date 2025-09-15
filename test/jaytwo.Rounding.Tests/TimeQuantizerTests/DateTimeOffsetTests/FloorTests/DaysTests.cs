using Xunit;

namespace jaytwo.Rounding.Tests.TimeQuantizerTests.DateTimeOffsetTests.FloorTests;

public class DaysTests : DateTimeOffsetQuantizeTests
{
    [Theory]
    [MemberData(nameof(FloorDayCases))]
    public void FloorDays_Returns_Expected(string inputStr, string expectedStr)
        => QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.FloorDays(x));

    [Theory]
    [MemberData(nameof(FloorDayCases))]
    public void Quantize_Day_Floor_Returns_Expected(string inputStr, string expectedStr)
        => QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.Quantize(x, TimePrecision.Day, QuantizationMode.Floor));

    [Theory]
    [MemberData(nameof(FloorDayCases))]
    public void QuantizeDays_Floor_Returns_Expected(string inputStr, string expectedStr)
        => QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.QuantizeDays(x, QuantizationMode.Floor));

    [Theory]
    [MemberData(nameof(FloorDayCases))]
    public void Instance_Quantize_Day_Floor_Returns_Expected(string inputStr, string expectedStr)
        => QuantizeTest(inputStr, expectedStr, x => new TimeQuantizer(TimePrecision.Day, QuantizationMode.Floor).Quantize(x));

    [Theory]
    [MemberData(nameof(FloorDayCases))]
    public void Extension_FloorDays_Returns_Expected(string inputStr, string expectedStr)
        => QuantizeTest(inputStr, expectedStr, x => x.FloorDays());

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(FloorDayCases))]
    public void Nullable_FloorDays_Returns_Expected(string inputStr, string expectedStr)
        => Nullable_QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.FloorDays(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(FloorDayCases))]
    public void Nullable_Quantize_Day_Floor_Returns_Expected(string inputStr, string expectedStr)
        => Nullable_QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.Quantize(x, TimePrecision.Day, QuantizationMode.Floor));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(FloorDayCases))]
    public void Nullable_QuantizeDays_Floor_Returns_Expected(string inputStr, string expectedStr)
        => Nullable_QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.QuantizeDays(x, QuantizationMode.Floor));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(FloorDayCases))]
    public void Nullable_Instance_Quantize_Day_Floor_Returns_Expected(string inputStr, string expectedStr)
        => Nullable_QuantizeTest(inputStr, expectedStr, x => new TimeQuantizer(TimePrecision.Day, QuantizationMode.Floor).Quantize(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(FloorDayCases))]
    public void Nullable_Extension_FloorDays_Returns_Expected(string inputStr, string expectedStr)
        => Nullable_QuantizeTest(inputStr, expectedStr, x => x?.FloorDays());
}
