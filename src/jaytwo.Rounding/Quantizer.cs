using System;

namespace jaytwo.Rounding;

public partial class Quantizer
{
    internal const int DefaultQuantizationDigits = 0;
    internal const QuantizationMode DefaultQuantizationMode = QuantizationMode.Truncate;

    private readonly QuantizationMode _mode;
    private readonly int _digits;

    public Quantizer(QuantizationMode mode = DefaultQuantizationMode, int digits = DefaultQuantizationDigits)
    {
        _mode = mode;
        _digits = digits;
    }
}
