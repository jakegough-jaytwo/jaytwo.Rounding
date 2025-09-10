namespace jaytwo.Rounding;

public static class TimeSpanRoundingExtensions
{
    public static TimeSpan FloorDays(this TimeSpan input)
        => TimeSpanRounder.FloorDays(input);

    public static TimeSpan? FloorDays(this TimeSpan? input)
        => TimeSpanRounder.FloorDays(input);

    public static TimeSpan CeilingDays(this TimeSpan input)
        => TimeSpanRounder.CeilingDays(input);

    public static TimeSpan? CeilingDays(this TimeSpan? input)
        => TimeSpanRounder.CeilingDays(input);

    public static TimeSpan TruncateDays(this TimeSpan input)
        => TimeSpanRounder.TruncateDays(input);

    public static TimeSpan? TruncateDays(this TimeSpan? input)
        => TimeSpanRounder.TruncateDays(input);

    public static TimeSpan FloorHours(this TimeSpan input)
        => TimeSpanRounder.FloorHours(input);

    public static TimeSpan CeilingHours(this TimeSpan input)
        => TimeSpanRounder.CeilingHours(input);

    public static TimeSpan TruncateHours(this TimeSpan input)
        => TimeSpanRounder.TruncateHours(input);

    public static TimeSpan FloorMinutes(this TimeSpan input)
        => TimeSpanRounder.FloorMinutes(input);

    public static TimeSpan CeilingMinutes(this TimeSpan input)
        => TimeSpanRounder.CeilingMinutes(input);

    public static TimeSpan TruncateMinutes(this TimeSpan input)
        => TimeSpanRounder.TruncateMinutes(input);

    public static TimeSpan FloorSeconds(this TimeSpan input)
        => TimeSpanRounder.FloorSeconds(input);

    public static TimeSpan CeilingSeconds(this TimeSpan input)
        => TimeSpanRounder.CeilingSeconds(input);

    public static TimeSpan TruncateSeconds(this TimeSpan input)
        => TimeSpanRounder.TruncateSeconds(input);

    public static TimeSpan FloorMilliseconds(this TimeSpan input)
        => TimeSpanRounder.FloorMilliseconds(input);

    public static TimeSpan CeilingMilliseconds(this TimeSpan input)
        => TimeSpanRounder.CeilingMilliseconds(input);

    public static TimeSpan TruncateMilliseconds(this TimeSpan input)
        => TimeSpanRounder.TruncateMilliseconds(input);

    public static TimeSpan NearestDay(this TimeSpan input, MidpointRounding midpointRounding = TimeSpanRounder.DefaultTimeMidpointRounding)
        => TimeSpanRounder.NearestDay(input, midpointRounding);

    public static TimeSpan NearestHour(this TimeSpan input, MidpointRounding midpointRounding = TimeSpanRounder.DefaultTimeMidpointRounding)
        => TimeSpanRounder.NearestHour(input, midpointRounding);

    public static TimeSpan NearestMinute(this TimeSpan input, MidpointRounding midpointRounding = TimeSpanRounder.DefaultTimeMidpointRounding)
        => TimeSpanRounder.NearestMinute(input, midpointRounding);

    public static TimeSpan NearestSecond(this TimeSpan input, MidpointRounding midpointRounding = TimeSpanRounder.DefaultTimeMidpointRounding)
        => TimeSpanRounder.NearestSecond(input, midpointRounding);

    public static TimeSpan NearestMillisecond(this TimeSpan input, MidpointRounding midpointRounding = TimeSpanRounder.DefaultTimeMidpointRounding)
        => TimeSpanRounder.NearestMillisecond(input, midpointRounding);

    public static TimeSpan NearestMicrosecond(this TimeSpan input, MidpointRounding midpointRounding = TimeSpanRounder.DefaultTimeMidpointRounding)
        => TimeSpanRounder.NearestMicrosecond(input, midpointRounding);
}
