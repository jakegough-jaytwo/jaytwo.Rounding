using System;
using Xunit;

namespace jaytwo.Rounding.Tests.QuantizerTests.DoubleTests;

public class DoublelQuantizeTests : QuantizeTestsCases
{
    internal static void QuantizeDoubleAssert(double value, int digits, double expected, Func<double, int, double> quantizeMethod)
    {
        // arrange

        // act
        var actual = quantizeMethod.Invoke(value, digits);

        // assert
        Assert.Equal(expected, actual);
    }

    internal static void QuantizeDoubleAssert(double? value, int digits, double? expected, Func<double?, int, double?> quantizeMethod)
    {
        // arrange

        // act
        var actual = quantizeMethod.Invoke(value, digits);

        // assert
        Assert.Equal(expected, actual);
    }
}
