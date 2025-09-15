using System;

namespace jaytwo.Rounding;

public partial class TimeQuantizer
{
    public static TimeSpan? Quantize(TimeSpan? input, TimePrecision precision, QuantizationMode mode = DefaultQuantizationMode)
        => input.HasValue ? Quantize(input.Value, precision, mode) : null;

    public static TimeSpan Quantize(TimeSpan input, TimePrecision precision, QuantizationMode mode = DefaultQuantizationMode)
        => precision switch
        {
            TimePrecision.Microsecond => QuantizeMicroseconds(input, mode),
            TimePrecision.Millisecond => QuantizeMilliseconds(input, mode),
            TimePrecision.Second => QuantizeSeconds(input, mode),
            TimePrecision.Minute => QuantizeMinutes(input, mode),
            TimePrecision.Hour => QuantizeHours(input, mode),
            TimePrecision.Day => QuantizeDays(input, mode),
            _ => throw new ArgumentOutOfRangeException(nameof(mode)),
        };

    public static TimeSpan? QuantizeDays(TimeSpan? input, QuantizationMode mode = DefaultQuantizationMode)
        => input.HasValue ? QuantizeDays(input.Value, mode) : null;

    public static TimeSpan QuantizeDays(TimeSpan input, QuantizationMode mode = DefaultQuantizationMode)
        => mode switch
        {
            QuantizationMode.Ceiling => CeilingDays(input),
            QuantizationMode.Floor => FloorDays(input),
            QuantizationMode.Truncate => TruncateDays(input),
            _ => throw new ArgumentOutOfRangeException(nameof(mode)),
        };

    public static TimeSpan? QuantizeHours(TimeSpan? input, QuantizationMode mode = DefaultQuantizationMode)
        => input.HasValue ? QuantizeHours(input.Value, mode) : null;

    public static TimeSpan QuantizeHours(TimeSpan input, QuantizationMode mode = DefaultQuantizationMode)
        => mode switch
        {
            QuantizationMode.Ceiling => CeilingHours(input),
            QuantizationMode.Floor => FloorHours(input),
            QuantizationMode.Truncate => TruncateHours(input),
            _ => throw new ArgumentOutOfRangeException(nameof(mode)),
        };

    public static TimeSpan? QuantizeMinutes(TimeSpan? input, QuantizationMode mode = DefaultQuantizationMode)
        => input.HasValue ? QuantizeMinutes(input.Value, mode) : null;

    public static TimeSpan QuantizeMinutes(TimeSpan input, QuantizationMode mode = DefaultQuantizationMode)
        => mode switch
        {
            QuantizationMode.Ceiling => CeilingMinutes(input),
            QuantizationMode.Floor => FloorMinutes(input),
            QuantizationMode.Truncate => TruncateMinutes(input),
            _ => throw new ArgumentOutOfRangeException(nameof(mode)),
        };

    public static TimeSpan? QuantizeSeconds(TimeSpan? input, QuantizationMode mode = DefaultQuantizationMode)
        => input.HasValue ? QuantizeSeconds(input.Value, mode) : null;

    public static TimeSpan QuantizeSeconds(TimeSpan input, QuantizationMode mode = DefaultQuantizationMode)
        => mode switch
        {
            QuantizationMode.Ceiling => CeilingSeconds(input),
            QuantizationMode.Floor => FloorSeconds(input),
            QuantizationMode.Truncate => TruncateSeconds(input),
            _ => throw new ArgumentOutOfRangeException(nameof(mode)),
        };

    public static TimeSpan? QuantizeMilliseconds(TimeSpan? input, QuantizationMode mode = DefaultQuantizationMode)
        => input.HasValue ? QuantizeMilliseconds(input.Value, mode) : null;

    public static TimeSpan QuantizeMilliseconds(TimeSpan input, QuantizationMode mode = DefaultQuantizationMode)
        => mode switch
        {
            QuantizationMode.Ceiling => CeilingMilliseconds(input),
            QuantizationMode.Floor => FloorMilliseconds(input),
            QuantizationMode.Truncate => TruncateMilliseconds(input),
            _ => throw new ArgumentOutOfRangeException(nameof(mode)),
        };

