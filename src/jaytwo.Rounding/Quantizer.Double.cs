using System;

namespace jaytwo.Rounding;

public partial class Quantizer
{
    public static double? Quantize(double? value, int digits = DefaultQuantizationDigits, QuantizationMode mode = DefaultQuantizationMode)
        => value.HasValue ? Quantize(value.Value, digits, mode) : null;

    public static double Quantize(double value, int digits = DefaultQuantizationDigits, QuantizationMode mode = DefaultQuantizationMode)
        => mode switch
        {
            QuantizationMode.Ceiling => Ceiling(value, digits),
            QuantizationMode.Floor => Floor(value, digits),
            QuantizationMode.Truncate => Truncate(value, digits),
            _ => throw new ArgumentOutOfRangeException(nameof(mode)),
        };

    public static double? Ceiling(double? value, int digits = DefaultQuantizationDigits)
        => value.HasValue ? Ceiling(value.Value, digits) : null;

    public static double Ceiling(double value, int digits = DefaultQuantizationDigits)
        => Math.Ceiling(value * Math.Pow(10, digits)) / Math.Pow(10, digits);

    public static double? Floor(double? value, int digits = DefaultQuantizationDigits)
        => value.HasValue ? Floor(value.Value, digits) : null;

    public static double Floor(double value, int digits = DefaultQuantizationDigits)
        => Math.Floor(value * Math.Pow(10, digits)) / Math.Pow(10, digits);

    public static double? Truncate(double? value, int digits = DefaultQuantizationDigits)
        => value.HasValue ? Truncate(value.Value, digits) : null;

    public static double Truncate(double value, int digits = DefaultQuantizationDigits)
        => Math.Truncate(value * Math.Pow(10, digits)) / Math.Pow(10, digits);

    public double? Quantize(double? value)
        => Quantize(value, _digits, _mode);

    public double Quantize(double value)
        => Quantize(value, _digits, _mode);
}
