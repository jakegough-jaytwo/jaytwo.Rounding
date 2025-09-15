using Xunit;

namespace jaytwo.Rounding.Tests.TimeQuantizerTests.DateTimeOffsetTests.FloorTests;

public class MicrosecondsTests : DateTimeOffsetQuantizeTests
{
    [Theory]
    [MemberData(nameof(FloorMicrosecondCases))]
    public void FloorMicroseconds_Returns_Expected(string inputStr, string expectedStr)
        => QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.FloorMicroseconds(x));

    [Theory]
    [MemberData(nameof(FloorMicrosecondCases))]
    public void Quantize_Microsecond_Floor_Returns_Expected(string inputStr, string expectedStr)
        => QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.Quantize(x, TimePrecision.Microsecond, QuantizationMode.Floor));

    [Theory]
    [MemberData(nameof(FloorMicrosecondCases))]
    public void QuantizeMicroseconds_Floor_Returns_Expected(string inputStr, string expectedStr)
        => QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.QuantizeMicroseconds(x, QuantizationMode.Floor));

    [Theory]
    [MemberData(nameof(FloorMicrosecondCases))]
    public void Instance_Quantize_Microsecond_Floor_Returns_Expected(string inputStr, string expectedStr)
        => QuantizeTest(inputStr, expectedStr, x => new TimeQuantizer(TimePrecision.Microsecond, QuantizationMode.Floor).Quantize(x));

    [Theory]
    [MemberData(nameof(FloorMicrosecondCases))]
    public void Extension_FloorMicroseconds_Returns_Expected(string inputStr, string expectedStr)
        => QuantizeTest(inputStr, expectedStr, x => x.FloorMicroseconds());

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(FloorMicrosecondCases))]
    public void Nullable_FloorMicroseconds_Returns_Expected(string inputStr, string expectedStr)
        => Nullable_QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.FloorMicroseconds(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(FloorMicrosecondCases))]
    public void Nullable_Quantize_Microsecond_Floor_Returns_Expected(string inputStr, string expectedStr)
        => Nullable_QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.Quantize(x, TimePrecision.Microsecond, QuantizationMode.Floor));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(FloorMicrosecondCases))]
    public void Nullable_QuantizeMicroseconds_Floor_Returns_Expected(string inputStr, string expectedStr)
        => Nullable_QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.QuantizeMicroseconds(x, QuantizationMode.Floor));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(FloorMicrosecondCases))]
    public void Nullable_Instance_Quantize_Microsecond_Floor_Returns_Expected(string inputStr, string expectedStr)
        => Nullable_QuantizeTest(inputStr, expectedStr, x => new TimeQuantizer(TimePrecision.Microsecond, QuantizationMode.Floor).Quantize(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(FloorMicrosecondCases))]
    public void Nullable_Extension_FloorMicroseconds_Returns_Expected(string inputStr, string expectedStr)
        => Nullable_QuantizeTest(inputStr, expectedStr, x => x?.FloorMicroseconds());
}
