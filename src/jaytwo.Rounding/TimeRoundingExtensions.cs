using System;

namespace jaytwo.Rounding;

public static class TimeRoundingExtensions
{
    public static TimeSpan NearestDay(this TimeSpan input, MidpointRounding midpointRounding = TimeRounder.DefaultTimeMidpointRounding)
        => TimeRounder.NearestDay(input, midpointRounding);

    public static TimeSpan? NearestDay(this TimeSpan? input, MidpointRounding midpointRounding = TimeRounder.DefaultTimeMidpointRounding)
        => TimeRounder.NearestDay(input, midpointRounding);

    public static TimeSpan NearestHour(this TimeSpan input, MidpointRounding midpointRounding = TimeRounder.DefaultTimeMidpointRounding)
        => TimeRounder.NearestHour(input, midpointRounding);

    public static TimeSpan? NearestHour(this TimeSpan? input, MidpointRounding midpointRounding = TimeRounder.DefaultTimeMidpointRounding)
        => TimeRounder.NearestHour(input, midpointRounding);

    public static TimeSpan NearestMinute(this TimeSpan input, MidpointRounding midpointRounding = TimeRounder.DefaultTimeMidpointRounding)
        => TimeRounder.NearestMinute(input, midpointRounding);

    public static TimeSpan? NearestMinute(this TimeSpan? input, MidpointRounding midpointRounding = TimeRounder.DefaultTimeMidpointRounding)
        => TimeRounder.NearestMinute(input, midpointRounding);

    public static TimeSpan NearestSecond(this TimeSpan input, MidpointRounding midpointRounding = TimeRounder.DefaultTimeMidpointRounding)
        => TimeRounder.NearestSecond(input, midpointRounding);

    public static TimeSpan? NearestSecond(this TimeSpan? input, MidpointRounding midpointRounding = TimeRounder.DefaultTimeMidpointRounding)
        => TimeRounder.NearestSecond(input, midpointRounding);

    public static TimeSpan NearestMillisecond(this TimeSpan input, MidpointRounding midpointRounding = TimeRounder.DefaultTimeMidpointRounding)
        => TimeRounder.NearestMillisecond(input, midpointRounding);

    public static TimeSpan? NearestMillisecond(this TimeSpan? input, MidpointRounding midpointRounding = TimeRounder.DefaultTimeMidpointRounding)
        => TimeRounder.NearestMillisecond(input, midpointRounding);

    public static TimeSpan NearestMicrosecond(this TimeSpan input, MidpointRounding midpointRounding = TimeRounder.DefaultTimeMidpointRounding)
        => TimeRounder.NearestMicrosecond(input, midpointRounding);

    public static TimeSpan? NearestMicrosecond(this TimeSpan? input, MidpointRounding midpointRounding = TimeRounder.DefaultTimeMidpointRounding)
        => TimeRounder.NearestMicrosecond(input, midpointRounding);
}
