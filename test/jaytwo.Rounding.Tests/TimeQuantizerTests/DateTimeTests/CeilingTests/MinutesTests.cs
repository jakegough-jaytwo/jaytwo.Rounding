using Xunit;

namespace jaytwo.Rounding.Tests.TimeQuantizerTests.DateTimeTests.CeilingTests;

public class MinutesTests : DateTimeQuantizeTests
{
    [Theory]
    [MemberData(nameof(CeilingMinuteCases))]
    public void CeilingMinutes_Returns_Expected(string inputStr, string expectedStr)
        => QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.CeilingMinutes(x));

    [Theory]
    [MemberData(nameof(CeilingMinuteCases))]
    public void Quantize_Minute_Ceiling_Returns_Expected(string inputStr, string expectedStr)
        => QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.Quantize(x, TimePrecision.Minute, QuantizationMode.Ceiling));

    [Theory]
    [MemberData(nameof(CeilingMinuteCases))]
    public void QuantizeMinutes_Ceiling_Returns_Expected(string inputStr, string expectedStr)
        => QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.QuantizeMinutes(x, QuantizationMode.Ceiling));

    [Theory]
    [MemberData(nameof(CeilingMinuteCases))]
    public void Instance_Quantize_Minute_Ceiling_Returns_Expected(string inputStr, string expectedStr)
        => QuantizeTest(inputStr, expectedStr, x => new TimeQuantizer(TimePrecision.Minute, QuantizationMode.Ceiling).Quantize(x));

    [Theory]
    [MemberData(nameof(CeilingMinuteCases))]
    public void Extension_CeilingMinutes_Returns_Expected(string inputStr, string expectedStr)
        => QuantizeTest(inputStr, expectedStr, x => x.CeilingMinutes());

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(CeilingMinuteCases))]
    public void Nullable_CeilingMinutes_Returns_Expected(string inputStr, string expectedStr)
        => Nullable_QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.CeilingMinutes(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(CeilingMinuteCases))]
    public void Nullable_Quantize_Minute_Ceiling_Returns_Expected(string inputStr, string expectedStr)
        => Nullable_QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.Quantize(x, TimePrecision.Minute, QuantizationMode.Ceiling));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(CeilingMinuteCases))]
    public void Nullable_QuantizeMinutes_Ceiling_Returns_Expected(string inputStr, string expectedStr)
        => Nullable_QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.QuantizeMinutes(x, QuantizationMode.Ceiling));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(CeilingMinuteCases))]
    public void Nullable_Instance_Quantize_Minute_Ceiling_Returns_Expected(string inputStr, string expectedStr)
        => Nullable_QuantizeTest(inputStr, expectedStr, x => new TimeQuantizer(TimePrecision.Minute, QuantizationMode.Ceiling).Quantize(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(CeilingMinuteCases))]
    public void Nullable_Extension_CeilingMinutes_Returns_Expected(string inputStr, string expectedStr)
        => Nullable_QuantizeTest(inputStr, expectedStr, x => x?.CeilingMinutes());
}
