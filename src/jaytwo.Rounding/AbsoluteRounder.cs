namespace jaytwo.Rounding;

public class AbsoluteRounder
{
    public static double Round(double value, int digits, AbsoluteRounding mode)
        => mode switch
        {
            AbsoluteRounding.Ceiling => RoundCeiling(value, digits),
            AbsoluteRounding.Floor => RoundFloor(value, digits),
            AbsoluteRounding.Truncate => RoundTruncate(value, digits),
            _ => throw new ArgumentOutOfRangeException(nameof(value)),
        };

    public static double RoundCeiling(double value, int digits)
        => Math.Ceiling(value * Math.Pow(10, digits)) / Math.Pow(10, digits);

    public static double RoundFloor(double value, int digits)
        => Math.Floor(value * Math.Pow(10, digits)) / Math.Pow(10, digits);

    public static double RoundTruncate(double value, int digits)
        => Math.Truncate(value * Math.Pow(10, digits)) / Math.Pow(10, digits);

    public static decimal Round(decimal value, int digits, AbsoluteRounding mode)
        => mode switch
        {
            AbsoluteRounding.Ceiling => RoundCeiling(value, digits),
            AbsoluteRounding.Floor => RoundFloor(value, digits),
            AbsoluteRounding.Truncate => RoundTruncate(value, digits),
            _ => throw new ArgumentOutOfRangeException(nameof(value)),
        };

    public static decimal RoundCeiling(decimal value, int digits)
        => decimal.Ceiling(value * TenPower(digits)) / TenPower(digits);

    public static decimal RoundFloor(decimal value, int digits)
        => decimal.Floor(value * TenPower(digits)) / TenPower(digits);

    public static decimal RoundTruncate(decimal value, int digits)
        => decimal.Truncate(value * TenPower(digits)) / TenPower(digits);

    private static decimal TenPower(int digits)
        => (decimal)Math.Pow(10, digits);
}
