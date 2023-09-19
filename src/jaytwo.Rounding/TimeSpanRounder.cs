namespace jaytwo.Rounding;

public class TimeSpanRounder
{
    public static TimeSpan Round(TimeSpan input, TimeSpanRounding precision, AbsoluteRounding mode)
        => precision switch
        {
            TimeSpanRounding.Microsecond => RoundMicroseconds(input, mode),
            TimeSpanRounding.Millisecond => RoundMilliseconds(input, mode),
            TimeSpanRounding.Second => RoundSeconds(input, mode),
            TimeSpanRounding.Minute => RoundMinutes(input, mode),
            TimeSpanRounding.Hour => RoundHours(input, mode),
            TimeSpanRounding.Day => RoundDays(input, mode),
            _ => throw new NotImplementedException(),
        };

    public static TimeSpan Round(TimeSpan input, TimeSpanRounding precision, MidpointRounding mode)
        => precision switch
        {
            TimeSpanRounding.Microsecond => NearestMicrosecond(input, mode),
            TimeSpanRounding.Millisecond => NearestMillisecond(input, mode),
            TimeSpanRounding.Second => NearestSecond(input, mode),
            TimeSpanRounding.Minute => NearestMinute(input, mode),
            TimeSpanRounding.Hour => NearestHour(input, mode),
            TimeSpanRounding.Day => NearestDay(input, mode),
            _ => throw new NotImplementedException(),
        };

    public static TimeSpan RoundDays(TimeSpan input, AbsoluteRounding mode)
        => mode switch
        {
            AbsoluteRounding.Ceiling => CeilingDays(input),
            AbsoluteRounding.Floor => FloorDays(input),
            AbsoluteRounding.Truncate => TruncateDays(input),
            _ => throw new NotImplementedException(),
        };

    public static TimeSpan RoundHours(TimeSpan input, AbsoluteRounding mode)
        => mode switch
        {
            AbsoluteRounding.Ceiling => CeilingHours(input),
            AbsoluteRounding.Floor => FloorHours(input),
            AbsoluteRounding.Truncate => TruncateHours(input),
            _ => throw new NotImplementedException(),
        };

    public static TimeSpan RoundMinutes(TimeSpan input, AbsoluteRounding mode)
        => mode switch
        {
            AbsoluteRounding.Ceiling => CeilingMinutes(input),
            AbsoluteRounding.Floor => FloorMinutes(input),
            AbsoluteRounding.Truncate => TruncateMinutes(input),
            _ => throw new NotImplementedException(),
        };

    public static TimeSpan RoundSeconds(TimeSpan input, AbsoluteRounding mode)
        => mode switch
        {
            AbsoluteRounding.Ceiling => CeilingSeconds(input),
            AbsoluteRounding.Floor => FloorSeconds(input),
            AbsoluteRounding.Truncate => TruncateSeconds(input),
            _ => throw new NotImplementedException(),
        };

    public static TimeSpan RoundMilliseconds(TimeSpan input, AbsoluteRounding mode)
        => mode switch
        {
            AbsoluteRounding.Ceiling => CeilingMilliseconds(input),
            AbsoluteRounding.Floor => FloorMilliseconds(input),
            AbsoluteRounding.Truncate => TruncateMilliseconds(input),
            _ => throw new NotImplementedException(),
        };

    public static TimeSpan RoundMicroseconds(TimeSpan input, AbsoluteRounding mode)
        => mode switch
        {
            AbsoluteRounding.Ceiling => CeilingMicroseconds(input),
            AbsoluteRounding.Floor => FloorMicroseconds(input),
            AbsoluteRounding.Truncate => TruncateMicroseconds(input),
            _ => throw new NotImplementedException(),
        };

    public static TimeSpan FloorDays(TimeSpan input)
        => TimeSpan.FromDays(Math.Floor(input.TotalDays));

    public static TimeSpan CeilingDays(TimeSpan input)
        => TimeSpan.FromDays(Math.Ceiling(input.TotalDays));

