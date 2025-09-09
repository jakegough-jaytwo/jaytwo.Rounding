using Xunit;

namespace jaytwo.Rounding.Tests;

public class AbsoluteRounderTests
{
    [Theory]
    [InlineData(0.11, 2, 0.11)]
    [InlineData(0.111, 2, 0.11)]
    [InlineData(0.11, 3, 0.11)]
    [InlineData(0.111, 3, 0.111)]
    [InlineData(0.1111, 3, 0.111)]
    [InlineData(0.99, 2, 0.99)]
    [InlineData(0.999, 2, 0.99)]
    [InlineData(0.99, 3, 0.99)]
    [InlineData(0.999, 3, 0.999)]
    [InlineData(0.9999, 3, 0.999)]
    [InlineData(-0.11, 2, -0.11)]
    [InlineData(-0.111, 2, -0.12)]
    [InlineData(-0.11, 3, -0.11)]
    [InlineData(-0.111, 3, -0.111)]
    [InlineData(-0.1111, 3, -0.112)]
    [InlineData(-0.99, 2, -0.99)]
    [InlineData(-0.999, 2, -1)]
    [InlineData(-0.99, 3, -0.99)]
    [InlineData(-0.999, 3, -0.999)]
    [InlineData(-0.9999, 3, -1)]
    public void RoundFloor_double_returns_expected_results(double value, int digits, double expected)
    {
        // arrange

        // act
        var actual = AbsoluteRounder.RoundFloor(value, digits);

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(null, 2, null)]
    [InlineData(0.11, 2, 0.11)]
    [InlineData(0.111, 2, 0.11)]
    [InlineData(0.11, 3, 0.11)]
    [InlineData(0.111, 3, 0.111)]
    [InlineData(0.1111, 3, 0.111)]
    [InlineData(0.99, 2, 0.99)]
    [InlineData(0.999, 2, 0.99)]
    [InlineData(0.99, 3, 0.99)]
    [InlineData(0.999, 3, 0.999)]
    [InlineData(0.9999, 3, 0.999)]
    [InlineData(-0.11, 2, -0.11)]
    [InlineData(-0.111, 2, -0.12)]
    [InlineData(-0.11, 3, -0.11)]
    [InlineData(-0.111, 3, -0.111)]
    [InlineData(-0.1111, 3, -0.112)]
    [InlineData(-0.99, 2, -0.99)]
    [InlineData(-0.999, 2, -1)]
    [InlineData(-0.99, 3, -0.99)]
    [InlineData(-0.999, 3, -0.999)]
    [InlineData(-0.9999, 3, -1)]
    public void RoundFloor_nullable_double_returns_expected_results(double? value, int digits, double? expected)
    {
        // arrange

        // act
        var actual = AbsoluteRounder.RoundFloor(value, digits);

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(0.11, 2, 0.11)]
    [InlineData(0.111, 2, 0.11)]
    [InlineData(0.11, 3, 0.11)]
    [InlineData(0.111, 3, 0.111)]
    [InlineData(0.1111, 3, 0.111)]
    [InlineData(0.99, 2, 0.99)]
    [InlineData(0.999, 2, 0.99)]
    [InlineData(0.99, 3, 0.99)]
    [InlineData(0.999, 3, 0.999)]
    [InlineData(0.9999, 3, 0.999)]
    [InlineData(-0.11, 2, -0.11)]
    [InlineData(-0.111, 2, -0.12)]
    [InlineData(-0.11, 3, -0.11)]
    [InlineData(-0.111, 3, -0.111)]
    [InlineData(-0.1111, 3, -0.112)]
    [InlineData(-0.99, 2, -0.99)]
    [InlineData(-0.999, 2, -1)]
    [InlineData(-0.99, 3, -0.99)]
    [InlineData(-0.999, 3, -0.999)]
    [InlineData(-0.9999, 3, -1)]
    public void RoundFloor_decimal_returns_expected_results(decimal value, int digits, decimal expected)
    {
        // arrange

        // act
        var actual = AbsoluteRounder.RoundFloor(value, digits);

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(null, 2, null)]
    [InlineData(0.11, 2, 0.11)]
    [InlineData(0.111, 2, 0.11)]
    [InlineData(0.11, 3, 0.11)]
    [InlineData(0.111, 3, 0.111)]
    [InlineData(0.1111, 3, 0.111)]
    [InlineData(0.99, 2, 0.99)]
    [InlineData(0.999, 2, 0.99)]
    [InlineData(0.99, 3, 0.99)]
    [InlineData(0.999, 3, 0.999)]
    [InlineData(0.9999, 3, 0.999)]
    [InlineData(-0.11, 2, -0.11)]
    [InlineData(-0.111, 2, -0.12)]
    [InlineData(-0.11, 3, -0.11)]
    [InlineData(-0.111, 3, -0.111)]
    [InlineData(-0.1111, 3, -0.112)]
    [InlineData(-0.99, 2, -0.99)]
    [InlineData(-0.999, 2, -1)]
    [InlineData(-0.99, 3, -0.99)]
    [InlineData(-0.999, 3, -0.999)]
    [InlineData(-0.9999, 3, -1)]
    public void RoundFloor_nullable_decimal_returns_expected_results(double? value, int digits, double? expected)
    {
        // arrange

        // act
        var actual = AbsoluteRounder.RoundFloor((decimal?)value, digits);

        // assert
        Assert.Equal((decimal?)expected, actual);
    }

