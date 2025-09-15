using Xunit;

namespace jaytwo.Rounding.Tests.QuantizerTests.DecimalTests;

public class CeilingTests : DecimalQuantizeTests
{
    [Theory]
    [MemberData(nameof(CeilingCases))]
    public void Ceiling_returns_expected_results(decimal value, int digits, decimal expected)
        => QuantizeDecimalAssert(value, digits, expected, (v, d) => Quantizer.Ceiling(v, d));

    [Theory]
    [MemberData(nameof(CeilingCases))]
    public void Quantize_Ceiling_returns_expected_results(decimal value, int digits, decimal expected)
        => QuantizeDecimalAssert(value, digits, expected, (v, d) => Quantizer.Quantize(v, d, QuantizationMode.Ceiling));

    [Theory]
    [MemberData(nameof(CeilingCases))]
    public void Ceiling_instance_returns_expected_results(decimal value, int digits, decimal expected)
        => QuantizeDecimalAssert(value, digits, expected, (v, d) => new Quantizer(QuantizationMode.Ceiling, d).Quantize(v));

    [Theory]
    [InlineData(null, 2, null)]
    [MemberData(nameof(CeilingCases))]
    public void Ceiling_nullable_returns_expected_results(double? value, int digits, double? expected)
        => QuantizeDecimalAssert(value, digits, expected, (v, d) => Quantizer.Ceiling(v, d));

    [Theory]
    [InlineData(null, 2, null)]
    [MemberData(nameof(CeilingCases))]
    public void Quantize_Ceiling_nullable_returns_expected_results(double? value, int digits, double? expected)
        => QuantizeDecimalAssert(value, digits, expected, (v, d) => Quantizer.Quantize(v, d, QuantizationMode.Ceiling));

    [Theory]
    [InlineData(null, 2, null)]
    [MemberData(nameof(CeilingCases))]
    public void Ceiling_nullable_instance_returns_expected_results(double? value, int digits, double? expected)
        => QuantizeDecimalAssert(value, digits, expected, (v, d) => new Quantizer(QuantizationMode.Ceiling, d).Quantize(v));
}