    public static TimeSpan? QuantizeMicroseconds(TimeSpan? input, QuantizationMode mode = DefaultQuantizationMode)
        => input.HasValue ? QuantizeMicroseconds(input.Value, mode) : null;

    public static TimeSpan QuantizeMicroseconds(TimeSpan input, QuantizationMode mode = DefaultQuantizationMode)
        => mode switch
        {
            QuantizationMode.Ceiling => CeilingMicroseconds(input),
            QuantizationMode.Floor => FloorMicroseconds(input),
            QuantizationMode.Truncate => TruncateMicroseconds(input),
            _ => throw new ArgumentOutOfRangeException(nameof(mode)),
        };

    public static TimeSpan? FloorDays(TimeSpan? input)
        => input.HasValue ? FloorDays(input.Value) : null;

    public static TimeSpan FloorDays(TimeSpan input)
        => TimeSpanDecimal.TimeSpanFromDaysDecimal(decimal.Floor(TimeSpanDecimal.GetTotalDaysDecimal(input)));

    public static TimeSpan? CeilingDays(TimeSpan? input)
        => input.HasValue ? CeilingDays(input.Value) : null;

    public static TimeSpan CeilingDays(TimeSpan input)
        => TimeSpanDecimal.TimeSpanFromDaysDecimal(decimal.Ceiling(TimeSpanDecimal.GetTotalDaysDecimal(input)));

    public static TimeSpan? TruncateDays(TimeSpan? input)
        => input.HasValue ? TruncateDays(input.Value) : null;

    public static TimeSpan TruncateDays(TimeSpan input)
        => TimeSpanDecimal.TimeSpanFromDaysDecimal(decimal.Truncate(TimeSpanDecimal.GetTotalDaysDecimal(input)));

    public static TimeSpan? FloorHours(TimeSpan? input)
        => input.HasValue ? FloorHours(input.Value) : null;

    public static TimeSpan FloorHours(TimeSpan input)
        => TimeSpanDecimal.TimeSpanFromHoursDecimal(decimal.Floor(TimeSpanDecimal.GetTotalHoursDecimal(input)));

    public static TimeSpan? CeilingHours(TimeSpan? input)
        => input.HasValue ? CeilingHours(input.Value) : null;

    public static TimeSpan CeilingHours(TimeSpan input)
        => TimeSpanDecimal.TimeSpanFromHoursDecimal(decimal.Ceiling(TimeSpanDecimal.GetTotalHoursDecimal(input)));

    public static TimeSpan? TruncateHours(TimeSpan? input)
        => input.HasValue ? TruncateHours(input.Value) : null;

    public static TimeSpan TruncateHours(TimeSpan input)
        => TimeSpanDecimal.TimeSpanFromHoursDecimal(decimal.Truncate(TimeSpanDecimal.GetTotalHoursDecimal(input)));

    public static TimeSpan? FloorMinutes(TimeSpan? input)
        => input.HasValue ? FloorMinutes(input.Value) : null;

    public static TimeSpan FloorMinutes(TimeSpan input)
        => TimeSpanDecimal.TimeSpanFromMinutesDecimal(decimal.Floor(TimeSpanDecimal.GetTotalMinutesDecimal(input)));

    public static TimeSpan? CeilingMinutes(TimeSpan? input)
        => input.HasValue ? CeilingMinutes(input.Value) : null;

    public static TimeSpan CeilingMinutes(TimeSpan input)
        => TimeSpanDecimal.TimeSpanFromMinutesDecimal(decimal.Ceiling(TimeSpanDecimal.GetTotalMinutesDecimal(input)));

    public static TimeSpan? TruncateMinutes(TimeSpan? input)
        => input.HasValue ? TruncateMinutes(input.Value) : null;

