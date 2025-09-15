using System;

namespace jaytwo.Rounding;

internal static class TimeSpanDecimal
{
    private const long TicksPerMicrosecond = 10L; // 1 μs = 10 ticks (1 tick = 100 ns)

    // Decimal constants to keep everything in base-10 math (no double!)
    private const decimal TicksPerMicrosecondDec = TicksPerMicrosecond;
    private const decimal TicksPerMillisecondDec = TimeSpan.TicksPerMillisecond;
    private const decimal TicksPerSecondDec = TimeSpan.TicksPerSecond;
    private const decimal TicksPerMinuteDec = TimeSpan.TicksPerMinute;
    private const decimal TicksPerHourDec = TimeSpan.TicksPerHour;
    private const decimal TicksPerDayDec = TimeSpan.TicksPerDay;

    public static TimeSpan TimeSpanFromMicrosecondsDecimal(decimal microseconds)
        => FromUnitDecimal(microseconds, TicksPerMicrosecondDec);

    public static TimeSpan TimeSpanFromMillisecondsDecimal(decimal milliseconds)
        => FromUnitDecimal(milliseconds, TicksPerMillisecondDec);

    public static TimeSpan TimeSpanFromSecondsDecimal(decimal seconds)
        => FromUnitDecimal(seconds, TicksPerSecondDec);

    public static TimeSpan TimeSpanFromMinutesDecimal(decimal minutes)
        => FromUnitDecimal(minutes, TicksPerMinuteDec);

    public static TimeSpan TimeSpanFromHoursDecimal(decimal hours)
        => FromUnitDecimal(hours, TicksPerHourDec);

    public static TimeSpan TimeSpanFromDaysDecimal(decimal days)
        => FromUnitDecimal(days, TicksPerDayDec);

    public static decimal GetTotalDaysDecimal(TimeSpan value)
        => value.Ticks / TicksPerDayDec;

    public static decimal GetTotalHoursDecimal(TimeSpan value)
        => value.Ticks / TicksPerHourDec;

    public static decimal GetTotalMinutesDecimal(TimeSpan value)
        => value.Ticks / TicksPerMinuteDec;

    public static decimal GetTotalSecondsDecimal(TimeSpan value)
        => value.Ticks / TicksPerSecondDec;

    public static decimal GetTotalMillisecondsDecimal(TimeSpan value)
        => value.Ticks / TicksPerMillisecondDec;

    public static decimal GetTotalMicrosecondsDecimal(TimeSpan value)
        => value.Ticks / TicksPerMicrosecondDec;

    // Core helper: value (in units) × ticksPerUnit → rounded ticks → TimeSpan
    private static TimeSpan FromUnitDecimal(decimal value, decimal ticksPerUnit)
    {
        // Multiply in decimal to keep exactness, then round to nearest tick (ties-to-even)
        decimal ticksDec = decimal.Round(value * ticksPerUnit, 0, MidpointRounding.ToEven);

        // Range check before converting to Int64/TimeSpan
        if (ticksDec > TimeSpan.MaxValue.Ticks || ticksDec < TimeSpan.MinValue.Ticks)
        {
            throw new OverflowException("The resulting TimeSpan is outside the valid range.");
        }

        long ticks = decimal.ToInt64(ticksDec); // exact conversion after rounding
        return new TimeSpan(ticks);
    }
}
