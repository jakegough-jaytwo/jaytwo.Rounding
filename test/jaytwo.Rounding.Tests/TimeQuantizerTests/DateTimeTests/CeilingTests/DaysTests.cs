using Xunit;

namespace jaytwo.Rounding.Tests.TimeQuantizerTests.DateTimeTests.CeilingTests;

public class DaysTests : DateTimeQuantizeTests
{
    [Theory]
    [MemberData(nameof(CeilingDayCases))]
    public void CeilingDays_Returns_Expected(string inputStr, string expectedStr)
        => QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.CeilingDays(x));

    [Theory]
    [MemberData(nameof(CeilingDayCases))]
    public void Quantize_Day_Ceiling_Returns_Expected(string inputStr, string expectedStr)
        => QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.Quantize(x, TimePrecision.Day, QuantizationMode.Ceiling));

    [Theory]
    [MemberData(nameof(CeilingDayCases))]
    public void QuantizeDays_Ceiling_Returns_Expected(string inputStr, string expectedStr)
        => QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.QuantizeDays(x, QuantizationMode.Ceiling));

    [Theory]
    [MemberData(nameof(CeilingDayCases))]
    public void Instance_Quantize_Day_Ceiling_Returns_Expected(string inputStr, string expectedStr)
        => QuantizeTest(inputStr, expectedStr, x => new TimeQuantizer(TimePrecision.Day, QuantizationMode.Ceiling).Quantize(x));

    [Theory]
    [MemberData(nameof(CeilingDayCases))]
    public void Extension_CeilingDays_Returns_Expected(string inputStr, string expectedStr)
        => QuantizeTest(inputStr, expectedStr, x => x.CeilingDays());

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(CeilingDayCases))]
    public void Nullable_CeilingDays_Returns_Expected(string inputStr, string expectedStr)
        => Nullable_QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.CeilingDays(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(CeilingDayCases))]
    public void Nullable_Quantize_Day_Ceiling_Returns_Expected(string inputStr, string expectedStr)
        => Nullable_QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.Quantize(x, TimePrecision.Day, QuantizationMode.Ceiling));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(CeilingDayCases))]
    public void Nullable_QuantizeDays_Ceiling_Returns_Expected(string inputStr, string expectedStr)
        => Nullable_QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.QuantizeDays(x, QuantizationMode.Ceiling));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(CeilingDayCases))]
    public void Nullable_Instance_Quantize_Day_Ceiling_Returns_Expected(string inputStr, string expectedStr)
        => Nullable_QuantizeTest(inputStr, expectedStr, x => new TimeQuantizer(TimePrecision.Day, QuantizationMode.Ceiling).Quantize(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(CeilingDayCases))]
    public void Nullable_Extension_CeilingDays_Returns_Expected(string inputStr, string expectedStr)
        => Nullable_QuantizeTest(inputStr, expectedStr, x => x?.CeilingDays());
}