    public static TimeSpan TruncateMinutes(TimeSpan input)
        => TimeSpanDecimal.TimeSpanFromMinutesDecimal(decimal.Truncate(TimeSpanDecimal.GetTotalMinutesDecimal(input)));

    public static TimeSpan? FloorSeconds(TimeSpan? input)
        => input.HasValue ? FloorSeconds(input.Value) : null;

    public static TimeSpan FloorSeconds(TimeSpan input)
        => TimeSpanDecimal.TimeSpanFromSecondsDecimal(decimal.Floor(TimeSpanDecimal.GetTotalSecondsDecimal(input)));

    public static TimeSpan? CeilingSeconds(TimeSpan? input)
        => input.HasValue ? CeilingSeconds(input.Value) : null;

    public static TimeSpan CeilingSeconds(TimeSpan input)
        => TimeSpanDecimal.TimeSpanFromSecondsDecimal(decimal.Ceiling(TimeSpanDecimal.GetTotalSecondsDecimal(input)));

    public static TimeSpan? TruncateSeconds(TimeSpan? input)
        => input.HasValue ? TruncateSeconds(input.Value) : null;

    public static TimeSpan TruncateSeconds(TimeSpan input)
        => TimeSpanDecimal.TimeSpanFromSecondsDecimal(decimal.Truncate(TimeSpanDecimal.GetTotalSecondsDecimal(input)));

    public static TimeSpan? FloorMilliseconds(TimeSpan? input)
        => input.HasValue ? FloorMilliseconds(input.Value) : null;

    public static TimeSpan FloorMilliseconds(TimeSpan input)
        => TimeSpanDecimal.TimeSpanFromMillisecondsDecimal(decimal.Floor(TimeSpanDecimal.GetTotalMillisecondsDecimal(input)));

    public static TimeSpan? CeilingMilliseconds(TimeSpan? input)
        => input.HasValue ? CeilingMilliseconds(input.Value) : null;

    public static TimeSpan CeilingMilliseconds(TimeSpan input)
        => TimeSpanDecimal.TimeSpanFromMillisecondsDecimal(decimal.Ceiling(TimeSpanDecimal.GetTotalMillisecondsDecimal(input)));

    public static TimeSpan? TruncateMilliseconds(TimeSpan? input)
        => input.HasValue ? TruncateMilliseconds(input.Value) : null;

    public static TimeSpan TruncateMilliseconds(TimeSpan input)
        => TimeSpanDecimal.TimeSpanFromMillisecondsDecimal(decimal.Truncate(TimeSpanDecimal.GetTotalMillisecondsDecimal(input)));

    public static TimeSpan? FloorMicroseconds(TimeSpan? input)
        => input.HasValue ? FloorMicroseconds(input.Value) : null;

    public static TimeSpan FloorMicroseconds(TimeSpan input)
        => TimeSpanDecimal.TimeSpanFromMicrosecondsDecimal(decimal.Floor(TimeSpanDecimal.GetTotalMicrosecondsDecimal(input)));

    public static TimeSpan? CeilingMicroseconds(TimeSpan? input)
        => input.HasValue ? CeilingMicroseconds(input.Value) : null;

    public static TimeSpan CeilingMicroseconds(TimeSpan input)
        => TimeSpanDecimal.TimeSpanFromMicrosecondsDecimal(decimal.Ceiling(TimeSpanDecimal.GetTotalMicrosecondsDecimal(input)));

    public static TimeSpan? TruncateMicroseconds(TimeSpan? input)
        => input.HasValue ? TruncateMicroseconds(input.Value) : null;

    public static TimeSpan TruncateMicroseconds(TimeSpan input)
        => TimeSpanDecimal.TimeSpanFromMicrosecondsDecimal(decimal.Truncate(TimeSpanDecimal.GetTotalMicrosecondsDecimal(input)));

    public TimeSpan? Quantize(TimeSpan? input)
        => input.HasValue ? Quantize(input.Value) : null;

    public TimeSpan Quantize(TimeSpan input)
        => Quantize(input, _precision, _mode);
}
