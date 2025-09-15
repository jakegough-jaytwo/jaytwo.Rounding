using Xunit;

namespace jaytwo.Rounding.Tests.QuantizerTests.DoubleTests;

public class CeilingTests : DoublelQuantizeTests
{
    [Theory]
    [MemberData(nameof(CeilingCases))]
    public void Ceiling_returns_expected_results(double value, int digits, double expected)
        => QuantizeDoubleAssert(value, digits, expected, (v, d) => Quantizer.Ceiling(v, d));

    [Theory]
    [MemberData(nameof(CeilingCases))]
    public void Ceiling_instance_returns_expected_results(double value, int digits, double expected)
        => QuantizeDoubleAssert(value, digits, expected, (v, d) => new Quantizer(QuantizationMode.Ceiling, d).Quantize(v));

    [Theory]
    [InlineData(null, 2, null)]
    [MemberData(nameof(CeilingCases))]
    public void Ceiling_nullable_returns_expected_results(double? value, int digits, double? expected)
        => QuantizeDoubleAssert(value, digits, expected, (v, d) => Quantizer.Ceiling(v, d));

    [Theory]
    [InlineData(null, 2, null)]
    [MemberData(nameof(CeilingCases))]
    public void Ceiling_nullable_instance_returns_expected_results(double? value, int digits, double? expected)
        => QuantizeDoubleAssert(value, digits, expected, (v, d) => new Quantizer(QuantizationMode.Ceiling, d).Quantize(v));
}
