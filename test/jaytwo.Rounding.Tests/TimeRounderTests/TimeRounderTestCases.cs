using Xunit;

namespace jaytwo.Rounding.Tests;

public class TimeRounderTestCases
{
#if NET7_0_OR_GREATER
    internal static void AssertNearestMicrosecond(double value, double expected, Func<TimeSpan, TimeSpan> roundMethod)
    {
        // arrange
        var timespan = TimeSpan.FromMicroseconds(value);

        // act
        var actual = roundMethod(timespan).TotalMicroseconds;

        // assert
        Assert.Equal(expected, actual);
    }

    internal static void NullableAssertNearestMicrosecond(double? value, double? expected, Func<TimeSpan?, TimeSpan?> roundMethod)
    {
        // arrange
        var timespan = TimeSpanFromMicroseconds(value);

        // act
        var actual = roundMethod(timespan)?.TotalMicroseconds;

        // assert
        Assert.Equal(expected, actual);
    }
#endif

    internal static void AssertNearestMillisecond(double value, double expected, Func<TimeSpan, TimeSpan> roundMethod)
    {
        // arrange
        var timespan = TimeSpan.FromTicks((long)(value * TimeSpan.TicksPerMillisecond));

        // act
        var actual = roundMethod(timespan).TotalMilliseconds;

        // assert
        Assert.Equal(expected, actual);
    }

    internal static void NullableAssertNearestMillisecond(double? value, double? expected, Func<TimeSpan?, TimeSpan?> roundMethod)
    {
        // arrange
        var timespan = TimeSpanFromMilliseconds(value);

        // act
        var actual = roundMethod(timespan)?.TotalMilliseconds;

        // assert
        Assert.Equal(expected, actual);
    }

    internal static void AssertNearestSecond(double value, double expected, Func<TimeSpan, TimeSpan> roundMethod)
    {
        // arrange
        var timespan = TimeSpan.FromTicks((long)(value * TimeSpan.TicksPerSecond));

        // act
        var actual = roundMethod(timespan).TotalSeconds;

        // assert
        Assert.Equal(expected, actual);
    }

    internal static void NullableAssertNearestSecond(double? value, double? expected, Func<TimeSpan?, TimeSpan?> roundMethod)
    {
        // arrange
        var timespan = TimeSpanFromSeconds(value);

        // act
        var actual = roundMethod(timespan)?.TotalSeconds;

        // assert
        Assert.Equal(expected, actual);
    }

    internal static void AssertNearestMinute(double value, double expected, Func<TimeSpan, TimeSpan> roundMethod)
    {
        // arrange
        var timespan = TimeSpan.FromTicks((long)(value * TimeSpan.TicksPerMinute));

        // act
        var actual = roundMethod(timespan).TotalMinutes;

        // assert
        Assert.Equal(expected, actual);
    }

    internal static void NullableAssertNearestMinute(double? value, double? expected, Func<TimeSpan?, TimeSpan?> roundMethod)
    {
        // arrange
        var timespan = TimeSpanFromMinutes(value);

        // act
        var actual = roundMethod(timespan)?.TotalMinutes;

        // assert
        Assert.Equal(expected, actual);
    }

    internal static void AssertNearestHour(double value, double expected, Func<TimeSpan, TimeSpan> roundMethod)
    {
        // arrange
        var timespan = TimeSpan.FromTicks((long)(value * TimeSpan.TicksPerHour));

        // act
        var actual = roundMethod(timespan).TotalHours;

        // assert
        Assert.Equal(expected, actual);
    }

    internal static void NullableAssertNearestHour(double? value, double? expected, Func<TimeSpan?, TimeSpan?> roundMethod)
    {
        // arrange
        var timespan = TimeSpanFromHours(value);

        // act
        var actual = roundMethod(timespan)?.TotalHours;

        // assert
        Assert.Equal(expected, actual);
    }

    internal static void AssertNearestDay(double value, double expected, Func<TimeSpan, TimeSpan> roundMethod)
    {
        // arrange
        var timespan = TimeSpan.FromTicks((long)(value * TimeSpan.TicksPerDay));

        // act
        var actual = roundMethod(timespan).TotalDays;

        // assert
        Assert.Equal(expected, actual);
    }

    internal static void NullableAssertNearestDay(double? value, double? expected, Func<TimeSpan?, TimeSpan?> roundMethod)
    {
        // arrange
        var timespan = TimeSpanFromDays(value);

        // act
        var actual = roundMethod(timespan)?.TotalDays;

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
