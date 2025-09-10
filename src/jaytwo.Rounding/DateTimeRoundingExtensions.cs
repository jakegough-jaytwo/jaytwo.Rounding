namespace jaytwo.Rounding;

public static class DateTimeRoundingExtensions
{
    public static DateTime FloorDays(this DateTime input)
        => DateTimeRounder.FloorDays(input);

    public static DateTime? FloorDays(this DateTime? input)
        => DateTimeRounder.FloorDays(input);

    public static DateTime CeilingDays(this DateTime input)
        => DateTimeRounder.CeilingDays(input);

    public static DateTime? CeilingDays(this DateTime? input)
        => DateTimeRounder.CeilingDays(input);

    public static DateTime TruncateDays(this DateTime input)
        => DateTimeRounder.TruncateDays(input);

    public static DateTime? TruncateDays(this DateTime? input)
        => DateTimeRounder.TruncateDays(input);

    public static DateTime FloorHours(this DateTime input)
        => DateTimeRounder.FloorHours(input);

    public static DateTime? FloorHours(this DateTime? input)
        => DateTimeRounder.FloorHours(input);

    public static DateTime CeilingHours(this DateTime input)
        => DateTimeRounder.CeilingHours(input);

    public static DateTime? CeilingHours(this DateTime? input)
        => DateTimeRounder.CeilingHours(input);

    public static DateTime TruncateHours(this DateTime input)
        => DateTimeRounder.TruncateHours(input);

    public static DateTime? TruncateHours(this DateTime? input)
        => DateTimeRounder.TruncateHours(input);

    public static DateTime FloorMinutes(this DateTime input)
        => DateTimeRounder.FloorMinutes(input);

    public static DateTime? FloorMinutes(this DateTime? input)
        => DateTimeRounder.FloorMinutes(input);

    public static DateTime CeilingMinutes(this DateTime input)
        => DateTimeRounder.CeilingMinutes(input);

    public static DateTime? CeilingMinutes(this DateTime? input)
        => DateTimeRounder.CeilingMinutes(input);

    public static DateTime TruncateMinutes(this DateTime input)
        => DateTimeRounder.TruncateMinutes(input);

    public static DateTime? TruncateMinutes(this DateTime? input)
        => DateTimeRounder.TruncateMinutes(input);

    public static DateTime FloorSeconds(this DateTime input)
        => DateTimeRounder.FloorSeconds(input);

    public static DateTime? FloorSeconds(this DateTime? input)
        => DateTimeRounder.FloorSeconds(input);

    public static DateTime CeilingSeconds(this DateTime input)
        => DateTimeRounder.CeilingSeconds(input);

    public static DateTime? CeilingSeconds(this DateTime? input)
        => DateTimeRounder.CeilingSeconds(input);

    public static DateTime TruncateSeconds(this DateTime input)
        => DateTimeRounder.TruncateSeconds(input);

    public static DateTime? TruncateSeconds(this DateTime? input)
        => DateTimeRounder.TruncateSeconds(input);

    public static DateTime FloorMilliseconds(this DateTime input)
        => DateTimeRounder.FloorMilliseconds(input);

    public static DateTime? FloorMilliseconds(this DateTime? input)
        => DateTimeRounder.FloorMilliseconds(input);

    public static DateTime CeilingMilliseconds(this DateTime input)
        => DateTimeRounder.CeilingMilliseconds(input);

    public static DateTime? CeilingMilliseconds(this DateTime? input)
        => DateTimeRounder.CeilingMilliseconds(input);

    public static DateTime TruncateMilliseconds(this DateTime input)
        => DateTimeRounder.TruncateMilliseconds(input);

    public static DateTime? TruncateMilliseconds(this DateTime? input)
        => DateTimeRounder.TruncateMilliseconds(input);

    public static DateTime TruncateMicroseconds(this DateTime input)
        => DateTimeRounder.TruncateMicroseconds(input);

    public static DateTime? TruncateMicroseconds(this DateTime? input)
        => DateTimeRounder.TruncateMicroseconds(input);

    public static DateTime NearestSecond(this DateTime input, MidpointRounding midpointRounding = DateTimeRounder.DefaultDateMidpointRounding)
        => DateTimeRounder.NearestSecond(input, midpointRounding);

    public static DateTime? NearestSecond(this DateTime? input, MidpointRounding midpointRounding = DateTimeRounder.DefaultDateMidpointRounding)
        => DateTimeRounder.NearestSecond(input, midpointRounding);

    public static DateTime NearestMillisecond(this DateTime input, MidpointRounding midpointRounding = DateTimeRounder.DefaultDateMidpointRounding)
        => DateTimeRounder.NearestMillisecond(input, midpointRounding);

    public static DateTime? NearestMillisecond(this DateTime? input, MidpointRounding midpointRounding = DateTimeRounder.DefaultDateMidpointRounding)
        => DateTimeRounder.NearestMillisecond(input, midpointRounding);

    public static DateTime NearestMicrosecond(this DateTime input, MidpointRounding midpointRounding = DateTimeRounder.DefaultDateMidpointRounding)
        => DateTimeRounder.NearestMicrosecond(input, midpointRounding);

    public static DateTime? NearestMicrosecond(this DateTime? input, MidpointRounding midpointRounding = DateTimeRounder.DefaultDateMidpointRounding)
        => DateTimeRounder.NearestMicrosecond(input, midpointRounding);
}
