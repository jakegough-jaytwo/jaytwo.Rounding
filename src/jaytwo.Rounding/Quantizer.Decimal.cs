using System;

namespace jaytwo.Rounding;

public partial class Quantizer
{
    public static decimal? Quantize(decimal? value, int digits = DefaultQuantizationDigits, QuantizationMode mode = DefaultQuantizationMode)
        => value.HasValue ? Quantize(value.Value, digits, mode) : null;

    public static decimal Quantize(decimal value, int digits = DefaultQuantizationDigits, QuantizationMode mode = DefaultQuantizationMode)
        => mode switch
        {
            QuantizationMode.Ceiling => Ceiling(value, digits),
            QuantizationMode.Floor => Floor(value, digits),
            QuantizationMode.Truncate => Truncate(value, digits),
            _ => throw new ArgumentOutOfRangeException(nameof(mode)),
        };

    public static decimal? Ceiling(decimal? value, int digits = DefaultQuantizationDigits)
        => value.HasValue ? Ceiling(value.Value, digits) : null;

    public static decimal Ceiling(decimal value, int digits = DefaultQuantizationDigits)
        => decimal.Ceiling(value * TenPower(digits)) / TenPower(digits);

    public static decimal? Floor(decimal? value, int digits = DefaultQuantizationDigits)
        => value.HasValue ? Floor(value.Value, digits) : null;

    public static decimal Floor(decimal value, int digits = DefaultQuantizationDigits)
        => decimal.Floor(value * TenPower(digits)) / TenPower(digits);

    public static decimal? Truncate(decimal? value, int digits = DefaultQuantizationDigits)
        => value.HasValue ? Truncate(value.Value, digits) : null;

    public static decimal Truncate(decimal value, int digits = DefaultQuantizationDigits)
        => decimal.Truncate(value * TenPower(digits)) / TenPower(digits);

    public decimal? Quantize(decimal? value)
        => Quantize(value, _digits, _mode);

    public decimal Quantize(decimal value)
        => Quantize(value, _digits, _mode);

    internal static decimal TenPower(int digits)
    {
        // TODO: lookup table instead of loop is more efficient

        if (digits < -28 || digits > 28)
        {
            throw new ArgumentOutOfRangeException(nameof(digits), "digits must be in [-28, 28] for decimal.");
        }

        if (digits >= 0)
        {
            decimal v = 1m;
            for (int i = 0; i < digits; i++)
            {
                v *= 10m; // exact, <=28 multiplies
            }

            return v;
        }

        // negative powers: exact via decimal scale (1 × 10^-scale)
        return new decimal(1, 0, 0, false, (byte)(-digits));
    }
}
