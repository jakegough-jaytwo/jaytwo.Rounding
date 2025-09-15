using System;

namespace jaytwo.Rounding;

public static partial class TimeQuantizingExtensions
{
    public static TimeSpan FloorDays(this TimeSpan input)
        => TimeQuantizer.FloorDays(input);

    public static TimeSpan? FloorDays(this TimeSpan? input)
        => TimeQuantizer.FloorDays(input);

    public static TimeSpan CeilingDays(this TimeSpan input)
        => TimeQuantizer.CeilingDays(input);

    public static TimeSpan? CeilingDays(this TimeSpan? input)
        => TimeQuantizer.CeilingDays(input);

    public static TimeSpan TruncateDays(this TimeSpan input)
        => TimeQuantizer.TruncateDays(input);

    public static TimeSpan? TruncateDays(this TimeSpan? input)
        => TimeQuantizer.TruncateDays(input);

    public static TimeSpan FloorHours(this TimeSpan input)
        => TimeQuantizer.FloorHours(input);

    public static TimeSpan? FloorHours(this TimeSpan? input)
        => TimeQuantizer.FloorHours(input);

    public static TimeSpan? CeilingHours(this TimeSpan? input)
        => TimeQuantizer.CeilingHours(input);

    public static TimeSpan CeilingHours(this TimeSpan input)
        => TimeQuantizer.CeilingHours(input);

    public static TimeSpan? TruncateHours(this TimeSpan? input)
        => TimeQuantizer.TruncateHours(input);

    public static TimeSpan TruncateHours(this TimeSpan input)
        => TimeQuantizer.TruncateHours(input);

    public static TimeSpan? FloorMinutes(this TimeSpan? input)
        => TimeQuantizer.FloorMinutes(input);

    public static TimeSpan FloorMinutes(this TimeSpan input)
        => TimeQuantizer.FloorMinutes(input);

    public static TimeSpan? CeilingMinutes(this TimeSpan? input)
        => TimeQuantizer.CeilingMinutes(input);

    public static TimeSpan CeilingMinutes(this TimeSpan input)
        => TimeQuantizer.CeilingMinutes(input);

    public static TimeSpan TruncateMinutes(this TimeSpan input)
        => TimeQuantizer.TruncateMinutes(input);

    public static TimeSpan? TruncateMinutes(this TimeSpan? input)
        => TimeQuantizer.TruncateMinutes(input);

    public static TimeSpan? FloorSeconds(this TimeSpan? input)
        => TimeQuantizer.FloorSeconds(input);

    public static TimeSpan FloorSeconds(this TimeSpan input)
        => TimeQuantizer.FloorSeconds(input);

    public static TimeSpan? CeilingSeconds(this TimeSpan? input)
        => TimeQuantizer.CeilingSeconds(input);

    public static TimeSpan CeilingSeconds(this TimeSpan input)
        => TimeQuantizer.CeilingSeconds(input);

    public static TimeSpan? TruncateSeconds(this TimeSpan? input)
        => TimeQuantizer.TruncateSeconds(input);

    public static TimeSpan TruncateSeconds(this TimeSpan input)
        => TimeQuantizer.TruncateSeconds(input);

    public static TimeSpan? FloorMicroseconds(this TimeSpan? input)
        => TimeQuantizer.FloorMicroseconds(input);

    public static TimeSpan FloorMicroseconds(this TimeSpan input)
        => TimeQuantizer.FloorMicroseconds(input);

    public static TimeSpan? FloorMilliseconds(this TimeSpan? input)
        => TimeQuantizer.FloorMilliseconds(input);

    public static TimeSpan FloorMilliseconds(this TimeSpan input)
        => TimeQuantizer.FloorMilliseconds(input);

    public static TimeSpan CeilingMicroseconds(this TimeSpan input)
        => TimeQuantizer.CeilingMicroseconds(input);

    public static TimeSpan? CeilingMicroseconds(this TimeSpan? input)
        => TimeQuantizer.CeilingMicroseconds(input);

    public static TimeSpan? CeilingMilliseconds(this TimeSpan? input)
        => TimeQuantizer.CeilingMilliseconds(input);

    public static TimeSpan CeilingMilliseconds(this TimeSpan input)
        => TimeQuantizer.CeilingMilliseconds(input);

    public static TimeSpan? TruncateMilliseconds(this TimeSpan? input)
        => TimeQuantizer.TruncateMilliseconds(input);

    public static TimeSpan TruncateMilliseconds(this TimeSpan input)
        => TimeQuantizer.TruncateMilliseconds(input);

    public static TimeSpan? TruncateMicroseconds(this TimeSpan? input)
        => TimeQuantizer.TruncateMicroseconds(input);

    public static TimeSpan TruncateMicroseconds(this TimeSpan input)
        => TimeQuantizer.TruncateMicroseconds(input);
}
