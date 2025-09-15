using System;

namespace jaytwo.Rounding;

public class TimeRounder
{
    internal const MidpointRounding DefaultTimeMidpointRounding = MidpointRounding.ToEven;

    private readonly TimePrecision _precision;
    private readonly MidpointRounding _mode;

    public TimeRounder(TimePrecision precision, MidpointRounding mode = DefaultTimeMidpointRounding)
    {
        _precision = precision;
        _mode = mode;
    }

    public static TimeSpan? Round(TimeSpan? input, TimePrecision precision, MidpointRounding mode = DefaultTimeMidpointRounding)
        => input.HasValue ? Round(input.Value, precision, mode) : null;

    public static TimeSpan Round(TimeSpan input, TimePrecision precision, MidpointRounding mode = DefaultTimeMidpointRounding)
        => precision switch
        {
            TimePrecision.Microsecond => NearestMicrosecond(input, mode),
            TimePrecision.Millisecond => NearestMillisecond(input, mode),
            TimePrecision.Second => NearestSecond(input, mode),
            TimePrecision.Minute => NearestMinute(input, mode),
            TimePrecision.Hour => NearestHour(input, mode),
            TimePrecision.Day => NearestDay(input, mode),
            _ => throw new ArgumentOutOfRangeException(nameof(mode)),
        };

    public static TimeSpan? NearestDay(TimeSpan? input, MidpointRounding midpointRounding = DefaultTimeMidpointRounding)
        => input.HasValue ? NearestDay(input.Value, midpointRounding) : null;

    public static TimeSpan NearestDay(TimeSpan input, MidpointRounding midpointRounding = DefaultTimeMidpointRounding)
        => TimeSpanDecimal.TimeSpanFromDaysDecimal(decimal.Round(TimeSpanDecimal.GetTotalDaysDecimal(input), 0, midpointRounding));

    public static TimeSpan? NearestHour(TimeSpan? input, MidpointRounding midpointRounding = DefaultTimeMidpointRounding)
        => input.HasValue ? NearestHour(input.Value, midpointRounding) : null;

    public static TimeSpan NearestHour(TimeSpan input, MidpointRounding midpointRounding = DefaultTimeMidpointRounding)
        => TimeSpanDecimal.TimeSpanFromHoursDecimal(decimal.Round(TimeSpanDecimal.GetTotalHoursDecimal(input), 0, midpointRounding));

    public static TimeSpan? NearestMinute(TimeSpan? input, MidpointRounding midpointRounding = DefaultTimeMidpointRounding)
        => input.HasValue ? NearestMinute(input.Value, midpointRounding) : null;

    public static TimeSpan NearestMinute(TimeSpan input, MidpointRounding midpointRounding = DefaultTimeMidpointRounding)
        => TimeSpanDecimal.TimeSpanFromMinutesDecimal(decimal.Round(TimeSpanDecimal.GetTotalMinutesDecimal(input), 0, midpointRounding));

    public static TimeSpan? NearestSecond(TimeSpan? input, MidpointRounding midpointRounding = DefaultTimeMidpointRounding)
        => input.HasValue ? NearestSecond(input.Value, midpointRounding) : null;

    public static TimeSpan NearestSecond(TimeSpan input, MidpointRounding midpointRounding = DefaultTimeMidpointRounding)
        => TimeSpanDecimal.TimeSpanFromSecondsDecimal(decimal.Round(TimeSpanDecimal.GetTotalSecondsDecimal(input), 0, midpointRounding));

    public static TimeSpan? NearestMillisecond(TimeSpan? input, MidpointRounding midpointRounding = DefaultTimeMidpointRounding)
        => input.HasValue ? NearestMillisecond(input.Value, midpointRounding) : null;

    public static TimeSpan NearestMillisecond(TimeSpan input, MidpointRounding midpointRounding = DefaultTimeMidpointRounding)
        => TimeSpanDecimal.TimeSpanFromMillisecondsDecimal(decimal.Round(TimeSpanDecimal.GetTotalMillisecondsDecimal(input), 0, midpointRounding));

    public static TimeSpan? NearestMicrosecond(TimeSpan? input, MidpointRounding midpointRounding = DefaultTimeMidpointRounding)
        => input.HasValue ? NearestMicrosecond(input.Value, midpointRounding) : null;

    public static TimeSpan NearestMicrosecond(TimeSpan input, MidpointRounding midpointRounding = DefaultTimeMidpointRounding)
        => TimeSpanDecimal.TimeSpanFromMicrosecondsDecimal(decimal.Round(TimeSpanDecimal.GetTotalMicrosecondsDecimal(input), 0, midpointRounding));

    public TimeSpan? Round(TimeSpan? input)
        => input.HasValue ? Round(input.Value) : null;

    public TimeSpan Round(TimeSpan input)
        => Round(input, _precision, _mode);
}
