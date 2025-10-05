using System;

namespace jaytwo.Rounding;

public partial class TimeQuantizer
{
    internal const QuantizationMode DefaultQuantizationMode = Quantizer.DefaultQuantizationMode;
    internal const DayOfWeek DefaultFirstDayOfWeek = DayOfWeek.Sunday;

    private readonly TimePrecision _precision;
    private readonly QuantizationMode _mode;
    private readonly DayOfWeek _firstDayOfWeek;

    public TimeQuantizer(
        TimePrecision precision,
        QuantizationMode mode = DefaultQuantizationMode,
        DayOfWeek firstDayOfWeek = DefaultFirstDayOfWeek)
    {
        _precision = precision;
        _mode = mode;
        _firstDayOfWeek = firstDayOfWeek;
    }
}
