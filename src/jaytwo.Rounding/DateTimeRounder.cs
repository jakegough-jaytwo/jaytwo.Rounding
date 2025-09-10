namespace jaytwo.Rounding;

public class DateTimeRounder
{
    internal const MidpointRounding DefaultDateMidpointRounding = MidpointRounding.ToEven;

    public static DateTime? Round(DateTime? input, TimeSpanRounding precision, AbsoluteRounding mode)
        => input.HasValue ? Round(input.Value, precision, mode) : null;

    public static DateTime Round(DateTime input, TimeSpanRounding precision, AbsoluteRounding mode)
        => input.Date.Add(TimeSpanRounder.Round(input.TimeOfDay, precision, mode));

    public static DateTime? Round(DateTime? input, TimeSpanRounding precision, MidpointRounding mode)
        => input.HasValue ? Round(input.Value, precision, mode) : null;

    public static DateTime Round(DateTime input, TimeSpanRounding precision, MidpointRounding mode)
    {
        switch (precision)
        {
            case TimeSpanRounding.Microsecond:
            case TimeSpanRounding.Millisecond:
            case TimeSpanRounding.Second:
                return input.Date.Add(TimeSpanRounder.Round(input.TimeOfDay, precision, mode));

            case TimeSpanRounding.Minute:
            case TimeSpanRounding.Hour:
            case TimeSpanRounding.Day:
                throw new NotSupportedException(
                    $"Midpoint rounding for DateTime to {precision} precision is not supported. Use Floor/Ceiling/Truncate or round to second-or-finer precision.");

            default:
                throw new ArgumentOutOfRangeException(nameof(precision));
        }
    }

    public static DateTime? RoundDays(DateTime? input, AbsoluteRounding mode)
        => input.HasValue ? RoundDays(input.Value, mode) : null;

    public static DateTime RoundDays(DateTime input, AbsoluteRounding mode)
        => input.Date.Add(TimeSpanRounder.Round(input.TimeOfDay, TimeSpanRounding.Day, mode));

    public static DateTime? RoundHours(DateTime? input, AbsoluteRounding mode)
        => input.HasValue ? RoundHours(input.Value, mode) : null;

    public static DateTime RoundHours(DateTime input, AbsoluteRounding mode)
        => Round(input, TimeSpanRounding.Hour, mode);

    public static DateTime? RoundMinutes(DateTime? input, AbsoluteRounding mode)
        => input.HasValue ? RoundMinutes(input.Value, mode) : null;

    public static DateTime RoundMinutes(DateTime input, AbsoluteRounding mode)
        => Round(input, TimeSpanRounding.Minute, mode);

    public static DateTime? RoundSeconds(DateTime? input, AbsoluteRounding mode)
        => input.HasValue ? RoundSeconds(input.Value, mode) : null;

    public static DateTime RoundSeconds(DateTime input, AbsoluteRounding mode)
        => Round(input, TimeSpanRounding.Second, mode);

    public static DateTime? RoundMilliseconds(DateTime? input, AbsoluteRounding mode)
        => input.HasValue ? RoundMilliseconds(input.Value, mode) : null;

    public static DateTime RoundMilliseconds(DateTime input, AbsoluteRounding mode)
        => Round(input, TimeSpanRounding.Millisecond, mode);

    public static DateTime? RoundMicroseconds(DateTime? input, AbsoluteRounding mode)
        => input.HasValue ? RoundMicroseconds(input.Value, mode) : null;

    public static DateTime RoundMicroseconds(DateTime input, AbsoluteRounding mode)
        => Round(input, TimeSpanRounding.Microsecond, mode);

    public static DateTime? FloorDays(DateTime? input)
        => input.HasValue ? FloorDays(input.Value) : null;

    public static DateTime FloorDays(DateTime input)
        => RoundDays(input, AbsoluteRounding.Floor);

    public static DateTime? CeilingDays(DateTime? input)
        => input.HasValue ? CeilingDays(input.Value) : null;

    public static DateTime CeilingDays(DateTime input)
        => RoundDays(input, AbsoluteRounding.Ceiling);

    public static DateTime? TruncateDays(DateTime? input)
        => input.HasValue ? TruncateDays(input.Value) : null;

    public static DateTime TruncateDays(DateTime input)
        => RoundDays(input, AbsoluteRounding.Truncate);

    public static DateTime? FloorHours(DateTime? input)
        => input.HasValue ? FloorHours(input.Value) : null;

    public static DateTime FloorHours(DateTime input)
        => RoundHours(input, AbsoluteRounding.Floor);

    public static DateTime? CeilingHours(DateTime? input)
        => input.HasValue ? CeilingHours(input.Value) : null;

    public static DateTime CeilingHours(DateTime input)
        => RoundHours(input, AbsoluteRounding.Ceiling);

