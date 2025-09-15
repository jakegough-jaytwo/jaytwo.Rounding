using System;
using Xunit;

namespace jaytwo.Rounding.Tests.QuantizerTests.DecimalTests;

public class DecimalQuantizeTests : QuantizeTestsCases
{
    internal static void QuantizeDecimalAssert(decimal value, int digits, decimal expected, Func<decimal, int, decimal> quantizeMethod)
    {
        // arrange

        // act
        var actual = quantizeMethod.Invoke(value, digits);

        // assert
        Assert.Equal(expected, actual);
    }

    internal static void QuantizeDecimalAssert(double? value, int digits, double? expected, Func<decimal?, int, decimal?> quantizeMethod)
    {
        // arrange

        // act
        var actual = quantizeMethod.Invoke((decimal?)value, digits);

        // assert
        Assert.Equal((decimal?)expected, actual);
    }
}
