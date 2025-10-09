using System;
using System.Globalization;

namespace jaytwo.Rounding;

public partial class TimeQuantizer
{
    public static DateTime? Quantize(DateTime? input, TimePrecision precision, QuantizationMode mode = DefaultQuantizationMode)
        => input.HasValue ? Quantize(input.Value, precision, mode) : null;

    public static DateTime Quantize(DateTime input, TimePrecision precision, QuantizationMode mode = DefaultQuantizationMode)
        => QuantizeDateTime(input, x => Quantize(x, precision, mode));

    public static DateTime? QuantizeDays(DateTime? input, QuantizationMode mode = DefaultQuantizationMode)
        => input.HasValue ? QuantizeDays(input.Value, mode) : null;

    public static DateTime QuantizeDays(DateTime input, QuantizationMode mode = DefaultQuantizationMode)
        => Quantize(input, TimePrecision.Day, mode);

    public static DateTime? QuantizeHours(DateTime? input, QuantizationMode mode = DefaultQuantizationMode)
        => input.HasValue ? QuantizeHours(input.Value, mode) : null;

    public static DateTime QuantizeHours(DateTime input, QuantizationMode mode = DefaultQuantizationMode)
        => Quantize(input, TimePrecision.Hour, mode);

    public static DateTime? QuantizeMinutes(DateTime? input, QuantizationMode mode = DefaultQuantizationMode)
        => input.HasValue ? QuantizeMinutes(input.Value, mode) : null;

    public static DateTime QuantizeMinutes(DateTime input, QuantizationMode mode = DefaultQuantizationMode)
        => Quantize(input, TimePrecision.Minute, mode);

    public static DateTime? QuantizeSeconds(DateTime? input, QuantizationMode mode = DefaultQuantizationMode)
        => input.HasValue ? QuantizeSeconds(input.Value, mode) : null;

    public static DateTime QuantizeSeconds(DateTime input, QuantizationMode mode = DefaultQuantizationMode)
        => Quantize(input, TimePrecision.Second, mode);

    public static DateTime? QuantizeMilliseconds(DateTime? input, QuantizationMode mode = DefaultQuantizationMode)
        => input.HasValue ? QuantizeMilliseconds(input.Value, mode) : null;

    public static DateTime QuantizeMilliseconds(DateTime input, QuantizationMode mode = DefaultQuantizationMode)
        => Quantize(input, TimePrecision.Millisecond, mode);

    public static DateTime? QuantizeMicroseconds(DateTime? input, QuantizationMode mode = DefaultQuantizationMode)
        => input.HasValue ? QuantizeMicroseconds(input.Value, mode) : null;

    public static DateTime QuantizeMicroseconds(DateTime input, QuantizationMode mode = DefaultQuantizationMode)
        => Quantize(input, TimePrecision.Microsecond, mode);

    public static DateTime? FloorDays(DateTime? input)
        => input.HasValue ? FloorDays(input.Value) : null;

    public static DateTime FloorDays(DateTime input)
        => QuantizeDays(input, QuantizationMode.Floor);

    public static DateTime? CeilingDays(DateTime? input)
        => input.HasValue ? CeilingDays(input.Value) : null;

    public static DateTime CeilingDays(DateTime input)
        => QuantizeDays(input, QuantizationMode.Ceiling);

    public static DateTime? TruncateDays(DateTime? input)
        => input.HasValue ? TruncateDays(input.Value) : null;

    public static DateTime TruncateDays(DateTime input)
        => QuantizeDays(input, QuantizationMode.Truncate);

    public static DateTime? FloorHours(DateTime? input)
        => input.HasValue ? FloorHours(input.Value) : null;

    public static DateTime FloorHours(DateTime input)
        => QuantizeHours(input, QuantizationMode.Floor);

    public static DateTime? CeilingHours(DateTime? input)
        => input.HasValue ? CeilingHours(input.Value) : null;

    public static DateTime CeilingHours(DateTime input)
        => QuantizeHours(input, QuantizationMode.Ceiling);

    public static DateTime? TruncateHours(DateTime? input)
        => input.HasValue ? TruncateHours(input.Value) : null;

    public static DateTime TruncateHours(DateTime input)
        => QuantizeHours(input, QuantizationMode.Truncate);

    public static DateTime? FloorMinutes(DateTime? input)
        => input.HasValue ? FloorMinutes(input.Value) : null;

    public static DateTime FloorMinutes(DateTime input)
        => QuantizeMinutes(input, QuantizationMode.Floor);

    public static DateTime? CeilingMinutes(DateTime? input)
        => input.HasValue ? CeilingMinutes(input.Value) : null;

    public static DateTime CeilingMinutes(DateTime input)
        => QuantizeMinutes(input, QuantizationMode.Ceiling);

    public static DateTime? TruncateMinutes(DateTime? input)
        => input.HasValue ? TruncateMinutes(input.Value) : null;

    public static DateTime TruncateMinutes(DateTime input)
        => QuantizeMinutes(input, QuantizationMode.Truncate);

