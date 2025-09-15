using System;

namespace jaytwo.Rounding;

public partial class TimeQuantizer
{
    public static DateTimeOffset? Quantize(DateTimeOffset? input, TimePrecision precision, QuantizationMode mode = DefaultQuantizationMode)
        => input.HasValue ? Quantize(input.Value, precision, mode) : null;

    public static DateTimeOffset Quantize(DateTimeOffset input, TimePrecision precision, QuantizationMode mode = DefaultQuantizationMode)
        => QuantizeDateTimeOffset(input, x => Quantize(x, precision, mode));

    public static DateTimeOffset? QuantizeDays(DateTimeOffset? input, QuantizationMode mode = DefaultQuantizationMode)
        => input.HasValue ? QuantizeDays(input.Value, mode) : null;

    public static DateTimeOffset QuantizeDays(DateTimeOffset input, QuantizationMode mode = DefaultQuantizationMode)
        => Quantize(input, TimePrecision.Day, mode);

    public static DateTimeOffset? QuantizeHours(DateTimeOffset? input, QuantizationMode mode = DefaultQuantizationMode)
        => input.HasValue ? QuantizeHours(input.Value, mode) : null;

    public static DateTimeOffset QuantizeHours(DateTimeOffset input, QuantizationMode mode = DefaultQuantizationMode)
        => Quantize(input, TimePrecision.Hour, mode);

    public static DateTimeOffset? QuantizeMinutes(DateTimeOffset? input, QuantizationMode mode = DefaultQuantizationMode)
        => input.HasValue ? QuantizeMinutes(input.Value, mode) : null;

    public static DateTimeOffset QuantizeMinutes(DateTimeOffset input, QuantizationMode mode = DefaultQuantizationMode)
        => Quantize(input, TimePrecision.Minute, mode);

    public static DateTimeOffset? QuantizeSeconds(DateTimeOffset? input, QuantizationMode mode = DefaultQuantizationMode)
        => input.HasValue ? QuantizeSeconds(input.Value, mode) : null;

    public static DateTimeOffset QuantizeSeconds(DateTimeOffset input, QuantizationMode mode = DefaultQuantizationMode)
        => Quantize(input, TimePrecision.Second, mode);

    public static DateTimeOffset? QuantizeMilliseconds(DateTimeOffset? input, QuantizationMode mode = DefaultQuantizationMode)
        => input.HasValue ? QuantizeMilliseconds(input.Value, mode) : null;

    public static DateTimeOffset QuantizeMilliseconds(DateTimeOffset input, QuantizationMode mode = DefaultQuantizationMode)
        => Quantize(input, TimePrecision.Millisecond, mode);

    public static DateTimeOffset? QuantizeMicroseconds(DateTimeOffset? input, QuantizationMode mode = DefaultQuantizationMode)
        => input.HasValue ? QuantizeMicroseconds(input.Value, mode) : null;

    public static DateTimeOffset QuantizeMicroseconds(DateTimeOffset input, QuantizationMode mode = DefaultQuantizationMode)
        => Quantize(input, TimePrecision.Microsecond, mode);

    public static DateTimeOffset? FloorDays(DateTimeOffset? input)
        => input.HasValue ? FloorDays(input.Value) : null;

    public static DateTimeOffset FloorDays(DateTimeOffset input)
        => QuantizeDays(input, QuantizationMode.Floor);

    public static DateTimeOffset? CeilingDays(DateTimeOffset? input)
        => input.HasValue ? CeilingDays(input.Value) : null;

    public static DateTimeOffset CeilingDays(DateTimeOffset input)
        => QuantizeDays(input, QuantizationMode.Ceiling);

    public static DateTimeOffset? TruncateDays(DateTimeOffset? input)
        => input.HasValue ? TruncateDays(input.Value) : null;

    public static DateTimeOffset TruncateDays(DateTimeOffset input)
        => QuantizeDays(input, QuantizationMode.Truncate);

    public static DateTimeOffset? FloorHours(DateTimeOffset? input)
        => input.HasValue ? FloorHours(input.Value) : null;

    public static DateTimeOffset FloorHours(DateTimeOffset input)
        => QuantizeHours(input, QuantizationMode.Floor);

    public static DateTimeOffset? CeilingHours(DateTimeOffset? input)
        => input.HasValue ? CeilingHours(input.Value) : null;

    public static DateTimeOffset CeilingHours(DateTimeOffset input)
        => QuantizeHours(input, QuantizationMode.Ceiling);

