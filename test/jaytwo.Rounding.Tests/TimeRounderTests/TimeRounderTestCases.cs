using Xunit;

namespace jaytwo.Rounding.Tests;

public class TimeRounderTestCases
{
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

    internal static void AssertNearestMillisecond(double value, double expected, Func<TimeSpan, TimeSpan> roundMethod)
    {
        // arrange
        var timespan = TimeSpan.FromMilliseconds(value);

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
        var timespan = TimeSpan.FromSeconds(value);

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
        var timespan = TimeSpan.FromMinutes(value);

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
        var timespan = TimeSpan.FromHours(value);

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
        var timespan = TimeSpan.FromDays(value);

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

    internal static TimeSpan? TimeSpanFromDays(double? value) => value.HasValue ? TimeSpan.FromDays(value.Value) : null;

    internal static TimeSpan? TimeSpanFromHours(double? value) => value.HasValue ? TimeSpan.FromHours(value.Value) : null;

    internal static TimeSpan? TimeSpanFromMinutes(double? value) => value.HasValue ? TimeSpan.FromMinutes(value.Value) : null;

    internal static TimeSpan? TimeSpanFromSeconds(double? value) => value.HasValue ? TimeSpan.FromSeconds(value.Value) : null;

    internal static TimeSpan? TimeSpanFromMilliseconds(double? value) => value.HasValue ? TimeSpan.FromMilliseconds(value.Value) : null;

    internal static TimeSpan? TimeSpanFromMicroseconds(double? value) => value.HasValue ? TimeSpan.FromMicroseconds(value.Value) : null;
}
