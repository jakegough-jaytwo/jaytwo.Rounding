using Xunit;

namespace jaytwo.Rounding.Tests.TimeQuantizerTests.TimeSpanTests;

public class TruncateTests : TimeSpanQuantizeTests
{
    [Theory]
    [MemberData(nameof(TruncateCases))]
    public void TruncateMicroseconds_Returns_Expected(double value, double expected)
        => TruncateMicrosecondsTest(value, expected, x => TimeQuantizer.TruncateMicroseconds(x));

    [Theory]
    [MemberData(nameof(TruncateCases))]
    public void Quantize_Microsecond_Truncate_Returns_Expected(double value, double expected)
        => TruncateMicrosecondsTest(value, expected, x => TimeQuantizer.Quantize(x, TimePrecision.Microsecond, QuantizationMode.Truncate));

    [Theory]
    [MemberData(nameof(TruncateCases))]
    public void Instance_Quantize_Microsecond_Truncate_Returns_Expected(double value, double expected)
        => TruncateMicrosecondsTest(value, expected, x => new TimeQuantizer(TimePrecision.Microsecond, QuantizationMode.Truncate).Quantize(x));

    [Theory]
    [MemberData(nameof(TruncateCases))]
    public void Extension_TruncateMicroseconds_Returns_Expected(double value, double expected)
        => TruncateMicrosecondsTest(value, expected, x => x.TruncateMicroseconds());

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TruncateCases))]
    public void Nullable_TruncateMicroseconds_Returns_Expected(double? value, double? expected)
        => Nullable_TruncateMicrosecondsTest(value, expected, x => TimeQuantizer.TruncateMicroseconds(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TruncateCases))]
    public void Nullable_Quantize_Microsecond_Truncate_Returns_Expected(double? value, double? expected)
        => Nullable_TruncateMicrosecondsTest(value, expected, x => TimeQuantizer.Quantize(x, TimePrecision.Microsecond, QuantizationMode.Truncate));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TruncateCases))]
    public void Nullable_Instance_Quantize_Microsecond_Truncate_Returns_Expected(double? value, double? expected)
        => Nullable_TruncateMicrosecondsTest(value, expected, x => new TimeQuantizer(TimePrecision.Microsecond, QuantizationMode.Truncate).Quantize(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TruncateCases))]
    public void Nullable_Extension_TruncateMicroseconds_Returns_Expected(double? value, double? expected)
        => Nullable_TruncateMicrosecondsTest(value, expected, x => x.TruncateMicroseconds());

    [Theory]
    [MemberData(nameof(TruncateCases))]
    public void TruncateMilliseconds_Returns_Expected(double value, double expected)
        => TruncateMillisecondsTest(value, expected, x => TimeQuantizer.TruncateMilliseconds(x));

    [Theory]
    [MemberData(nameof(TruncateCases))]
    public void Quantize_Millisecond_Truncate_Returns_Expected(double value, double expected)
        => TruncateMillisecondsTest(value, expected, x => TimeQuantizer.Quantize(x, TimePrecision.Millisecond, QuantizationMode.Truncate));

    [Theory]
    [MemberData(nameof(TruncateCases))]
    public void Instance_Quantize_Millisecond_Truncate_Returns_Expected(double value, double expected)
        => TruncateMillisecondsTest(value, expected, x => new TimeQuantizer(TimePrecision.Millisecond, QuantizationMode.Truncate).Quantize(x));

    [Theory]
    [MemberData(nameof(TruncateCases))]
    public void Extension_TruncateMilliseconds_Returns_Expected(double value, double expected)
        => TruncateMillisecondsTest(value, expected, x => x.TruncateMilliseconds());

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TruncateCases))]
    public void Nullable_TruncateMilliseconds_Returns_Expected(double? value, double? expected)
        => Nullable_TruncateMillisecondsTest(value, expected, x => TimeQuantizer.TruncateMilliseconds(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TruncateCases))]
    public void Nullable_Quantize_Millisecond_Truncate_Returns_Expected(double? value, double? expected)
        => Nullable_TruncateMillisecondsTest(value, expected, x => TimeQuantizer.Quantize(x, TimePrecision.Millisecond, QuantizationMode.Truncate));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TruncateCases))]
    public void Nullable_Instance_Quantize_Millisecond_Truncate_Returns_Expected(double? value, double? expected)
        => Nullable_TruncateMillisecondsTest(value, expected, x => new TimeQuantizer(TimePrecision.Millisecond, QuantizationMode.Truncate).Quantize(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TruncateCases))]
    public void Nullable_Extension_TruncateMilliseconds_Returns_Expected(double? value, double? expected)
        => Nullable_TruncateMillisecondsTest(value, expected, x => x.TruncateMilliseconds());

    [Theory]
    [MemberData(nameof(TruncateCases))]
    public void TruncateSeconds_Returns_Expected(double value, double expected)
        => TruncateSecondsTest(value, expected, x => TimeQuantizer.TruncateSeconds(x));

    [Theory]
    [MemberData(nameof(TruncateCases))]
    public void Quantize_Second_Truncate_Returns_Expected(double value, double expected)
        => TruncateSecondsTest(value, expected, x => TimeQuantizer.Quantize(x, TimePrecision.Second, QuantizationMode.Truncate));

    [Theory]
    [MemberData(nameof(TruncateCases))]
    public void Instance_Quantize_Second_Truncate_Returns_Expected(double value, double expected)
        => TruncateSecondsTest(value, expected, x => new TimeQuantizer(TimePrecision.Second, QuantizationMode.Truncate).Quantize(x));

    [Theory]
    [MemberData(nameof(TruncateCases))]
    public void Extension_TruncateSeconds_Returns_Expected(double value, double expected)
        => TruncateSecondsTest(value, expected, x => x.TruncateSeconds());

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TruncateCases))]
    public void Nullable_TruncateSeconds_Returns_Expected(double? value, double? expected)
        => Nullable_TruncateSecondsTest(value, expected, x => TimeQuantizer.TruncateSeconds(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TruncateCases))]
    public void Nullable_Quantize_Second_Truncate_Returns_Expected(double? value, double? expected)
        => Nullable_TruncateSecondsTest(value, expected, x => TimeQuantizer.Quantize(x, TimePrecision.Second, QuantizationMode.Truncate));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TruncateCases))]
    public void Nullable_Instance_Quantize_Second_Truncate_Returns_Expected(double? value, double? expected)
        => Nullable_TruncateSecondsTest(value, expected, x => new TimeQuantizer(TimePrecision.Second, QuantizationMode.Truncate).Quantize(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TruncateCases))]
    public void Nullable_Extension_TruncateSeconds_Returns_Expected(double? value, double? expected)
        => Nullable_TruncateSecondsTest(value, expected, x => x.TruncateSeconds());

    [Theory]
    [MemberData(nameof(TruncateCases))]
    public void TruncateMinutes_Returns_Expected(double value, double expected)
        => TruncateMinutesTest(value, expected, x => TimeQuantizer.TruncateMinutes(x));

    [Theory]
    [MemberData(nameof(TruncateCases))]
    public void Quantize_Minute_Truncate_Returns_Expected(double value, double expected)
        => TruncateMinutesTest(value, expected, x => TimeQuantizer.Quantize(x, TimePrecision.Minute, QuantizationMode.Truncate));

    [Theory]
    [MemberData(nameof(TruncateCases))]
    public void Instance_Quantize_Minute_Truncate_Returns_Expected(double value, double expected)
        => TruncateMinutesTest(value, expected, x => new TimeQuantizer(TimePrecision.Minute, QuantizationMode.Truncate).Quantize(x));

    [Theory]
    [MemberData(nameof(TruncateCases))]
    public void Extension_TruncateMinutes_Returns_Expected(double value, double expected)
        => TruncateMinutesTest(value, expected, x => x.TruncateMinutes());

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TruncateCases))]
    public void Nullable_TruncateMinutes_Returns_Expected(double? value, double? expected)
        => Nullable_TruncateMinutesTest(value, expected, x => TimeQuantizer.TruncateMinutes(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TruncateCases))]
    public void Nullable_Quantize_Minute_Truncate_Returns_Expected(double? value, double? expected)
        => Nullable_TruncateMinutesTest(value, expected, x => TimeQuantizer.Quantize(x, TimePrecision.Minute, QuantizationMode.Truncate));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TruncateCases))]
    public void Nullable_Instance_Quantize_Minute_Truncate_Returns_Expected(double? value, double? expected)
        => Nullable_TruncateMinutesTest(value, expected, x => new TimeQuantizer(TimePrecision.Minute, QuantizationMode.Truncate).Quantize(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TruncateCases))]
    public void Nullable_Extension_TruncateMinutes_Returns_Expected(double? value, double? expected)
        => Nullable_TruncateMinutesTest(value, expected, x => x.TruncateMinutes());

    [Theory]
    [MemberData(nameof(TruncateCases))]
    public void Truncate_Hours_Returns_Expected(double value, double expected)
        => TruncateHoursTest(value, expected, x => TimeQuantizer.TruncateHours(x));

    [Theory]
    [MemberData(nameof(TruncateCases))]
    public void Quantize_Truncate_Hours_Returns_Expected(double value, double expected)
        => TruncateHoursTest(value, expected, x => TimeQuantizer.Quantize(x, TimePrecision.Hour, QuantizationMode.Truncate));

    [Theory]
    [MemberData(nameof(TruncateCases))]
    public void Instance_Quantize_Truncate_Hours_Returns_Expected(double value, double expected)
        => TruncateHoursTest(value, expected, x => new TimeQuantizer(TimePrecision.Hour, QuantizationMode.Truncate).Quantize(x));

    [Theory]
    [MemberData(nameof(TruncateCases))]
    public void Extension_Truncate_Hours_Returns_Expected(double value, double expected)
        => TruncateHoursTest(value, expected, x => x.TruncateHours());

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TruncateCases))]
    public void Nullable_Truncate_Hours_Returns_Expected(double? value, double? expected)
        => Nullable_TruncateHoursTest(value, expected, x => TimeQuantizer.TruncateHours(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TruncateCases))]
    public void Nullable_Quantize_Truncate_Hours_Returns_Expected(double? value, double? expected)
        => Nullable_TruncateHoursTest(value, expected, x => TimeQuantizer.Quantize(x, TimePrecision.Hour, QuantizationMode.Truncate));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TruncateCases))]
    public void Nullable_Instance_Quantize_Truncate_Hours_Returns_Expected(double? value, double? expected)
        => Nullable_TruncateHoursTest(value, expected, x => new TimeQuantizer(TimePrecision.Hour, QuantizationMode.Truncate).Quantize(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TruncateCases))]
    public void Nullable_Extension_Truncate_Hours_Returns_Expected(double? value, double? expected)
        => Nullable_TruncateHoursTest(value, expected, x => x.TruncateHours());

    [Theory]
    [MemberData(nameof(TruncateCases))]
    public void Truncate_Days_Returns_Expected(double value, double expected)
        => TruncateDaysTest(value, expected, x => TimeQuantizer.TruncateDays(x));

    [Theory]
    [MemberData(nameof(TruncateCases))]
    public void Quantize_Truncate_Days_Returns_Expected(double value, double expected)
        => TruncateDaysTest(value, expected, x => TimeQuantizer.Quantize(x, TimePrecision.Day, QuantizationMode.Truncate));

    [Theory]
    [MemberData(nameof(TruncateCases))]
    public void Instance_Quantize_Truncate_Days_Returns_Expected(double value, double expected)
        => TruncateDaysTest(value, expected, x => new TimeQuantizer(TimePrecision.Day, QuantizationMode.Truncate).Quantize(x));

    [Theory]
    [MemberData(nameof(TruncateCases))]
    public void Extension_Truncate_Days_Returns_Expected(double value, double expected)
        => TruncateDaysTest(value, expected, x => x.TruncateDays());

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TruncateCases))]
    public void Nullable_Truncate_Days_Returns_Expected(double? value, double? expected)
        => Nullable_TruncateDaysTest(value, expected, x => TimeQuantizer.TruncateDays(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TruncateCases))]
    public void Nullable_Quantize_Truncate_Days_Returns_Expected(double? value, double? expected)
        => Nullable_TruncateDaysTest(value, expected, x => TimeQuantizer.Quantize(x, TimePrecision.Day, QuantizationMode.Truncate));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TruncateCases))]
    public void Nullable_Instance_Quantize_Truncate_Days_Returns_Expected(double? value, double? expected)
        => Nullable_TruncateDaysTest(value, expected, x => new TimeQuantizer(TimePrecision.Day, QuantizationMode.Truncate).Quantize(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(TruncateCases))]
    public void Nullable_Extension_Truncate_Days_Returns_Expected(double? value, double? expected)
        => Nullable_TruncateDaysTest(value, expected, x => x.TruncateDays());

    private void TruncateMicrosecondsTest(double value, double expected, Func<TimeSpan, TimeSpan> action)
    {
        // arrange
        var timespan = TimeSpan.FromMicroseconds(value);

        // act
        var actual = action(timespan).TotalMicroseconds;

        // assert
        Assert.Equal(expected, actual);
    }

    private void Nullable_TruncateMicrosecondsTest(double? value, double? expected, Func<TimeSpan?, TimeSpan?> action)
    {
        // arrange
        var timespan = TimeSpanFromMicroseconds(value);

        // act
        var actual = action(timespan)?.TotalMicroseconds;

        // assert
        Assert.Equal(expected, actual);
    }

    private void TruncateMillisecondsTest(double value, double expected, Func<TimeSpan, TimeSpan> action)
    {
        // arrange
        var timespan = TimeSpan.FromMilliseconds(value);

        // act
        var actual = action(timespan).TotalMilliseconds;

        // assert
        Assert.Equal(expected, actual);
    }

    private void Nullable_TruncateMillisecondsTest(double? value, double? expected, Func<TimeSpan?, TimeSpan?> action)
    {
        // arrange
        var timespan = TimeSpanFromMilliseconds(value);

        // act
        var actual = action(timespan)?.TotalMilliseconds;

        // assert
        Assert.Equal(expected, actual);
    }

    private void TruncateSecondsTest(double value, double expected, Func<TimeSpan, TimeSpan> action)
    {
        // arrange
        var timespan = TimeSpan.FromSeconds(value);

        // act
        var actual = action(timespan).TotalSeconds;

        // assert
        Assert.Equal(expected, actual);
    }

    private void Nullable_TruncateSecondsTest(double? value, double? expected, Func<TimeSpan?, TimeSpan?> action)
    {
        // arrange
        var timespan = TimeSpanFromSeconds(value);

        // act
        var actual = action(timespan)?.TotalSeconds;

        // assert
        Assert.Equal(expected, actual);
    }

    private void TruncateMinutesTest(double value, double expected, Func<TimeSpan, TimeSpan> action)
    {
        // arrange
        var timespan = TimeSpan.FromMinutes(value);

        // act
        var actual = action(timespan).TotalMinutes;

        // assert
        Assert.Equal(expected, actual);
    }

    private void Nullable_TruncateMinutesTest(double? value, double? expected, Func<TimeSpan?, TimeSpan?> action)
    {
        // arrange
        var timespan = TimeSpanFromMinutes(value);

        // act
        var actual = action(timespan)?.TotalMinutes;

        // assert
        Assert.Equal(expected, actual);
    }

    private void TruncateHoursTest(double value, double expected, Func<TimeSpan, TimeSpan> action)
    {
        // arrange
        var timespan = TimeSpan.FromHours(value);

        // act
        var actual = action(timespan).TotalHours;

        // assert
        Assert.Equal(expected, actual);
    }

    private void Nullable_TruncateHoursTest(double? value, double? expected, Func<TimeSpan?, TimeSpan?> action)
    {
        // arrange
        var timespan = TimeSpanFromHours(value);

        // act
        var actual = action(timespan)?.TotalHours;

        // assert
        Assert.Equal(expected, actual);
    }

    private void TruncateDaysTest(double value, double expected, Func<TimeSpan, TimeSpan> action)
    {
        // arrange
        var timespan = TimeSpan.FromDays(value);

        // act
        var actual = action(timespan).TotalDays;

        // assert
        Assert.Equal(expected, actual);
    }

    private void Nullable_TruncateDaysTest(double? value, double? expected, Func<TimeSpan?, TimeSpan?> action)
    {
        // arrange
        var timespan = TimeSpanFromDays(value);

        // act
        var actual = action(timespan)?.TotalDays;

        // assert
        Assert.Equal(expected, actual);
    }
}
