using Xunit;

namespace jaytwo.Rounding.Tests.QuantizerTests.DoubleTests;

public class FloorTests : DoublelQuantizeTests
{
    [Theory]
    [MemberData(nameof(FloorCases))]
    public void Floor_returns_expected_results(double value, int digits, double expected)
        => QuantizeDoubleAssert(value, digits, expected, (v, d) => Quantizer.Floor(v, d));

    [Theory]
    [MemberData(nameof(FloorCases))]
    public void Floor_instance_returns_expected_results(double value, int digits, double expected)
        => QuantizeDoubleAssert(value, digits, expected, (v, d) => new Quantizer(QuantizationMode.Floor, d).Quantize(v));

    [Theory]
    [InlineData(null, 2, null)]
    [MemberData(nameof(FloorCases))]
    public void Floor_nullable_returns_expected_results(double? value, int digits, double? expected)
        => QuantizeDoubleAssert(value, digits, expected, (v, d) => Quantizer.Floor(v, d));

    [Theory]
    [InlineData(null, 2, null)]
    [MemberData(nameof(FloorCases))]
    public void Floor_nullable_instance_returns_expected_results(double? value, int digits, double? expected)
        => QuantizeDoubleAssert(value, digits, expected, (v, d) => new Quantizer(QuantizationMode.Floor, d).Quantize(v));
}
