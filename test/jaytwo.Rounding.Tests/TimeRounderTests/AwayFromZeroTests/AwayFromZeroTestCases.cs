using Xunit;

namespace jaytwo.Rounding.Tests.TimeRounderTests.AwayFromZeroTests;

public class AwayFromZeroTestCases : TimeRounderTestCases
{
    internal const MidpointRounding RoundingMode = MidpointRounding.AwayFromZero;

    public static TheoryData<double, double> TestCases
        => new()
        {
            { -0.5,  -1 },
            { -1,  -1 },
            { -1.5,  -2 },
            { 0.5,  1 },
            { 1, 1 },
            { 1.5,  2 },
        };
}
