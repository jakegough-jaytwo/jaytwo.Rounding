using Xunit;

namespace jaytwo.Rounding.Tests.TimeQuantizerTests.TimeSpanTests;

public class TimeSpanQuantizeTests
{
    public static TheoryData<double, double> CeilingCases
        => new()
        {
            { 1.5,  2.0 },
            { 1.0,  1.0 },
            { -1.5, -1.0 },
        };

    public static TheoryData<double, double> FloorCases
        => new()
        {
            { 1.5,  1.0 },
            { 1.0,  1.0 },
            { -1.5, -2.0 },
        };

    public static TheoryData<double, double> TruncateCases
        => new()
        {
            { 1.5,  1.0 },
            { 1.0,  1.0 },
            { -1.5, -1.0 },
        };

    internal static TimeSpan? TimeSpanFromDays(double? value) => value.HasValue ? TimeSpan.FromDays(value.Value) : null;

    internal static TimeSpan? TimeSpanFromHours(double? value) => value.HasValue ? TimeSpan.FromHours(value.Value) : null;

    internal static TimeSpan? TimeSpanFromMinutes(double? value) => value.HasValue ? TimeSpan.FromMinutes(value.Value) : null;

    internal static TimeSpan? TimeSpanFromSeconds(double? value) => value.HasValue ? TimeSpan.FromSeconds(value.Value) : null;

    internal static TimeSpan? TimeSpanFromMilliseconds(double? value) => value.HasValue ? TimeSpan.FromMilliseconds(value.Value) : null;

    internal static TimeSpan? TimeSpanFromMicroseconds(double? value) => value.HasValue ? TimeSpan.FromMicroseconds(value.Value) : null;
}
