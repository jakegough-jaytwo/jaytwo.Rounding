using Xunit;

namespace jaytwo.Rounding.Tests.TimeQuantizerTests.DateTimeOffsetTests.CeilingTests;

public class MicrosecondsTests : DateTimeOffsetQuantizeTests
{
    [Theory]
    [MemberData(nameof(CeilingMicrosecondCases))]
    public void CeilingMicroseconds_Returns_Expected(string inputStr, string expectedStr)
        => QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.CeilingMicroseconds(x));

    [Theory]
    [MemberData(nameof(CeilingMicrosecondCases))]
    public void Quantize_Microsecond_Ceiling_Returns_Expected(string inputStr, string expectedStr)
        => QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.Quantize(x, TimePrecision.Microsecond, QuantizationMode.Ceiling));

    [Theory]
    [MemberData(nameof(CeilingMicrosecondCases))]
    public void QuantizeMicroseconds_Ceiling_Returns_Expected(string inputStr, string expectedStr)
        => QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.QuantizeMicroseconds(x, QuantizationMode.Ceiling));

    [Theory]
    [MemberData(nameof(CeilingMicrosecondCases))]
    public void Instance_Quantize_Microsecond_Ceiling_Returns_Expected(string inputStr, string expectedStr)
        => QuantizeTest(inputStr, expectedStr, x => new TimeQuantizer(TimePrecision.Microsecond, QuantizationMode.Ceiling).Quantize(x));

    [Theory]
    [MemberData(nameof(CeilingMicrosecondCases))]
    public void Extension_CeilingMicroseconds_Returns_Expected(string inputStr, string expectedStr)
        => QuantizeTest(inputStr, expectedStr, x => x.CeilingMicroseconds());

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(CeilingMicrosecondCases))]
    public void Nullable_CeilingMicroseconds_Returns_Expected(string inputStr, string expectedStr)
        => Nullable_QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.CeilingMicroseconds(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(CeilingMicrosecondCases))]
    public void Nullable_Quantize_Microsecond_Ceiling_Returns_Expected(string inputStr, string expectedStr)
        => Nullable_QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.Quantize(x, TimePrecision.Microsecond, QuantizationMode.Ceiling));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(CeilingMicrosecondCases))]
    public void Nullable_QuantizeMicroseconds_Ceiling_Returns_Expected(string inputStr, string expectedStr)
        => Nullable_QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.QuantizeMicroseconds(x, QuantizationMode.Ceiling));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(CeilingMicrosecondCases))]
    public void Nullable_Instance_Quantize_Microsecond_Ceiling_Returns_Expected(string inputStr, string expectedStr)
        => Nullable_QuantizeTest(inputStr, expectedStr, x => new TimeQuantizer(TimePrecision.Microsecond, QuantizationMode.Ceiling).Quantize(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(CeilingMicrosecondCases))]
    public void Nullable_Extension_CeilingMicroseconds_Returns_Expected(string inputStr, string expectedStr)
        => Nullable_QuantizeTest(inputStr, expectedStr, x => x?.CeilingMicroseconds());
}
