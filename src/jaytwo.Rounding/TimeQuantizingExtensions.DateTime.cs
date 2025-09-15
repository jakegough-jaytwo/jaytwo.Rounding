using System;

namespace jaytwo.Rounding;

public static partial class TimeQuantizingExtensions
{
    public static DateTime FloorDays(this DateTime input)
        => TimeQuantizer.FloorDays(input);

    public static DateTime CeilingDays(this DateTime input)
        => TimeQuantizer.CeilingDays(input);

    public static DateTime TruncateDays(this DateTime input)
        => TimeQuantizer.TruncateDays(input);

    public static DateTime FloorHours(this DateTime input)
        => TimeQuantizer.FloorHours(input);

    public static DateTime CeilingHours(this DateTime input)
        => TimeQuantizer.CeilingHours(input);

    public static DateTime TruncateHours(this DateTime input)
        => TimeQuantizer.TruncateHours(input);

    public static DateTime FloorMinutes(this DateTime input)
        => TimeQuantizer.FloorMinutes(input);

    public static DateTime CeilingMinutes(this DateTime input)
        => TimeQuantizer.CeilingMinutes(input);

    public static DateTime TruncateMinutes(this DateTime input)
        => TimeQuantizer.TruncateMinutes(input);

    public static DateTime FloorSeconds(this DateTime input)
        => TimeQuantizer.FloorSeconds(input);

    public static DateTime CeilingSeconds(this DateTime input)
        => TimeQuantizer.CeilingSeconds(input);

    public static DateTime TruncateSeconds(this DateTime input)
        => TimeQuantizer.TruncateSeconds(input);

    public static DateTime FloorMilliseconds(this DateTime input)
        => TimeQuantizer.FloorMilliseconds(input);

    public static DateTime FloorMicroseconds(this DateTime input)
        => TimeQuantizer.FloorMicroseconds(input);

    public static DateTime CeilingMilliseconds(this DateTime input)
        => TimeQuantizer.CeilingMilliseconds(input);

    public static DateTime CeilingMicroseconds(this DateTime input)
        => TimeQuantizer.CeilingMicroseconds(input);

    public static DateTime TruncateMilliseconds(this DateTime input)
        => TimeQuantizer.TruncateMilliseconds(input);

    public static DateTime TruncateMicroseconds(this DateTime input)
        => TimeQuantizer.TruncateMicroseconds(input);
}