    [Theory]
    [InlineData(0.11, 2, 0.11)]
    [InlineData(0.111, 2, 0.12)]
    [InlineData(0.11, 3, 0.11)]
    [InlineData(0.111, 3, 0.111)]
    [InlineData(0.1111, 3, 0.112)]
    [InlineData(0.99, 2, 0.99)]
    [InlineData(0.999, 2, 1)]
    [InlineData(0.99, 3, 0.99)]
    [InlineData(0.999, 3, 0.999)]
    [InlineData(0.9999, 3, 1)]
    [InlineData(-0.11, 2, -0.11)]
    [InlineData(-0.111, 2, -0.11)]
    [InlineData(-0.11, 3, -0.11)]
    [InlineData(-0.111, 3, -0.111)]
    [InlineData(-0.1111, 3, -0.111)]
    [InlineData(-0.99, 2, -0.99)]
    [InlineData(-0.999, 2, -0.99)]
    [InlineData(-0.99, 3, -0.99)]
    [InlineData(-0.999, 3, -0.999)]
    [InlineData(-0.9999, 3, -0.999)]
    public void RoundCeiling_double_returns_expected_results(double value, int digits, double expected)
    {
        // arrange

        // act
        var actual = AbsoluteRounder.RoundCeiling(value, digits);

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(null, 2, null)]
    [InlineData(0.11, 2, 0.11)]
    [InlineData(0.111, 2, 0.12)]
    [InlineData(0.11, 3, 0.11)]
    [InlineData(0.111, 3, 0.111)]
    [InlineData(0.1111, 3, 0.112)]
    [InlineData(0.99, 2, 0.99)]
    [InlineData(0.999, 2, 1)]
    [InlineData(0.99, 3, 0.99)]
    [InlineData(0.999, 3, 0.999)]
    [InlineData(0.9999, 3, 1)]
    [InlineData(-0.11, 2, -0.11)]
    [InlineData(-0.111, 2, -0.11)]
    [InlineData(-0.11, 3, -0.11)]
    [InlineData(-0.111, 3, -0.111)]
    [InlineData(-0.1111, 3, -0.111)]
    [InlineData(-0.99, 2, -0.99)]
    [InlineData(-0.999, 2, -0.99)]
    [InlineData(-0.99, 3, -0.99)]
    [InlineData(-0.999, 3, -0.999)]
    [InlineData(-0.9999, 3, -0.999)]
    public void RoundCeiling_nullable_double_returns_expected_results(double? value, int digits, double? expected)
    {
        // arrange

        // act
        var actual = AbsoluteRounder.RoundCeiling(value, digits);

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(0.11, 2, 0.11)]
    [InlineData(0.111, 2, 0.12)]
    [InlineData(0.11, 3, 0.11)]
    [InlineData(0.111, 3, 0.111)]
    [InlineData(0.1111, 3, 0.112)]
    [InlineData(0.99, 2, 0.99)]
    [InlineData(0.999, 2, 1)]
    [InlineData(0.99, 3, 0.99)]
    [InlineData(0.999, 3, 0.999)]
    [InlineData(0.9999, 3, 1)]
    [InlineData(-0.11, 2, -0.11)]
    [InlineData(-0.111, 2, -0.11)]
    [InlineData(-0.11, 3, -0.11)]
    [InlineData(-0.111, 3, -0.111)]
    [InlineData(-0.1111, 3, -0.111)]
    [InlineData(-0.99, 2, -0.99)]
    [InlineData(-0.999, 2, -0.99)]
    [InlineData(-0.99, 3, -0.99)]
    [InlineData(-0.999, 3, -0.999)]
    [InlineData(-0.9999, 3, -0.999)]
    public void RoundCeiling_decimal_returns_expected_results(decimal value, int digits, decimal expected)
    {
        // arrange

        // act
        var actual = AbsoluteRounder.RoundCeiling(value, digits);

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(null, 2, null)]
    [InlineData(0.11, 2, 0.11)]
    [InlineData(0.111, 2, 0.12)]
    [InlineData(0.11, 3, 0.11)]
    [InlineData(0.111, 3, 0.111)]
    [InlineData(0.1111, 3, 0.112)]
    [InlineData(0.99, 2, 0.99)]
    [InlineData(0.999, 2, 1)]
    [InlineData(0.99, 3, 0.99)]
    [InlineData(0.999, 3, 0.999)]
    [InlineData(0.9999, 3, 1)]
    [InlineData(-0.11, 2, -0.11)]
    [InlineData(-0.111, 2, -0.11)]
    [InlineData(-0.11, 3, -0.11)]
    [InlineData(-0.111, 3, -0.111)]
    [InlineData(-0.1111, 3, -0.111)]
    [InlineData(-0.99, 2, -0.99)]
    [InlineData(-0.999, 2, -0.99)]
    [InlineData(-0.99, 3, -0.99)]
    [InlineData(-0.999, 3, -0.999)]
    [InlineData(-0.9999, 3, -0.999)]
    public void RoundCeiling_nullable_decimal_returns_expected_results(double? value, int digits, double? expected)
    {
        // arrange

        // act
        var actual = AbsoluteRounder.RoundCeiling((decimal?)value, digits);

        // assert
        Assert.Equal((decimal?)expected, actual);
    }

