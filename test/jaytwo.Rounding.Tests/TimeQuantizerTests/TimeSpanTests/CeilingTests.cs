using Xunit;

namespace jaytwo.Rounding.Tests.TimeQuantizerTests.TimeSpanTests;

public class CeilingTests : TimeSpanQuantizeTests
{
    [Theory]
    [MemberData(nameof(CeilingCases))]
    public void CeilingMicroseconds_Returns_Expected(double value, double expected)
        => CeilingMicrosecondsTest(value, expected, x => TimeQuantizer.CeilingMicroseconds(x));

    [Theory]
    [MemberData(nameof(CeilingCases))]
    public void Quantize_Microsecond_Ceiling_Returns_Expected(double value, double expected)
        => CeilingMicrosecondsTest(value, expected, x => TimeQuantizer.Quantize(x, TimePrecision.Microsecond, QuantizationMode.Ceiling));

    [Theory]
    [MemberData(nameof(CeilingCases))]
    public void Instance_Quantize_Microsecond_Ceiling_Returns_Expected(double value, double expected)
        => CeilingMicrosecondsTest(value, expected, x => new TimeQuantizer(TimePrecision.Microsecond, QuantizationMode.Ceiling).Quantize(x));

    [Theory]
    [MemberData(nameof(CeilingCases))]
    public void Extension_CeilingMicroseconds_Returns_Expected(double value, double expected)
        => CeilingMicrosecondsTest(value, expected, x => x.CeilingMicroseconds());

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(CeilingCases))]
    public void Nullable_CeilingMicroseconds_Returns_Expected(double? value, double? expected)
        => Nullable_CeilingMicrosecondsTest(value, expected, x => TimeQuantizer.CeilingMicroseconds(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(CeilingCases))]
    public void Nullable_Quantize_Microsecond_Ceiling_Returns_Expected(double? value, double? expected)
        => Nullable_CeilingMicrosecondsTest(value, expected, x => TimeQuantizer.Quantize(x, TimePrecision.Microsecond, QuantizationMode.Ceiling));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(CeilingCases))]
    public void Nullable_Instance_Quantize_Microsecond_Ceiling_Returns_Expected(double? value, double? expected)
        => Nullable_CeilingMicrosecondsTest(value, expected, x => new TimeQuantizer(TimePrecision.Microsecond, QuantizationMode.Ceiling).Quantize(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(CeilingCases))]
    public void Nullable_Extension_CeilingMicroseconds_Returns_Expected(double? value, double? expected)
        => Nullable_CeilingMicrosecondsTest(value, expected, x => x.CeilingMicroseconds());

    [Theory]
    [MemberData(nameof(CeilingCases))]
    public void CeilingMilliseconds_Returns_Expected(double value, double expected)
        => CeilingMillisecondsTest(value, expected, x => TimeQuantizer.CeilingMilliseconds(x));

    [Theory]
    [MemberData(nameof(CeilingCases))]
    public void Quantize_Millisecond_Ceiling_Returns_Expected(double value, double expected)
        => CeilingMillisecondsTest(value, expected, x => TimeQuantizer.Quantize(x, TimePrecision.Millisecond, QuantizationMode.Ceiling));

    [Theory]
    [MemberData(nameof(CeilingCases))]
    public void Instance_Quantize_Millisecond_Ceiling_Returns_Expected(double value, double expected)
        => CeilingMillisecondsTest(value, expected, x => new TimeQuantizer(TimePrecision.Millisecond, QuantizationMode.Ceiling).Quantize(x));

    [Theory]
    [MemberData(nameof(CeilingCases))]
    public void Extension_CeilingMilliseconds_Returns_Expected(double value, double expected)
        => CeilingMillisecondsTest(value, expected, x => x.CeilingMilliseconds());

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(CeilingCases))]
    public void Nullable_CeilingMilliseconds_Returns_Expected(double? value, double? expected)
        => Nullable_CeilingMillisecondsTest(value, expected, x => TimeQuantizer.CeilingMilliseconds(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(CeilingCases))]
    public void Nullable_Quantize_Millisecond_Ceiling_Returns_Expected(double? value, double? expected)
        => Nullable_CeilingMillisecondsTest(value, expected, x => TimeQuantizer.Quantize(x, TimePrecision.Millisecond, QuantizationMode.Ceiling));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(CeilingCases))]
    public void Nullable_Instance_Quantize_Millisecond_Ceiling_Returns_Expected(double? value, double? expected)
        => Nullable_CeilingMillisecondsTest(value, expected, x => new TimeQuantizer(TimePrecision.Millisecond, QuantizationMode.Ceiling).Quantize(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(CeilingCases))]
    public void Nullable_Extension_CeilingMilliseconds_Returns_Expected(double? value, double? expected)
        => Nullable_CeilingMillisecondsTest(value, expected, x => x.CeilingMilliseconds());

    [Theory]
    [MemberData(nameof(CeilingCases))]
    public void CeilingSeconds_Returns_Expected(double value, double expected)
        => CeilingSecondsTest(value, expected, x => TimeQuantizer.CeilingSeconds(x));

    [Theory]
    [MemberData(nameof(CeilingCases))]
    public void Quantize_Second_Ceiling_Returns_Expected(double value, double expected)
        => CeilingSecondsTest(value, expected, x => TimeQuantizer.Quantize(x, TimePrecision.Second, QuantizationMode.Ceiling));

    [Theory]
    [MemberData(nameof(CeilingCases))]
    public void Instance_Quantize_Second_Ceiling_Returns_Expected(double value, double expected)
        => CeilingSecondsTest(value, expected, x => new TimeQuantizer(TimePrecision.Second, QuantizationMode.Ceiling).Quantize(x));

    [Theory]
    [MemberData(nameof(CeilingCases))]
    public void Extension_CeilingSeconds_Returns_Expected(double value, double expected)
        => CeilingSecondsTest(value, expected, x => x.CeilingSeconds());

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(CeilingCases))]
    public void Nullable_CeilingSeconds_Returns_Expected(double? value, double? expected)
        => Nullable_CeilingSecondsTest(value, expected, x => TimeQuantizer.CeilingSeconds(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(CeilingCases))]
    public void Nullable_Quantize_Second_Ceiling_Returns_Expected(double? value, double? expected)
        => Nullable_CeilingSecondsTest(value, expected, x => TimeQuantizer.Quantize(x, TimePrecision.Second, QuantizationMode.Ceiling));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(CeilingCases))]
    public void Nullable_Instance_Quantize_Second_Ceiling_Returns_Expected(double? value, double? expected)
        => Nullable_CeilingSecondsTest(value, expected, x => new TimeQuantizer(TimePrecision.Second, QuantizationMode.Ceiling).Quantize(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(CeilingCases))]
    public void Nullable_Extension_CeilingSeconds_Returns_Expected(double? value, double? expected)
        => Nullable_CeilingSecondsTest(value, expected, x => x.CeilingSeconds());

    [Theory]
    [MemberData(nameof(CeilingCases))]
    public void CeilingMinutes_Returns_Expected(double value, double expected)
        => CeilingMinutesTest(value, expected, x => TimeQuantizer.CeilingMinutes(x));

    [Theory]
    [MemberData(nameof(CeilingCases))]
    public void Quantize_Minute_Ceiling_Returns_Expected(double value, double expected)
        => CeilingMinutesTest(value, expected, x => TimeQuantizer.Quantize(x, TimePrecision.Minute, QuantizationMode.Ceiling));

    [Theory]
    [MemberData(nameof(CeilingCases))]
    public void Instance_Quantize_Minute_Ceiling_Returns_Expected(double value, double expected)
        => CeilingMinutesTest(value, expected, x => new TimeQuantizer(TimePrecision.Minute, QuantizationMode.Ceiling).Quantize(x));

    [Theory]
    [MemberData(nameof(CeilingCases))]
    public void Extension_CeilingMinutes_Returns_Expected(double value, double expected)
        => CeilingMinutesTest(value, expected, x => x.CeilingMinutes());

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(CeilingCases))]
    public void Nullable_CeilingMinutes_Returns_Expected(double? value, double? expected)
        => Nullable_CeilingMinutesTest(value, expected, x => TimeQuantizer.CeilingMinutes(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(CeilingCases))]
    public void Nullable_Quantize_Minute_Ceiling_Returns_Expected(double? value, double? expected)
        => Nullable_CeilingMinutesTest(value, expected, x => TimeQuantizer.Quantize(x, TimePrecision.Minute, QuantizationMode.Ceiling));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(CeilingCases))]
    public void Nullable_Instance_Quantize_Minute_Ceiling_Returns_Expected(double? value, double? expected)
        => Nullable_CeilingMinutesTest(value, expected, x => new TimeQuantizer(TimePrecision.Minute, QuantizationMode.Ceiling).Quantize(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(CeilingCases))]
    public void Nullable_Extension_CeilingMinutes_Returns_Expected(double? value, double? expected)
        => Nullable_CeilingMinutesTest(value, expected, x => x.CeilingMinutes());

    [Theory]
    [MemberData(nameof(CeilingCases))]
    public void Ceiling_Hours_Returns_Expected(double value, double expected)
        => CeilingHoursTest(value, expected, x => TimeQuantizer.CeilingHours(x));

    [Theory]
    [MemberData(nameof(CeilingCases))]
    public void Quantize_Ceiling_Hours_Returns_Expected(double value, double expected)
        => CeilingHoursTest(value, expected, x => TimeQuantizer.Quantize(x, TimePrecision.Hour, QuantizationMode.Ceiling));

    [Theory]
    [MemberData(nameof(CeilingCases))]
    public void Instance_Quantize_Ceiling_Hours_Returns_Expected(double value, double expected)
        => CeilingHoursTest(value, expected, x => new TimeQuantizer(TimePrecision.Hour, QuantizationMode.Ceiling).Quantize(x));

    [Theory]
    [MemberData(nameof(CeilingCases))]
    public void Extension_Ceiling_Hours_Returns_Expected(double value, double expected)
        => CeilingHoursTest(value, expected, x => x.CeilingHours());

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(CeilingCases))]
    public void Nullable_Ceiling_Hours_Returns_Expected(double? value, double? expected)
        => Nullable_CeilingHoursTest(value, expected, x => TimeQuantizer.CeilingHours(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(CeilingCases))]
    public void Nullable_Quantize_Ceiling_Hours_Returns_Expected(double? value, double? expected)
        => Nullable_CeilingHoursTest(value, expected, x => TimeQuantizer.Quantize(x, TimePrecision.Hour, QuantizationMode.Ceiling));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(CeilingCases))]
    public void Nullable_Instance_Quantize_Ceiling_Hours_Returns_Expected(double? value, double? expected)
        => Nullable_CeilingHoursTest(value, expected, x => new TimeQuantizer(TimePrecision.Hour, QuantizationMode.Ceiling).Quantize(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(CeilingCases))]
    public void Nullable_Extension_Ceiling_Hours_Returns_Expected(double? value, double? expected)
        => Nullable_CeilingHoursTest(value, expected, x => x.CeilingHours());

    [Theory]
    [MemberData(nameof(CeilingCases))]
    public void Ceiling_Days_Returns_Expected(double value, double expected)
        => CeilingDaysTest(value, expected, x => TimeQuantizer.CeilingDays(x));

    [Theory]
    [MemberData(nameof(CeilingCases))]
    public void Quantize_Ceiling_Days_Returns_Expected(double value, double expected)
        => CeilingDaysTest(value, expected, x => TimeQuantizer.Quantize(x, TimePrecision.Day, QuantizationMode.Ceiling));

    [Theory]
    [MemberData(nameof(CeilingCases))]
    public void Instance_Quantize_Ceiling_Days_Returns_Expected(double value, double expected)
        => CeilingDaysTest(value, expected, x => new TimeQuantizer(TimePrecision.Day, QuantizationMode.Ceiling).Quantize(x));

    [Theory]
    [MemberData(nameof(CeilingCases))]
    public void Extension_Ceiling_Days_Returns_Expected(double value, double expected)
        => CeilingDaysTest(value, expected, x => x.CeilingDays());

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(CeilingCases))]
    public void Nullable_Ceiling_Days_Returns_Expected(double? value, double? expected)
        => Nullable_CeilingDaysTest(value, expected, x => TimeQuantizer.CeilingDays(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(CeilingCases))]
    public void Nullable_Quantize_Ceiling_Days_Returns_Expected(double? value, double? expected)
        => Nullable_CeilingDaysTest(value, expected, x => TimeQuantizer.Quantize(x, TimePrecision.Day, QuantizationMode.Ceiling));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(CeilingCases))]
    public void Nullable_Instance_Quantize_Ceiling_Days_Returns_Expected(double? value, double? expected)
        => Nullable_CeilingDaysTest(value, expected, x => new TimeQuantizer(TimePrecision.Day, QuantizationMode.Ceiling).Quantize(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(CeilingCases))]
    public void Nullable_Extension_Ceiling_Days_Returns_Expected(double? value, double? expected)
        => Nullable_CeilingDaysTest(value, expected, x => x.CeilingDays());

    private void CeilingMicrosecondsTest(double value, double expected, Func<TimeSpan, TimeSpan> action)
    {
        // arrange
        var timespan = TimeSpan.FromMicroseconds(value);

        // act
        var actual = action(timespan).TotalMicroseconds;

        // assert
        Assert.Equal(expected, actual);
    }

    private void Nullable_CeilingMicrosecondsTest(double? value, double? expected, Func<TimeSpan?, TimeSpan?> action)
    {
        // arrange
        var timespan = TimeSpanFromMicroseconds(value);

        // act
        var actual = action(timespan)?.TotalMicroseconds;

        // assert
        Assert.Equal(expected, actual);
    }

    private void CeilingMillisecondsTest(double value, double expected, Func<TimeSpan, TimeSpan> action)
    {
        // arrange
        var timespan = TimeSpan.FromMilliseconds(value);

        // act
        var actual = action(timespan).TotalMilliseconds;

        // assert
        Assert.Equal(expected, actual);
    }

    private void Nullable_CeilingMillisecondsTest(double? value, double? expected, Func<TimeSpan?, TimeSpan?> action)
    {
        // arrange
        var timespan = TimeSpanFromMilliseconds(value);

        // act
        var actual = action(timespan)?.TotalMilliseconds;

        // assert
        Assert.Equal(expected, actual);
    }

    private void CeilingSecondsTest(double value, double expected, Func<TimeSpan, TimeSpan> action)
    {
        // arrange
        var timespan = TimeSpan.FromSeconds(value);

        // act
        var actual = action(timespan).TotalSeconds;

        // assert
        Assert.Equal(expected, actual);
    }

    private void Nullable_CeilingSecondsTest(double? value, double? expected, Func<TimeSpan?, TimeSpan?> action)
    {
        // arrange
        var timespan = TimeSpanFromSeconds(value);

        // act
        var actual = action(timespan)?.TotalSeconds;

        // assert
        Assert.Equal(expected, actual);
    }

    private void CeilingMinutesTest(double value, double expected, Func<TimeSpan, TimeSpan> action)
    {
        // arrange
        var timespan = TimeSpan.FromMinutes(value);

        // act
        var actual = action(timespan).TotalMinutes;

        // assert
        Assert.Equal(expected, actual);
    }

    private void Nullable_CeilingMinutesTest(double? value, double? expected, Func<TimeSpan?, TimeSpan?> action)
    {
        // arrange
        var timespan = TimeSpanFromMinutes(value);

        // act
        var actual = action(timespan)?.TotalMinutes;

        // assert
        Assert.Equal(expected, actual);
    }

    private void CeilingHoursTest(double value, double expected, Func<TimeSpan, TimeSpan> action)
    {
        // arrange
        var timespan = TimeSpan.FromHours(value);

        // act
        var actual = action(timespan).TotalHours;

        // assert
        Assert.Equal(expected, actual);
    }

    private void Nullable_CeilingHoursTest(double? value, double? expected, Func<TimeSpan?, TimeSpan?> action)
    {
        // arrange
        var timespan = TimeSpanFromHours(value);

        // act
        var actual = action(timespan)?.TotalHours;

        // assert
        Assert.Equal(expected, actual);
    }

    private void CeilingDaysTest(double value, double expected, Func<TimeSpan, TimeSpan> action)
    {
        // arrange
        var timespan = TimeSpan.FromDays(value);

        // act
        var actual = action(timespan).TotalDays;

        // assert
        Assert.Equal(expected, actual);
    }

    private void Nullable_CeilingDaysTest(double? value, double? expected, Func<TimeSpan?, TimeSpan?> action)
    {
        // arrange
        var timespan = TimeSpanFromDays(value);

        // act
        var actual = action(timespan)?.TotalDays;

        // assert
        Assert.Equal(expected, actual);
    }
}
