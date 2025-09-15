using Xunit;

namespace jaytwo.Rounding.Tests.QuantizerTests.DecimalTests;

public class TruncateTests : DecimalQuantizeTests
{
    [Theory]
    [MemberData(nameof(TruncateCases))]
    public void Truncate_returns_expected_results(decimal value, int digits, decimal expected)
        => QuantizeDecimalAssert(value, digits, expected, (v, d) => Quantizer.Truncate(v, d));

    [Theory]
    [MemberData(nameof(TruncateCases))]
    public void Quantize_Truncate_returns_expected_results(decimal value, int digits, decimal expected)
        => QuantizeDecimalAssert(value, digits, expected, (v, d) => Quantizer.Quantize(v, d, QuantizationMode.Truncate));

    [Theory]
    [MemberData(nameof(TruncateCases))]
    public void Truncate_instance_returns_expected_results(decimal value, int digits, decimal expected)
        => QuantizeDecimalAssert(value, digits, expected, (v, d) => new Quantizer(QuantizationMode.Truncate, d).Quantize(v));

    [Theory]
    [InlineData(null, 2, null)]
    [MemberData(nameof(TruncateCases))]
    public void Truncate_nullable_returns_expected_results(double? value, int digits, double? expected)
        => QuantizeDecimalAssert(value, digits, expected, (v, d) => Quantizer.Truncate(v, d));

    [Theory]
    [InlineData(null, 2, null)]
    [MemberData(nameof(TruncateCases))]
    public void Quantize_Truncate_nullable_returns_expected_results(double? value, int digits, double? expected)
        => QuantizeDecimalAssert(value, digits, expected, (v, d) => Quantizer.Quantize(v, d, QuantizationMode.Truncate));

    [Theory]
    [InlineData(null, 2, null)]
    [MemberData(nameof(TruncateCases))]
    public void Truncate_nullable_instance_returns_expected_results(double? value, int digits, double? expected)
        => QuantizeDecimalAssert(value, digits, expected, (v, d) => new Quantizer(QuantizationMode.Truncate, d).Quantize(v));
}