    public static DateTime? TruncateHours(DateTime? input)
        => input.HasValue ? TruncateHours(input.Value) : null;

    public static DateTime TruncateHours(DateTime input)
        => RoundHours(input, AbsoluteRounding.Truncate);

    public static DateTime? FloorMinutes(DateTime? input)
        => input.HasValue ? FloorMinutes(input.Value) : null;

    public static DateTime FloorMinutes(DateTime input)
        => RoundMinutes(input, AbsoluteRounding.Floor);

    public static DateTime? CeilingMinutes(DateTime? input)
        => input.HasValue ? CeilingMinutes(input.Value) : null;

    public static DateTime CeilingMinutes(DateTime input)
        => RoundMinutes(input, AbsoluteRounding.Ceiling);

    public static DateTime? TruncateMinutes(DateTime? input)
        => input.HasValue ? TruncateMinutes(input.Value) : null;

    public static DateTime TruncateMinutes(DateTime input)
        => RoundMinutes(input, AbsoluteRounding.Truncate);

    public static DateTime? FloorSeconds(DateTime? input)
        => input.HasValue ? FloorSeconds(input.Value) : null;

    public static DateTime FloorSeconds(DateTime input)
        => RoundSeconds(input, AbsoluteRounding.Floor);

    public static DateTime? CeilingSeconds(DateTime? input)
        => input.HasValue ? CeilingSeconds(input.Value) : null;

    public static DateTime CeilingSeconds(DateTime input)
        => RoundSeconds(input, AbsoluteRounding.Ceiling);

    public static DateTime? TruncateSeconds(DateTime? input)
        => input.HasValue ? TruncateSeconds(input.Value) : null;

    public static DateTime TruncateSeconds(DateTime input)
        => RoundSeconds(input, AbsoluteRounding.Truncate);

    public static DateTime? FloorMilliseconds(DateTime? input)
        => input.HasValue ? FloorMilliseconds(input.Value) : null;

    public static DateTime FloorMilliseconds(DateTime input)
        => RoundMilliseconds(input, AbsoluteRounding.Floor);

    public static DateTime? CeilingMilliseconds(DateTime? input)
        => input.HasValue ? CeilingMilliseconds(input.Value) : null;

    public static DateTime CeilingMilliseconds(DateTime input)
        => RoundMilliseconds(input, AbsoluteRounding.Ceiling);

    public static DateTime? TruncateMilliseconds(DateTime? input)
        => input.HasValue ? TruncateMilliseconds(input.Value) : null;

    public static DateTime TruncateMilliseconds(DateTime input)
        => RoundMilliseconds(input, AbsoluteRounding.Truncate);

    public static DateTime? FloorMicroseconds(DateTime? input)
        => input.HasValue ? FloorMicroseconds(input.Value) : null;

    public static DateTime FloorMicroseconds(DateTime input)
        => RoundMicroseconds(input, AbsoluteRounding.Floor);

    public static DateTime? CeilingMicroseconds(DateTime? input)
        => input.HasValue ? CeilingMicroseconds(input.Value) : null;

    public static DateTime CeilingMicroseconds(DateTime input)
        => RoundMicroseconds(input, AbsoluteRounding.Ceiling);

    public static DateTime? TruncateMicroseconds(DateTime? input)
        => input.HasValue ? TruncateMicroseconds(input.Value) : null;

    public static DateTime TruncateMicroseconds(DateTime input)
        => RoundMicroseconds(input, AbsoluteRounding.Truncate);

    public static DateTime? NearestSecond(DateTime? input, MidpointRounding midpointRounding = DefaultDateMidpointRounding)
        => input.HasValue ? NearestSecond(input.Value, midpointRounding) : null;

    public static DateTime NearestSecond(DateTime input, MidpointRounding midpointRounding = DefaultDateMidpointRounding)
        => Round(input, TimeSpanRounding.Second, midpointRounding);

    public static DateTime? NearestMillisecond(DateTime? input, MidpointRounding midpointRounding = DefaultDateMidpointRounding)
        => input.HasValue ? NearestMillisecond(input.Value, midpointRounding) : null;

    public static DateTime NearestMillisecond(DateTime input, MidpointRounding midpointRounding = DefaultDateMidpointRounding)
        => Round(input, TimeSpanRounding.Millisecond, midpointRounding);

    public static DateTime? NearestMicrosecond(DateTime? input, MidpointRounding midpointRounding = DefaultDateMidpointRounding)
        => input.HasValue ? NearestMicrosecond(input.Value, midpointRounding) : null;

    public static DateTime NearestMicrosecond(DateTime input, MidpointRounding midpointRounding = DefaultDateMidpointRounding)
        => Round(input, TimeSpanRounding.Microsecond, midpointRounding);
}
