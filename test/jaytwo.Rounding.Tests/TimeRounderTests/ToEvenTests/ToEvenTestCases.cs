using Xunit;

namespace jaytwo.Rounding.Tests.TimeRounderTests.ToEvenTests;

public class ToEvenTestCases : TimeRounderTestCases
{
    internal const MidpointRounding RoundingMode = MidpointRounding.ToEven;

    public static TheoryData<double, double> TestCases
        => new()
        {
            { -0.5,  0 },
            { -1,  -1 },
            { -1.5,  -2 },
            { 0.5,  0 },
            { 1, 1 },
            { 1.5,  2 },
        };
}
