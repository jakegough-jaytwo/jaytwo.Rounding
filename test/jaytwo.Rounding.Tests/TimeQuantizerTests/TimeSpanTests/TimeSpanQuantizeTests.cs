using Xunit;

namespace jaytwo.Rounding.Tests.TimeQuantizerTests.TimeSpanTests;

public class TimeSpanQuantizeTests
{
    public static TheoryData<double, double> CeilingCases
        => new()
        {
            { 1.5,  2.0 },
            { 1.0,  1.0 },
            { -1.5, -1.0 },
        };

    public static TheoryData<double, double> FloorCases
        => new()
        {
            { 1.5,  1.0 },
            { 1.0,  1.0 },
            { -1.5, -2.0 },
        };

    public static TheoryData<double, double> TruncateCases
        => new()
        {
            { 1.5,  1.0 },
            { 1.0,  1.0 },
            { -1.5, -1.0 },
        };

#if NET7_0_OR_GREATER
    internal static void MicrosecondsTest(double value, double expected, Func<TimeSpan, TimeSpan> action)
    {
        // arrange
        var timespan = TimeSpan.FromMicroseconds(value);

        // act
        var actual = action(timespan).TotalMicroseconds;

        // assert
        Assert.Equal(expected, actual);
    }

    internal static void Nullable_MicrosecondsTest(double? value, double? expected, Func<TimeSpan?, TimeSpan?> action)
    {
        // arrange
        var timespan = TimeSpanFromMicroseconds(value);

        // act
        var actual = action(timespan)?.TotalMicroseconds;

        // assert
        Assert.Equal(expected, actual);
    }
#endif

    internal static void MillisecondsTest(double value, double expected, Func<TimeSpan, TimeSpan> action)
    {
        // arrange
        var timespan = TimeSpan.FromTicks((long)(value * TimeSpan.TicksPerMillisecond));

        // act
        var actual = action(timespan).TotalMilliseconds;

        // assert
        Assert.Equal(expected, actual);
    }

    internal static void Nullable_MillisecondsTest(double? value, double? expected, Func<TimeSpan?, TimeSpan?> action)
    {
        // arrange
        var timespan = TimeSpanFromMilliseconds(value);

        // act
        var actual = action(timespan)?.TotalMilliseconds;

        // assert
        Assert.Equal(expected, actual);
    }

    internal static void SecondsTest(double value, double expected, Func<TimeSpan, TimeSpan> action)
    {
        // arrange
        var timespan = TimeSpan.FromTicks((long)(value * TimeSpan.TicksPerSecond));

        // act
        var actual = action(timespan).TotalSeconds;

        // assert
        Assert.Equal(expected, actual);
    }

    internal static void Nullable_SecondsTest(double? value, double? expected, Func<TimeSpan?, TimeSpan?> action)
    {
        // arrange
        var timespan = TimeSpanFromSeconds(value);

        // act
        var actual = action(timespan)?.TotalSeconds;

        // assert
        Assert.Equal(expected, actual);
    }

    internal static void MinutesTest(double value, double expected, Func<TimeSpan, TimeSpan> action)
    {
        // arrange
        var timespan = TimeSpan.FromTicks((long)(value * TimeSpan.TicksPerMinute));

        // act
        var actual = action(timespan).TotalMinutes;

        // assert
        Assert.Equal(expected, actual);
    }

    internal static void Nullable_MinutesTest(double? value, double? expected, Func<TimeSpan?, TimeSpan?> action)
    {
        // arrange
        var timespan = TimeSpanFromMinutes(value);

        // act
        var actual = action(timespan)?.TotalMinutes;

        // assert
        Assert.Equal(expected, actual);
    }

    internal static void HoursTest(double value, double expected, Func<TimeSpan, TimeSpan> action)
    {
        // arrange
        var timespan = TimeSpan.FromTicks((long)(value * TimeSpan.TicksPerHour));

        // act
        var actual = action(timespan).TotalHours;

        // assert
        Assert.Equal(expected, actual);
    }

    internal static void Nullable_HoursTest(double? value, double? expected, Func<TimeSpan?, TimeSpan?> action)
    {
        // arrange
        var timespan = TimeSpanFromHours(value);

        // act
        var actual = action(timespan)?.TotalHours;

        // assert
        Assert.Equal(expected, actual);
    }

    internal static void DaysTest(double value, double expected, Func<TimeSpan, TimeSpan> action)
    {
        // arrange
        var timespan = TimeSpan.FromTicks((long)(value * TimeSpan.TicksPerDay));

        // act
        var actual = action(timespan).TotalDays;

        // assert
        Assert.Equal(expected, actual);
    }

    internal static void Nullable_DaysTest(double? value, double? expected, Func<TimeSpan?, TimeSpan?> action)
    {
        // arrange
        var timespan = TimeSpanFromDays(value);

        // act
        var actual = action(timespan)?.TotalDays;

        // assert
        Assert.Equal(expected, actual);
    }

    internal static TimeSpan? TimeSpanFromDays(double? value) => value.HasValue ? TimeSpan.FromTicks((long)(value.Value * TimeSpan.TicksPerDay)) : null;

    internal static TimeSpan? TimeSpanFromHours(double? value) => value.HasValue ? TimeSpan.FromTicks((long)(value.Value * TimeSpan.TicksPerHour)) : null;

    internal static TimeSpan? TimeSpanFromMinutes(double? value) => value.HasValue ? TimeSpan.FromTicks((long)(value.Value * TimeSpan.TicksPerMinute)) : null;

    internal static TimeSpan? TimeSpanFromSeconds(double? value) => value.HasValue ? TimeSpan.FromTicks((long)(value.Value * TimeSpan.TicksPerSecond)) : null;

    internal static TimeSpan? TimeSpanFromMilliseconds(double? value) => value.HasValue ? TimeSpan.FromTicks((long)(value.Value * TimeSpan.TicksPerMillisecond)) : null;

#if NET7_0_OR_GREATER
    internal static TimeSpan? TimeSpanFromMicroseconds(double? value) => value.HasValue ? TimeSpan.FromTicks((long)(value.Value * TimeSpan.TicksPerMicrosecond)) : null;
#endif
}