    [Theory]
    [InlineData(0.11, 2, 0.11)]
    [InlineData(0.111, 2, 0.11)]
    [InlineData(0.11, 3, 0.11)]
    [InlineData(0.111, 3, 0.111)]
    [InlineData(0.1111, 3, 0.111)]
    [InlineData(0.99, 2, 0.99)]
    [InlineData(0.999, 2, 0.99)]
    [InlineData(0.99, 3, 0.99)]
    [InlineData(0.999, 3, 0.999)]
    [InlineData(0.9999, 3, 0.999)]
    [InlineData(-0.11, 2, -0.11)]
    [InlineData(-0.111, 2, -0.11)]
    [InlineData(-0.11, 3, -0.11)]
    [InlineData(-0.111, 3, -0.111)]
    [InlineData(-0.1111, 3, -0.111)]
    [InlineData(-0.99, 2, -0.99)]
    [InlineData(-0.999, 2, -0.99)]
    [InlineData(-0.99, 3, -0.99)]
    [InlineData(-0.999, 3, -0.999)]
    [InlineData(-0.9999, 3, -0.999)]
    public void RoundTruncate_double_returns_expected_results(double value, int digits, double expected)
    {
        // arrange

        // act
        var actual = AbsoluteRounder.RoundTruncate(value, digits);

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(null, 2, null)]
    [InlineData(0.11, 2, 0.11)]
    [InlineData(0.111, 2, 0.11)]
    [InlineData(0.11, 3, 0.11)]
    [InlineData(0.111, 3, 0.111)]
    [InlineData(0.1111, 3, 0.111)]
    [InlineData(0.99, 2, 0.99)]
    [InlineData(0.999, 2, 0.99)]
    [InlineData(0.99, 3, 0.99)]
    [InlineData(0.999, 3, 0.999)]
    [InlineData(0.9999, 3, 0.999)]
    [InlineData(-0.11, 2, -0.11)]
    [InlineData(-0.111, 2, -0.11)]
    [InlineData(-0.11, 3, -0.11)]
    [InlineData(-0.111, 3, -0.111)]
    [InlineData(-0.1111, 3, -0.111)]
    [InlineData(-0.99, 2, -0.99)]
    [InlineData(-0.999, 2, -0.99)]
    [InlineData(-0.99, 3, -0.99)]
    [InlineData(-0.999, 3, -0.999)]
    [InlineData(-0.9999, 3, -0.999)]
    public void RoundTruncate_nullable_double_returns_expected_results(double? value, int digits, double? expected)
    {
        // arrange

        // act
        var actual = AbsoluteRounder.RoundTruncate(value, digits);

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(0.11, 2, 0.11)]
    [InlineData(0.111, 2, 0.11)]
    [InlineData(0.11, 3, 0.11)]
    [InlineData(0.111, 3, 0.111)]
    [InlineData(0.1111, 3, 0.111)]
    [InlineData(0.99, 2, 0.99)]
    [InlineData(0.999, 2, 0.99)]
    [InlineData(0.99, 3, 0.99)]
    [InlineData(0.999, 3, 0.999)]
    [InlineData(0.9999, 3, 0.999)]
    [InlineData(-0.11, 2, -0.11)]
    [InlineData(-0.111, 2, -0.11)]
    [InlineData(-0.11, 3, -0.11)]
    [InlineData(-0.111, 3, -0.111)]
    [InlineData(-0.1111, 3, -0.111)]
    [InlineData(-0.99, 2, -0.99)]
    [InlineData(-0.999, 2, -0.99)]
    [InlineData(-0.99, 3, -0.99)]
    [InlineData(-0.999, 3, -0.999)]
    [InlineData(-0.9999, 3, -0.999)]
    public void RoundTruncate_decimal_returns_expected_results(decimal value, int digits, decimal expected)
    {
        // arrange

        // act
        var actual = AbsoluteRounder.RoundTruncate(value, digits);

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(null, 2, null)]
    [InlineData(0.11, 2, 0.11)]
    [InlineData(0.111, 2, 0.11)]
    [InlineData(0.11, 3, 0.11)]
    [InlineData(0.111, 3, 0.111)]
    [InlineData(0.1111, 3, 0.111)]
    [InlineData(0.99, 2, 0.99)]
    [InlineData(0.999, 2, 0.99)]
    [InlineData(0.99, 3, 0.99)]
    [InlineData(0.999, 3, 0.999)]
    [InlineData(0.9999, 3, 0.999)]
    [InlineData(-0.11, 2, -0.11)]
    [InlineData(-0.111, 2, -0.11)]
    [InlineData(-0.11, 3, -0.11)]
    [InlineData(-0.111, 3, -0.111)]
    [InlineData(-0.1111, 3, -0.111)]
    [InlineData(-0.99, 2, -0.99)]
    [InlineData(-0.999, 2, -0.99)]
    [InlineData(-0.99, 3, -0.99)]
    [InlineData(-0.999, 3, -0.999)]
    [InlineData(-0.9999, 3, -0.999)]
    public void RoundTruncate_nullable_decimal_returns_expected_results(double? value, int digits, double? expected)
    {
        // arrange

        // act
        var actual = AbsoluteRounder.RoundTruncate((decimal?)value, digits);

        // assert
        Assert.Equal((decimal?)expected, actual);
    }