    public static DateTimeOffset? TruncateHours(DateTimeOffset? input)
        => input.HasValue ? TruncateHours(input.Value) : null;

    public static DateTimeOffset TruncateHours(DateTimeOffset input)
        => QuantizeHours(input, QuantizationMode.Truncate);

    public static DateTimeOffset? FloorMinutes(DateTimeOffset? input)
        => input.HasValue ? FloorMinutes(input.Value) : null;

    public static DateTimeOffset FloorMinutes(DateTimeOffset input)
        => QuantizeMinutes(input, QuantizationMode.Floor);

    public static DateTimeOffset? CeilingMinutes(DateTimeOffset? input)
        => input.HasValue ? CeilingMinutes(input.Value) : null;

    public static DateTimeOffset CeilingMinutes(DateTimeOffset input)
        => QuantizeMinutes(input, QuantizationMode.Ceiling);

    public static DateTimeOffset? TruncateMinutes(DateTimeOffset? input)
        => input.HasValue ? TruncateMinutes(input.Value) : null;

    public static DateTimeOffset TruncateMinutes(DateTimeOffset input)
        => QuantizeMinutes(input, QuantizationMode.Truncate);

    public static DateTimeOffset? FloorSeconds(DateTimeOffset? input)
        => input.HasValue ? FloorSeconds(input.Value) : null;

    public static DateTimeOffset FloorSeconds(DateTimeOffset input)
        => QuantizeSeconds(input, QuantizationMode.Floor);

    public static DateTimeOffset? CeilingSeconds(DateTimeOffset? input)
        => input.HasValue ? CeilingSeconds(input.Value) : null;

    public static DateTimeOffset CeilingSeconds(DateTimeOffset input)
        => QuantizeSeconds(input, QuantizationMode.Ceiling);

    public static DateTimeOffset? TruncateSeconds(DateTimeOffset? input)
        => input.HasValue ? TruncateSeconds(input.Value) : null;

    public static DateTimeOffset TruncateSeconds(DateTimeOffset input)
        => QuantizeSeconds(input, QuantizationMode.Truncate);

    public static DateTimeOffset? FloorMilliseconds(DateTimeOffset? input)
        => input.HasValue ? FloorMilliseconds(input.Value) : null;

    public static DateTimeOffset FloorMilliseconds(DateTimeOffset input)
        => QuantizeMilliseconds(input, QuantizationMode.Floor);

    public static DateTimeOffset? CeilingMilliseconds(DateTimeOffset? input)
        => input.HasValue ? CeilingMilliseconds(input.Value) : null;

    public static DateTimeOffset CeilingMilliseconds(DateTimeOffset input)
        => QuantizeMilliseconds(input, QuantizationMode.Ceiling);

    public static DateTimeOffset? TruncateMilliseconds(DateTimeOffset? input)
        => input.HasValue ? TruncateMilliseconds(input.Value) : null;

    public static DateTimeOffset TruncateMilliseconds(DateTimeOffset input)
        => QuantizeMilliseconds(input, QuantizationMode.Truncate);

    public static DateTimeOffset? FloorMicroseconds(DateTimeOffset? input)
        => input.HasValue ? FloorMicroseconds(input.Value) : null;

    public static DateTimeOffset FloorMicroseconds(DateTimeOffset input)
        => QuantizeMicroseconds(input, QuantizationMode.Floor);

    public static DateTimeOffset? CeilingMicroseconds(DateTimeOffset? input)
        => input.HasValue ? CeilingMicroseconds(input.Value) : null;

    public static DateTimeOffset CeilingMicroseconds(DateTimeOffset input)
        => QuantizeMicroseconds(input, QuantizationMode.Ceiling);

    public static DateTimeOffset? TruncateMicroseconds(DateTimeOffset? input)
        => input.HasValue ? TruncateMicroseconds(input.Value) : null;

    public static DateTimeOffset TruncateMicroseconds(DateTimeOffset input)
        => QuantizeMicroseconds(input, QuantizationMode.Truncate);

    public DateTimeOffset? Quantize(DateTimeOffset? input)
        => input.HasValue ? Quantize(input.Value) : null;

    public DateTimeOffset Quantize(DateTimeOffset input)
        => QuantizeDateTimeOffset(input, x => Quantize(x));

    private static DateTimeOffset QuantizeDateTimeOffset(DateTimeOffset input, Func<TimeSpan, TimeSpan> quantizeMethod)
    {
        var quantized = QuantizeDateTime(input.DateTime, quantizeMethod);
        var result = new DateTimeOffset(quantized, input.Offset);
        return result;
    }
}
