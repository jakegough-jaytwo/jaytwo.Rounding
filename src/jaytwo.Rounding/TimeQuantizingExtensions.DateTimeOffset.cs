using System;

namespace jaytwo.Rounding;

public static partial class TimeQuantizingExtensions
{
    public static DateTimeOffset FloorDays(this DateTimeOffset input)
        => TimeQuantizer.FloorDays(input);

    public static DateTimeOffset CeilingDays(this DateTimeOffset input)
        => TimeQuantizer.CeilingDays(input);

    public static DateTimeOffset TruncateDays(this DateTimeOffset input)
        => TimeQuantizer.TruncateDays(input);

    public static DateTimeOffset FloorHours(this DateTimeOffset input)
        => TimeQuantizer.FloorHours(input);

    public static DateTimeOffset CeilingHours(this DateTimeOffset input)
        => TimeQuantizer.CeilingHours(input);

    public static DateTimeOffset TruncateHours(this DateTimeOffset input)
        => TimeQuantizer.TruncateHours(input);

    public static DateTimeOffset FloorMinutes(this DateTimeOffset input)
        => TimeQuantizer.FloorMinutes(input);

    public static DateTimeOffset CeilingMinutes(this DateTimeOffset input)
        => TimeQuantizer.CeilingMinutes(input);

    public static DateTimeOffset TruncateMinutes(this DateTimeOffset input)
        => TimeQuantizer.TruncateMinutes(input);

    public static DateTimeOffset FloorSeconds(this DateTimeOffset input)
        => TimeQuantizer.FloorSeconds(input);

    public static DateTimeOffset CeilingSeconds(this DateTimeOffset input)
        => TimeQuantizer.CeilingSeconds(input);

    public static DateTimeOffset TruncateSeconds(this DateTimeOffset input)
        => TimeQuantizer.TruncateSeconds(input);

    public static DateTimeOffset FloorMilliseconds(this DateTimeOffset input)
        => TimeQuantizer.FloorMilliseconds(input);

    public static DateTimeOffset FloorMicroseconds(this DateTimeOffset input)
        => TimeQuantizer.FloorMicroseconds(input);

    public static DateTimeOffset CeilingMilliseconds(this DateTimeOffset input)
        => TimeQuantizer.CeilingMilliseconds(input);

    public static DateTimeOffset CeilingMicroseconds(this DateTimeOffset input)
        => TimeQuantizer.CeilingMicroseconds(input);

    public static DateTimeOffset TruncateMilliseconds(this DateTimeOffset input)
        => TimeQuantizer.TruncateMilliseconds(input);

    public static DateTimeOffset TruncateMicroseconds(this DateTimeOffset input)
        => TimeQuantizer.TruncateMicroseconds(input);
}
