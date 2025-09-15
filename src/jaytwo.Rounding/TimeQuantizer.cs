using System;

namespace jaytwo.Rounding;

public partial class TimeQuantizer
{
    internal const QuantizationMode DefaultQuantizationMode = Quantizer.DefaultQuantizationMode;

    private readonly TimePrecision _precision;
    private readonly QuantizationMode _mode;

    public TimeQuantizer(TimePrecision precision, QuantizationMode mode = DefaultQuantizationMode)
    {
        _precision = precision;
        _mode = mode;
    }
}