    public static DateTime? FloorSeconds(DateTime? input)
        => input.HasValue ? FloorSeconds(input.Value) : null;

    public static DateTime FloorSeconds(DateTime input)
        => QuantizeSeconds(input, QuantizationMode.Floor);

    public static DateTime? CeilingSeconds(DateTime? input)
        => input.HasValue ? CeilingSeconds(input.Value) : null;

    public static DateTime CeilingSeconds(DateTime input)
        => QuantizeSeconds(input, QuantizationMode.Ceiling);

    public static DateTime? TruncateSeconds(DateTime? input)
        => input.HasValue ? TruncateSeconds(input.Value) : null;

    public static DateTime TruncateSeconds(DateTime input)
        => QuantizeSeconds(input, QuantizationMode.Truncate);

    public static DateTime? FloorMilliseconds(DateTime? input)
        => input.HasValue ? FloorMilliseconds(input.Value) : null;

    public static DateTime FloorMilliseconds(DateTime input)
        => QuantizeMilliseconds(input, QuantizationMode.Floor);

    public static DateTime? CeilingMilliseconds(DateTime? input)
        => input.HasValue ? CeilingMilliseconds(input.Value) : null;

    public static DateTime CeilingMilliseconds(DateTime input)
        => QuantizeMilliseconds(input, QuantizationMode.Ceiling);

    public static DateTime? TruncateMilliseconds(DateTime? input)
        => input.HasValue ? TruncateMilliseconds(input.Value) : null;

    public static DateTime TruncateMilliseconds(DateTime input)
        => QuantizeMilliseconds(input, QuantizationMode.Truncate);

    public static DateTime? FloorMicroseconds(DateTime? input)
        => input.HasValue ? FloorMicroseconds(input.Value) : null;

    public static DateTime FloorMicroseconds(DateTime input)
        => QuantizeMicroseconds(input, QuantizationMode.Floor);

    public static DateTime? CeilingMicroseconds(DateTime? input)
        => input.HasValue ? CeilingMicroseconds(input.Value) : null;

    public static DateTime CeilingMicroseconds(DateTime input)
        => QuantizeMicroseconds(input, QuantizationMode.Ceiling);

    public static DateTime? TruncateMicroseconds(DateTime? input)
        => input.HasValue ? TruncateMicroseconds(input.Value) : null;

    public static DateTime TruncateMicroseconds(DateTime input)
        => QuantizeMicroseconds(input, QuantizationMode.Truncate);

    public static DateTime StartOfWeek(DateTime input, DayOfWeek firstDayOfWeek)
        => input.Date.AddDays(-(7 + (input.DayOfWeek - firstDayOfWeek)) % 7);

    public static DateTime? StartOfWeek(DateTime? input, DayOfWeek firstDayOfWeek)
        => input.HasValue ? StartOfWeek(input.Value, firstDayOfWeek) : null;

    public static DateTime StartOfWeek(DateTime input, CultureInfo culture)
        => StartOfWeek(input, culture.DateTimeFormat.FirstDayOfWeek);

    public static DateTime? StartOfWeek(DateTime? input, CultureInfo culture)
        => input.HasValue ? StartOfWeek(input.Value, culture) : null;

#if NET5_0_OR_GREATER
    public static DateOnly StartOfWeek(DateOnly input, DayOfWeek firstDayOfWeek)
        => input.AddDays(-(7 + (input.DayOfWeek - firstDayOfWeek)) % 7);

    public static DateOnly? StartOfWeek(DateOnly? input, DayOfWeek firstDayOfWeek)
        => input.HasValue ? StartOfWeek(input.Value, firstDayOfWeek) : null;

    public static DateOnly StartOfWeek(DateOnly input, CultureInfo culture)
        => StartOfWeek(input, culture.DateTimeFormat.FirstDayOfWeek);

    public static DateOnly? StartOfWeek(DateOnly? input, CultureInfo culture)
        => input.HasValue ? StartOfWeek(input.Value, culture) : null;
#endif

    public DateTime? Quantize(DateTime? input)
        => input.HasValue ? Quantize(input.Value) : null;

    public DateTime Quantize(DateTime input)
        => QuantizeDateTime(input, x => Quantize(x));

    public DateTime StartOfWeek(DateTime input)
        => StartOfWeek(input, _firstDayOfWeek);

    public DateTime? StartOfWeek(DateTime? input)
        => input.HasValue ? StartOfWeek(input.Value) : null;

#if NET5_0_OR_GREATER
    public DateOnly StartOfWeek(DateOnly input)
        => StartOfWeek(input, _firstDayOfWeek);

    public DateOnly? StartOfWeek(DateOnly? input)
        => input.HasValue ? StartOfWeek(input.Value) : null;
#endif

    private static DateTime QuantizeDateTime(DateTime input, Func<TimeSpan, TimeSpan> quantizeMethod)
    {
        var asTimeSpan = new TimeSpan(input.Ticks - DateTime.MinValue.Ticks);
        var quantized = quantizeMethod(asTimeSpan);
        var result = new DateTime(quantized.Ticks, input.Kind);
        return result;
    }
}