    [Theory]
    [InlineData(0.111, 2, AbsoluteRounding.Floor, 0.11)]
    [InlineData(0.111, 2, AbsoluteRounding.Ceiling, 0.12)]
    [InlineData(0.111, 2, AbsoluteRounding.Truncate, 0.11)]
    [InlineData(-0.111, 2, AbsoluteRounding.Floor, -0.12)]
    [InlineData(-0.111, 2, AbsoluteRounding.Ceiling, -0.11)]
    [InlineData(-0.111, 2, AbsoluteRounding.Truncate, -0.11)]
    [InlineData(111, -2, AbsoluteRounding.Floor, 100)]
    [InlineData(111, -2, AbsoluteRounding.Ceiling, 200)]
    [InlineData(111, -2, AbsoluteRounding.Truncate, 100)]
    [InlineData(-111, -2, AbsoluteRounding.Floor, -200)]
    [InlineData(-111, -2, AbsoluteRounding.Ceiling, -100)]
    [InlineData(-111, -2, AbsoluteRounding.Truncate, -100)]
    public void Round_double_returns_expected_results(double value, int digits, AbsoluteRounding mode, double expected)
    {
        // arrange

        // act
        var actual = AbsoluteRounder.Round(value, digits, mode);

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(null, 2, AbsoluteRounding.Floor, null)]
    [InlineData(null, 2, AbsoluteRounding.Ceiling, null)]
    [InlineData(null, 2, AbsoluteRounding.Truncate, null)]
    [InlineData(0.111, 2, AbsoluteRounding.Floor, 0.11)]
    [InlineData(0.111, 2, AbsoluteRounding.Ceiling, 0.12)]
    [InlineData(0.111, 2, AbsoluteRounding.Truncate, 0.11)]
    [InlineData(-0.111, 2, AbsoluteRounding.Floor, -0.12)]
    [InlineData(-0.111, 2, AbsoluteRounding.Ceiling, -0.11)]
    [InlineData(-0.111, 2, AbsoluteRounding.Truncate, -0.11)]
    [InlineData(111, -2, AbsoluteRounding.Floor, 100)]
    [InlineData(111, -2, AbsoluteRounding.Ceiling, 200)]
    [InlineData(111, -2, AbsoluteRounding.Truncate, 100)]
    [InlineData(-111, -2, AbsoluteRounding.Floor, -200)]
    [InlineData(-111, -2, AbsoluteRounding.Ceiling, -100)]
    [InlineData(-111, -2, AbsoluteRounding.Truncate, -100)]
    public void Round_nullable_double_returns_expected_results(double? value, int digits, AbsoluteRounding mode, double? expected)
    {
        // arrange

        // act
        var actual = AbsoluteRounder.Round(value, digits, mode);

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(0.111, 2, AbsoluteRounding.Floor, 0.11)]
    [InlineData(0.111, 2, AbsoluteRounding.Ceiling, 0.12)]
    [InlineData(0.111, 2, AbsoluteRounding.Truncate, 0.11)]
    [InlineData(-0.111, 2, AbsoluteRounding.Floor, -0.12)]
    [InlineData(-0.111, 2, AbsoluteRounding.Ceiling, -0.11)]
    [InlineData(-0.111, 2, AbsoluteRounding.Truncate, -0.11)]
    [InlineData(111, -2, AbsoluteRounding.Floor, 100)]
    [InlineData(111, -2, AbsoluteRounding.Ceiling, 200)]
    [InlineData(111, -2, AbsoluteRounding.Truncate, 100)]
    [InlineData(-111, -2, AbsoluteRounding.Floor, -200)]
    [InlineData(-111, -2, AbsoluteRounding.Ceiling, -100)]
    [InlineData(-111, -2, AbsoluteRounding.Truncate, -100)]
    public void Round_decimal_returns_expected_results(decimal value, int digits, AbsoluteRounding mode, decimal expected)
    {
        // arrange

        // act
        var actual = AbsoluteRounder.Round(value, digits, mode);

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(null, 2, AbsoluteRounding.Floor, null)]
    [InlineData(null, 2, AbsoluteRounding.Ceiling, null)]
    [InlineData(null, 2, AbsoluteRounding.Truncate, null)]
    [InlineData(0.111, 2, AbsoluteRounding.Floor, 0.11)]
    [InlineData(0.111, 2, AbsoluteRounding.Ceiling, 0.12)]
    [InlineData(0.111, 2, AbsoluteRounding.Truncate, 0.11)]
    [InlineData(-0.111, 2, AbsoluteRounding.Floor, -0.12)]
    [InlineData(-0.111, 2, AbsoluteRounding.Ceiling, -0.11)]
    [InlineData(-0.111, 2, AbsoluteRounding.Truncate, -0.11)]
    [InlineData(111, -2, AbsoluteRounding.Floor, 100)]
    [InlineData(111, -2, AbsoluteRounding.Ceiling, 200)]
    [InlineData(111, -2, AbsoluteRounding.Truncate, 100)]
    [InlineData(-111, -2, AbsoluteRounding.Floor, -200)]
    [InlineData(-111, -2, AbsoluteRounding.Ceiling, -100)]
    [InlineData(-111, -2, AbsoluteRounding.Truncate, -100)]
    public void Round_nullable_decimal_returns_expected_results(double? value, int digits, AbsoluteRounding mode, double? expected)
    {
        // arrange

        // act
        var actual = AbsoluteRounder.Round((decimal?)value, digits, mode);

        // assert
        Assert.Equal((decimal?)expected, actual);
    }
}
