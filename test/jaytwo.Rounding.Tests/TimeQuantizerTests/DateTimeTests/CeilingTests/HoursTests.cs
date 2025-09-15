using Xunit;

namespace jaytwo.Rounding.Tests.TimeQuantizerTests.DateTimeTests.CeilingTests;

public class HoursTests : DateTimeQuantizeTests
{
    [Theory]
    [MemberData(nameof(CeilingHourCases))]
    public void CeilingHours_Returns_Expected(string inputStr, string expectedStr)
        => QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.CeilingHours(x));

    [Theory]
    [MemberData(nameof(CeilingHourCases))]
    public void Quantize_Hour_Ceiling_Returns_Expected(string inputStr, string expectedStr)
        => QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.Quantize(x, TimePrecision.Hour, QuantizationMode.Ceiling));

    [Theory]
    [MemberData(nameof(CeilingHourCases))]
    public void QuantizeHours_Ceiling_Returns_Expected(string inputStr, string expectedStr)
        => QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.QuantizeHours(x, QuantizationMode.Ceiling));

    [Theory]
    [MemberData(nameof(CeilingHourCases))]
    public void Instance_Quantize_Hour_Ceiling_Returns_Expected(string inputStr, string expectedStr)
        => QuantizeTest(inputStr, expectedStr, x => new TimeQuantizer(TimePrecision.Hour, QuantizationMode.Ceiling).Quantize(x));

    [Theory]
    [MemberData(nameof(CeilingHourCases))]
    public void Extension_CeilingHours_Returns_Expected(string inputStr, string expectedStr)
        => QuantizeTest(inputStr, expectedStr, x => x.CeilingHours());

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(CeilingHourCases))]
    public void Nullable_CeilingHours_Returns_Expected(string inputStr, string expectedStr)
        => Nullable_QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.CeilingHours(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(CeilingHourCases))]
    public void Nullable_Quantize_Hour_Ceiling_Returns_Expected(string inputStr, string expectedStr)
        => Nullable_QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.Quantize(x, TimePrecision.Hour, QuantizationMode.Ceiling));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(CeilingHourCases))]
    public void Nullable_QuantizeHours_Ceiling_Returns_Expected(string inputStr, string expectedStr)
        => Nullable_QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.QuantizeHours(x, QuantizationMode.Ceiling));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(CeilingHourCases))]
    public void Nullable_Instance_Quantize_Hour_Ceiling_Returns_Expected(string inputStr, string expectedStr)
        => Nullable_QuantizeTest(inputStr, expectedStr, x => new TimeQuantizer(TimePrecision.Hour, QuantizationMode.Ceiling).Quantize(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(CeilingHourCases))]
    public void Nullable_Extension_CeilingHours_Returns_Expected(string inputStr, string expectedStr)
        => Nullable_QuantizeTest(inputStr, expectedStr, x => x?.CeilingHours());
}