    public static TimeSpan TruncateDays(TimeSpan input)
        => TimeSpan.FromDays(Math.Truncate(input.TotalDays));

    public static TimeSpan FloorHours(TimeSpan input)
        => TimeSpan.FromHours(Math.Floor(input.TotalHours));

    public static TimeSpan CeilingHours(TimeSpan input)
        => TimeSpan.FromHours(Math.Ceiling(input.TotalHours));

    public static TimeSpan TruncateHours(TimeSpan input)
        => TimeSpan.FromHours(Math.Truncate(input.TotalHours));

    public static TimeSpan FloorMinutes(TimeSpan input)
        => TimeSpan.FromMinutes(Math.Floor(input.TotalMinutes));

    public static TimeSpan CeilingMinutes(TimeSpan input)
        => TimeSpan.FromMinutes(Math.Ceiling(input.TotalMinutes));

    public static TimeSpan TruncateMinutes(TimeSpan input)
        => TimeSpan.FromMinutes(Math.Truncate(input.TotalMinutes));

    public static TimeSpan FloorSeconds(TimeSpan input)
        => TimeSpan.FromSeconds(Math.Floor(input.TotalSeconds));

    public static TimeSpan CeilingSeconds(TimeSpan input)
        => TimeSpan.FromSeconds(Math.Ceiling(input.TotalSeconds));

    public static TimeSpan TruncateSeconds(TimeSpan input)
        => TimeSpan.FromSeconds(Math.Truncate(input.TotalSeconds));

    public static TimeSpan FloorMilliseconds(TimeSpan input)
        => TimeSpan.FromMilliseconds(Math.Floor(input.TotalMilliseconds));

    public static TimeSpan CeilingMilliseconds(TimeSpan input)
        => TimeSpan.FromMilliseconds(Math.Ceiling(input.TotalMilliseconds));

    public static TimeSpan TruncateMilliseconds(TimeSpan input)
        => TimeSpan.FromMilliseconds(Math.Truncate(input.TotalMilliseconds));

    public static TimeSpan FloorMicroseconds(TimeSpan input)
        => TimeSpan.FromMilliseconds(AbsoluteRounder.RoundFloor(input.TotalMilliseconds, 3));

    public static TimeSpan CeilingMicroseconds(TimeSpan input)
        => TimeSpan.FromMilliseconds(AbsoluteRounder.RoundCeiling(input.TotalMilliseconds, 3));

    public static TimeSpan TruncateMicroseconds(TimeSpan input)
        => TimeSpan.FromMilliseconds(AbsoluteRounder.RoundTruncate(input.TotalMilliseconds, 3));

    public static TimeSpan NearestDay(TimeSpan input, MidpointRounding midpointRounding = default)
        => TimeSpan.FromDays(Math.Round(input.TotalDays, 0, midpointRounding));

    public static TimeSpan NearestHour(TimeSpan input, MidpointRounding midpointRounding = default)
        => TimeSpan.FromHours(Math.Round(input.TotalHours, 0, midpointRounding));

    public static TimeSpan NearestMinute(TimeSpan input, MidpointRounding midpointRounding = default)
        => TimeSpan.FromMinutes(Math.Round(input.TotalMinutes, 0, midpointRounding));

    public static TimeSpan NearestSecond(TimeSpan input, MidpointRounding midpointRounding = default)
        => TimeSpan.FromSeconds(Math.Round(input.TotalSeconds, 0, midpointRounding));

    public static TimeSpan NearestMillisecond(TimeSpan input, MidpointRounding midpointRounding = default)
        => TimeSpan.FromMilliseconds(Math.Round(input.TotalMilliseconds, 0, midpointRounding));

    public static TimeSpan NearestMicrosecond(TimeSpan input, MidpointRounding midpointRounding = default)
        => TimeSpan.FromMilliseconds(Math.Round(input.TotalMilliseconds, 3, midpointRounding));
}
