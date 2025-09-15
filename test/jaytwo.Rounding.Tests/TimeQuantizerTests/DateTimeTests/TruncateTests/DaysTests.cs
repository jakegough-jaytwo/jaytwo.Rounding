using Xunit;

namespace jaytwo.Rounding.Tests.TimeQuantizerTests.DateTimeTests.TruncateTests;

public class DaysTests : DateTimeQuantizeTests
{
    [Theory]
    [MemberData(nameof(TruncateDayCases))]
    public void TruncateDays_Returns_Expected(string inputStr, string expectedStr)
        => QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.TruncateDays(x));

    [Theory]
    [MemberData(nameof(TruncateDayCases))]
    public void Quantize_Day_Truncate_Returns_Expected(string inputStr, string expectedStr)
        => QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.Quantize(x, TimePrecision.Day, QuantizationMode.Truncate));

    [Theory]
    [MemberData(nameof(TruncateDayCases))]
    public void QuantizeDays_Truncate_Returns_Expected(string inputStr, string expectedStr)
        => QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.QuantizeDays(x, QuantizationMode.Truncate));

    [Theory]
    [MemberData(nameof(TruncateDayCases))]
    public void Instance_Quantize_Day_Truncate_Returns_Expected(string inputStr, string expectedStr)
        => QuantizeTest(inputStr, expectedStr, x => new TimeQuantizer(TimePrecision.Day, QuantizationMode.Truncate).Quantize(x));

    [Theory]
    [MemberData(nameof(TruncateDayCases))]
    public void Extension_TruncateDays_Returns_Expected(string inputStr, string expectedStr)
        => QuantizeTest(inputStr, expectedStr, x => x.TruncateDays());

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TruncateDayCases))]
    public void Nullable_TruncateDays_Returns_Expected(string inputStr, string expectedStr)
        => Nullable_QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.TruncateDays(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TruncateDayCases))]
    public void Nullable_Quantize_Day_Truncate_Returns_Expected(string inputStr, string expectedStr)
        => Nullable_QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.Quantize(x, TimePrecision.Day, QuantizationMode.Truncate));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TruncateDayCases))]
    public void Nullable_QuantizeDays_Truncate_Returns_Expected(string inputStr, string expectedStr)
        => Nullable_QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.QuantizeDays(x, QuantizationMode.Truncate));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TruncateDayCases))]
    public void Nullable_Instance_Quantize_Day_Truncate_Returns_Expected(string inputStr, string expectedStr)
        => Nullable_QuantizeTest(inputStr, expectedStr, x => new TimeQuantizer(TimePrecision.Day, QuantizationMode.Truncate).Quantize(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TruncateDayCases))]
    public void Nullable_Extension_TruncateDays_Returns_Expected(string inputStr, string expectedStr)
        => Nullable_QuantizeTest(inputStr, expectedStr, x => x?.TruncateDays());
}
