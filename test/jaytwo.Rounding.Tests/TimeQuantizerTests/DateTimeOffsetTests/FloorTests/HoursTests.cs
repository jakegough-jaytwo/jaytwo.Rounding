using Xunit;

namespace jaytwo.Rounding.Tests.TimeQuantizerTests.DateTimeOffsetTests.FloorTests;

public class HoursTests : DateTimeOffsetQuantizeTests
{
    [Theory]
    [MemberData(nameof(FloorHourCases))]
    public void FloorHours_Returns_Expected(string inputStr, string expectedStr)
        => QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.FloorHours(x));

    [Theory]
    [MemberData(nameof(FloorHourCases))]
    public void Quantize_Hour_Floor_Returns_Expected(string inputStr, string expectedStr)
        => QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.Quantize(x, TimePrecision.Hour, QuantizationMode.Floor));

    [Theory]
    [MemberData(nameof(FloorHourCases))]
    public void QuantizeHours_Floor_Returns_Expected(string inputStr, string expectedStr)
        => QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.QuantizeHours(x, QuantizationMode.Floor));

    [Theory]
    [MemberData(nameof(FloorHourCases))]
    public void Instance_Quantize_Hour_Floor_Returns_Expected(string inputStr, string expectedStr)
        => QuantizeTest(inputStr, expectedStr, x => new TimeQuantizer(TimePrecision.Hour, QuantizationMode.Floor).Quantize(x));

    [Theory]
    [MemberData(nameof(FloorHourCases))]
    public void Extension_FloorHours_Returns_Expected(string inputStr, string expectedStr)
        => QuantizeTest(inputStr, expectedStr, x => x.FloorHours());

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(FloorHourCases))]
    public void Nullable_FloorHours_Returns_Expected(string inputStr, string expectedStr)
        => Nullable_QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.FloorHours(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(FloorHourCases))]
    public void Nullable_Quantize_Hour_Floor_Returns_Expected(string inputStr, string expectedStr)
        => Nullable_QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.Quantize(x, TimePrecision.Hour, QuantizationMode.Floor));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(FloorHourCases))]
    public void Nullable_QuantizeHours_Floor_Returns_Expected(string inputStr, string expectedStr)
        => Nullable_QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.QuantizeHours(x, QuantizationMode.Floor));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(FloorHourCases))]
    public void Nullable_Instance_Quantize_Hour_Floor_Returns_Expected(string inputStr, string expectedStr)
        => Nullable_QuantizeTest(inputStr, expectedStr, x => new TimeQuantizer(TimePrecision.Hour, QuantizationMode.Floor).Quantize(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(FloorHourCases))]
    public void Nullable_Extension_FloorHours_Returns_Expected(string inputStr, string expectedStr)
        => Nullable_QuantizeTest(inputStr, expectedStr, x => x?.FloorHours());
}
