using Xunit;

namespace jaytwo.Rounding.Tests.TimeQuantizerTests.DateTimeTests;

public class DateTimeQuantizeTests
{
    public static TheoryData<string, string> CeilingMicrosecondCases
        => new()
        {
            { "2023-01-01 00:00:00.0000121", "2023-01-01 00:00:00.000013" },
            { "2023-01-01 00:00:00.0000130", "2023-01-01 00:00:00.000013" },
            { "2023-01-01 00:00:00.0000139", "2023-01-01 00:00:00.000014" },
        };

    public static TheoryData<string, string> FloorMicrosecondCases
        => new()
        {
            { "2023-01-01 00:00:00.0000121", "2023-01-01 00:00:00.000012" },
            { "2023-01-01 00:00:00.0000130", "2023-01-01 00:00:00.000013" },
            { "2023-01-01 00:00:00.0000139", "2023-01-01 00:00:00.000013" },
        };

    public static TheoryData<string, string> TruncateMicrosecondCases
        => FloorMicrosecondCases; // no such thing as negative dates

    public static TheoryData<string, string> CeilingMillisecondCases
        => new()
        {
            { "2023-01-01 00:00:00.0121", "2023-01-01 00:00:00.013" },
            { "2023-01-01 00:00:00.0130", "2023-01-01 00:00:00.013" },
            { "2023-01-01 00:00:00.0139", "2023-01-01 00:00:00.014" },
        };

    public static TheoryData<string, string> FloorMillisecondCases
        => new()
        {
            { "2023-01-01 00:00:00.0121", "2023-01-01 00:00:00.012" },
            { "2023-01-01 00:00:00.0130", "2023-01-01 00:00:00.013" },
            { "2023-01-01 00:00:00.0139", "2023-01-01 00:00:00.013" },
        };

    public static TheoryData<string, string> TruncateMillisecondCases
        => FloorMillisecondCases; // no such thing as negative dates

    public static TheoryData<string, string> CeilingSecondCases
        => new()
        {
            { "2023-01-01 00:00:12.1", "2023-01-01 00:00:13" },
            { "2023-01-01 00:00:13.0", "2023-01-01 00:00:13" },
            { "2023-01-01 00:00:13.9", "2023-01-01 00:00:14" },
        };

    public static TheoryData<string, string> FloorSecondCases
        => new()
        {
            { "2023-01-01 00:00:12.1", "2023-01-01 00:00:12" },
            { "2023-01-01 00:00:13.0", "2023-01-01 00:00:13" },
            { "2023-01-01 00:00:13.9", "2023-01-01 00:00:13" },
        };

    public static TheoryData<string, string> TruncateSecondCases
        => FloorSecondCases; // no such thing as negative dates

    public static TheoryData<string, string> CeilingMinuteCases
        => new()
        {
            { "2023-01-01 00:12:01", "2023-01-01 00:13:00" },
            { "2023-01-01 00:13:00", "2023-01-01 00:13:00" },
            { "2023-01-01 00:13:59", "2023-01-01 00:14:00" },
        };

    public static TheoryData<string, string> FloorMinuteCases
        => new()
        {
            { "2023-01-01 00:12:01", "2023-01-01 00:12:00" },
            { "2023-01-01 00:13:00", "2023-01-01 00:13:00" },
            { "2023-01-01 00:13:59", "2023-01-01 00:13:00" },
        };

    public static TheoryData<string, string> TruncateMinuteCases
        => FloorMinuteCases; // no such thing as negative dates

    public static TheoryData<string, string> CeilingHourCases
        => new()
        {
            { "2023-01-01 12:00:01", "2023-01-01 13:00:00" },
            { "2023-01-01 13:00:00", "2023-01-01 13:00:00" },
            { "2023-01-01 13:59:59", "2023-01-01 14:00:00" },
        };

    public static TheoryData<string, string> FloorHourCases
        => new()
        {
            { "2023-01-01 12:00:01", "2023-01-01 12:00:00" },
            { "2023-01-01 13:00:00", "2023-01-01 13:00:00" },
            { "2023-01-01 13:59:59", "2023-01-01 13:00:00" },
        };

    public static TheoryData<string, string> TruncateHourCases
        => FloorHourCases; // no such thing as negative dates

    public static TheoryData<string, string> CeilingDayCases
        => new()
        {
            { "2023-01-12 00:00:01", "2023-01-13 00:00:00" },
            { "2023-01-13 00:00:00", "2023-01-13 00:00:00" },
            { "2023-01-13 23:59:59", "2023-01-14 00:00:00" },
        };

    public static TheoryData<string, string> FloorDayCases
        => new()
        {
            { "2023-01-12 00:00:01", "2023-01-12 00:00:00" },
            { "2023-01-13 00:00:00", "2023-01-13 00:00:00" },
            { "2023-01-13 23:59:59", "2023-01-13 00:00:00" },
        };

    public static TheoryData<string, string> TruncateDayCases
        => FloorDayCases; // no such thing as negative dates

    internal static void QuantizeTest(string inputStr, string expectedStr, Func<DateTime, DateTime> action)
    {
        // arrange
        var date = DateTime.Parse(inputStr);
        var expected = DateTime.Parse(expectedStr);

        // act
        var actual = action(date);

        // assert
        Assert.Equal(expected, actual);
    }

    internal static void Nullable_QuantizeTest(string? inputStr, string? expectedStr, Func<DateTime?, DateTime?> action)
    {
        // arrange
        var date = DateTimeParse(inputStr);
        var expected = DateTimeParse(expectedStr);

        // act
        var actual = action(date);

        // assert
        Assert.Equal(expected, actual);
    }

    internal static DateTime? DateTimeParse(string? inputStr) => !string.IsNullOrEmpty(inputStr) ? DateTime.Parse(inputStr) : null;
}
