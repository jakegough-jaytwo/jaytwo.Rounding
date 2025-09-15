using Xunit;

namespace jaytwo.Rounding.Tests.TimeQuantizerTests.TimeSpanTests;

public class FloorTests : TimeSpanQuantizeTests
{
    [Theory]
    [MemberData(nameof(FloorCases))]
    public void FloorMicroseconds_Returns_Expected(double value, double expected)
        => FloorMicrosecondsTest(value, expected, x => TimeQuantizer.FloorMicroseconds(x));

    [Theory]
    [MemberData(nameof(FloorCases))]
    public void Quantize_Microsecond_Floor_Returns_Expected(double value, double expected)
        => FloorMicrosecondsTest(value, expected, x => TimeQuantizer.Quantize(x, TimePrecision.Microsecond, QuantizationMode.Floor));

    [Theory]
    [MemberData(nameof(FloorCases))]
    public void Instance_Quantize_Microsecond_Floor_Returns_Expected(double value, double expected)
        => FloorMicrosecondsTest(value, expected, x => new TimeQuantizer(TimePrecision.Microsecond, QuantizationMode.Floor).Quantize(x));

    [Theory]
    [MemberData(nameof(FloorCases))]
    public void Extension_FloorMicroseconds_Returns_Expected(double value, double expected)
        => FloorMicrosecondsTest(value, expected, x => x.FloorMicroseconds());

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(FloorCases))]
    public void Nullable_FloorMicroseconds_Returns_Expected(double? value, double? expected)
        => Nullable_FloorMicrosecondsTest(value, expected, x => TimeQuantizer.FloorMicroseconds(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(FloorCases))]
    public void Nullable_Quantize_Microsecond_Floor_Returns_Expected(double? value, double? expected)
        => Nullable_FloorMicrosecondsTest(value, expected, x => TimeQuantizer.Quantize(x, TimePrecision.Microsecond, QuantizationMode.Floor));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(FloorCases))]
    public void Nullable_Instance_Quantize_Microsecond_Floor_Returns_Expected(double? value, double? expected)
        => Nullable_FloorMicrosecondsTest(value, expected, x => new TimeQuantizer(TimePrecision.Microsecond, QuantizationMode.Floor).Quantize(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(FloorCases))]
    public void Nullable_Extension_FloorMicroseconds_Returns_Expected(double? value, double? expected)
        => Nullable_FloorMicrosecondsTest(value, expected, x => x.FloorMicroseconds());

    [Theory]
    [MemberData(nameof(FloorCases))]
    public void FloorMilliseconds_Returns_Expected(double value, double expected)
        => FloorMillisecondsTest(value, expected, x => TimeQuantizer.FloorMilliseconds(x));

    [Theory]
    [MemberData(nameof(FloorCases))]
    public void Quantize_Millisecond_Floor_Returns_Expected(double value, double expected)
        => FloorMillisecondsTest(value, expected, x => TimeQuantizer.Quantize(x, TimePrecision.Millisecond, QuantizationMode.Floor));

    [Theory]
    [MemberData(nameof(FloorCases))]
    public void Instance_Quantize_Millisecond_Floor_Returns_Expected(double value, double expected)
        => FloorMillisecondsTest(value, expected, x => new TimeQuantizer(TimePrecision.Millisecond, QuantizationMode.Floor).Quantize(x));

    [Theory]
    [MemberData(nameof(FloorCases))]
    public void Extension_FloorMilliseconds_Returns_Expected(double value, double expected)
        => FloorMillisecondsTest(value, expected, x => x.FloorMilliseconds());

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(FloorCases))]
    public void Nullable_FloorMilliseconds_Returns_Expected(double? value, double? expected)
        => Nullable_FloorMillisecondsTest(value, expected, x => TimeQuantizer.FloorMilliseconds(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(FloorCases))]
    public void Nullable_Quantize_Millisecond_Floor_Returns_Expected(double? value, double? expected)
        => Nullable_FloorMillisecondsTest(value, expected, x => TimeQuantizer.Quantize(x, TimePrecision.Millisecond, QuantizationMode.Floor));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(FloorCases))]
    public void Nullable_Instance_Quantize_Millisecond_Floor_Returns_Expected(double? value, double? expected)
        => Nullable_FloorMillisecondsTest(value, expected, x => new TimeQuantizer(TimePrecision.Millisecond, QuantizationMode.Floor).Quantize(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(FloorCases))]
    public void Nullable_Extension_FloorMilliseconds_Returns_Expected(double? value, double? expected)
        => Nullable_FloorMillisecondsTest(value, expected, x => x.FloorMilliseconds());

    [Theory]
    [MemberData(nameof(FloorCases))]
    public void FloorSeconds_Returns_Expected(double value, double expected)
        => FloorSecondsTest(value, expected, x => TimeQuantizer.FloorSeconds(x));

    [Theory]
    [MemberData(nameof(FloorCases))]
    public void Quantize_Second_Floor_Returns_Expected(double value, double expected)
        => FloorSecondsTest(value, expected, x => TimeQuantizer.Quantize(x, TimePrecision.Second, QuantizationMode.Floor));

    [Theory]
    [MemberData(nameof(FloorCases))]
    public void Instance_Quantize_Second_Floor_Returns_Expected(double value, double expected)
        => FloorSecondsTest(value, expected, x => new TimeQuantizer(TimePrecision.Second, QuantizationMode.Floor).Quantize(x));

    [Theory]
    [MemberData(nameof(FloorCases))]
    public void Extension_FloorSeconds_Returns_Expected(double value, double expected)
        => FloorSecondsTest(value, expected, x => x.FloorSeconds());

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(FloorCases))]
    public void Nullable_FloorSeconds_Returns_Expected(double? value, double? expected)
        => Nullable_FloorSecondsTest(value, expected, x => TimeQuantizer.FloorSeconds(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(FloorCases))]
    public void Nullable_Quantize_Second_Floor_Returns_Expected(double? value, double? expected)
        => Nullable_FloorSecondsTest(value, expected, x => TimeQuantizer.Quantize(x, TimePrecision.Second, QuantizationMode.Floor));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(FloorCases))]
    public void Nullable_Instance_Quantize_Second_Floor_Returns_Expected(double? value, double? expected)
        => Nullable_FloorSecondsTest(value, expected, x => new TimeQuantizer(TimePrecision.Second, QuantizationMode.Floor).Quantize(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(FloorCases))]
    public void Nullable_Extension_FloorSeconds_Returns_Expected(double? value, double? expected)
        => Nullable_FloorSecondsTest(value, expected, x => x.FloorSeconds());

    [Theory]
    [MemberData(nameof(FloorCases))]
    public void FloorMinutes_Returns_Expected(double value, double expected)
        => FloorMinutesTest(value, expected, x => TimeQuantizer.FloorMinutes(x));

    [Theory]
    [MemberData(nameof(FloorCases))]
    public void Quantize_Minute_Floor_Returns_Expected(double value, double expected)
        => FloorMinutesTest(value, expected, x => TimeQuantizer.Quantize(x, TimePrecision.Minute, QuantizationMode.Floor));

    [Theory]
    [MemberData(nameof(FloorCases))]
    public void Instance_Quantize_Minute_Floor_Returns_Expected(double value, double expected)
        => FloorMinutesTest(value, expected, x => new TimeQuantizer(TimePrecision.Minute, QuantizationMode.Floor).Quantize(x));

    [Theory]
    [MemberData(nameof(FloorCases))]
    public void Extension_FloorMinutes_Returns_Expected(double value, double expected)
        => FloorMinutesTest(value, expected, x => x.FloorMinutes());

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(FloorCases))]
    public void Nullable_FloorMinutes_Returns_Expected(double? value, double? expected)
        => Nullable_FloorMinutesTest(value, expected, x => TimeQuantizer.FloorMinutes(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(FloorCases))]
    public void Nullable_Quantize_Minute_Floor_Returns_Expected(double? value, double? expected)
        => Nullable_FloorMinutesTest(value, expected, x => TimeQuantizer.Quantize(x, TimePrecision.Minute, QuantizationMode.Floor));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(FloorCases))]
    public void Nullable_Instance_Quantize_Minute_Floor_Returns_Expected(double? value, double? expected)
        => Nullable_FloorMinutesTest(value, expected, x => new TimeQuantizer(TimePrecision.Minute, QuantizationMode.Floor).Quantize(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(FloorCases))]
    public void Nullable_Extension_FloorMinutes_Returns_Expected(double? value, double? expected)
        => Nullable_FloorMinutesTest(value, expected, x => x.FloorMinutes());

    [Theory]
    [MemberData(nameof(FloorCases))]
    public void Floor_Hours_Returns_Expected(double value, double expected)
        => FloorHoursTest(value, expected, x => TimeQuantizer.FloorHours(x));

    [Theory]
    [MemberData(nameof(FloorCases))]
    public void Quantize_Floor_Hours_Returns_Expected(double value, double expected)
        => FloorHoursTest(value, expected, x => TimeQuantizer.Quantize(x, TimePrecision.Hour, QuantizationMode.Floor));

    [Theory]
    [MemberData(nameof(FloorCases))]
    public void Instance_Quantize_Floor_Hours_Returns_Expected(double value, double expected)
        => FloorHoursTest(value, expected, x => new TimeQuantizer(TimePrecision.Hour, QuantizationMode.Floor).Quantize(x));

    [Theory]
    [MemberData(nameof(FloorCases))]
    public void Extension_Floor_Hours_Returns_Expected(double value, double expected)
        => FloorHoursTest(value, expected, x => x.FloorHours());

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(FloorCases))]
    public void Nullable_Floor_Hours_Returns_Expected(double? value, double? expected)
        => Nullable_FloorHoursTest(value, expected, x => TimeQuantizer.FloorHours(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(FloorCases))]
    public void Nullable_Quantize_Floor_Hours_Returns_Expected(double? value, double? expected)
        => Nullable_FloorHoursTest(value, expected, x => TimeQuantizer.Quantize(x, TimePrecision.Hour, QuantizationMode.Floor));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(FloorCases))]
    public void Nullable_Instance_Quantize_Floor_Hours_Returns_Expected(double? value, double? expected)
        => Nullable_FloorHoursTest(value, expected, x => new TimeQuantizer(TimePrecision.Hour, QuantizationMode.Floor).Quantize(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(FloorCases))]
    public void Nullable_Extension_Floor_Hours_Returns_Expected(double? value, double? expected)
        => Nullable_FloorHoursTest(value, expected, x => x.FloorHours());

    [Theory]
    [MemberData(nameof(FloorCases))]
    public void Floor_Days_Returns_Expected(double value, double expected)
        => FloorDaysTest(value, expected, x => TimeQuantizer.FloorDays(x));

    [Theory]
    [MemberData(nameof(FloorCases))]
    public void Quantize_Floor_Days_Returns_Expected(double value, double expected)
        => FloorDaysTest(value, expected, x => TimeQuantizer.Quantize(x, TimePrecision.Day, QuantizationMode.Floor));

    [Theory]
    [MemberData(nameof(FloorCases))]
    public void Instance_Quantize_Floor_Days_Returns_Expected(double value, double expected)
        => FloorDaysTest(value, expected, x => new TimeQuantizer(TimePrecision.Day, QuantizationMode.Floor).Quantize(x));

    [Theory]
    [MemberData(nameof(FloorCases))]
    public void Extension_Floor_Days_Returns_Expected(double value, double expected)
        => FloorDaysTest(value, expected, x => x.FloorDays());

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(FloorCases))]
    public void Nullable_Floor_Days_Returns_Expected(double? value, double? expected)
        => Nullable_FloorDaysTest(value, expected, x => TimeQuantizer.FloorDays(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(FloorCases))]
    public void Nullable_Quantize_Floor_Days_Returns_Expected(double? value, double? expected)
        => Nullable_FloorDaysTest(value, expected, x => TimeQuantizer.Quantize(x, TimePrecision.Day, QuantizationMode.Floor));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(FloorCases))]
    public void Nullable_Instance_Quantize_Floor_Days_Returns_Expected(double? value, double? expected)
        => Nullable_FloorDaysTest(value, expected, x => new TimeQuantizer(TimePrecision.Day, QuantizationMode.Floor).Quantize(x));

    [Theory]
    [InlineData(null, null)]
    [MemberData(nameof(FloorCases))]
    public void Nullable_Extension_Floor_Days_Returns_Expected(double? value, double? expected)
        => Nullable_FloorDaysTest(value, expected, x => x.FloorDays());

    private void FloorMicrosecondsTest(double value, double expected, Func<TimeSpan, TimeSpan> action)
    {
        // arrange
        var timespan = TimeSpan.FromMicroseconds(value);

        // act
        var actual = action(timespan).TotalMicroseconds;

        // assert
        Assert.Equal(expected, actual);
    }

    private void Nullable_FloorMicrosecondsTest(double? value, double? expected, Func<TimeSpan?, TimeSpan?> action)
    {
        // arrange
        var timespan = TimeSpanFromMicroseconds(value);

        // act
        var actual = action(timespan)?.TotalMicroseconds;

        // assert
        Assert.Equal(expected, actual);
    }

    private void FloorMillisecondsTest(double value, double expected, Func<TimeSpan, TimeSpan> action)
    {
        // arrange
        var timespan = TimeSpan.FromMilliseconds(value);

        // act
        var actual = action(timespan).TotalMilliseconds;

        // assert
        Assert.Equal(expected, actual);
    }

    private void Nullable_FloorMillisecondsTest(double? value, double? expected, Func<TimeSpan?, TimeSpan?> action)
    {
        // arrange
        var timespan = TimeSpanFromMilliseconds(value);

        // act
        var actual = action(timespan)?.TotalMilliseconds;

        // assert
        Assert.Equal(expected, actual);
    }

    private void FloorSecondsTest(double value, double expected, Func<TimeSpan, TimeSpan> action)
    {
        // arrange
        var timespan = TimeSpan.FromSeconds(value);

        // act
        var actual = action(timespan).TotalSeconds;

        // assert
        Assert.Equal(expected, actual);
    }

    private void Nullable_FloorSecondsTest(double? value, double? expected, Func<TimeSpan?, TimeSpan?> action)
    {
        // arrange
        var timespan = TimeSpanFromSeconds(value);

        // act
        var actual = action(timespan)?.TotalSeconds;

        // assert
        Assert.Equal(expected, actual);
    }

    private void FloorMinutesTest(double value, double expected, Func<TimeSpan, TimeSpan> action)
    {
        // arrange
        var timespan = TimeSpan.FromMinutes(value);

        // act
        var actual = action(timespan).TotalMinutes;

        // assert
        Assert.Equal(expected, actual);
    }

    private void Nullable_FloorMinutesTest(double? value, double? expected, Func<TimeSpan?, TimeSpan?> action)
    {
        // arrange
        var timespan = TimeSpanFromMinutes(value);

        // act
        var actual = action(timespan)?.TotalMinutes;

        // assert
        Assert.Equal(expected, actual);
    }

    private void FloorHoursTest(double value, double expected, Func<TimeSpan, TimeSpan> action)
    {
        // arrange
        var timespan = TimeSpan.FromHours(value);

        // act
        var actual = action(timespan).TotalHours;

        // assert
        Assert.Equal(expected, actual);
    }

    private void Nullable_FloorHoursTest(double? value, double? expected, Func<TimeSpan?, TimeSpan?> action)
    {
        // arrange
        var timespan = TimeSpanFromHours(value);

        // act
        var actual = action(timespan)?.TotalHours;

        // assert
        Assert.Equal(expected, actual);
    }

    private void FloorDaysTest(double value, double expected, Func<TimeSpan, TimeSpan> action)
    {
        // arrange
        var timespan = TimeSpan.FromDays(value);

        // act
        var actual = action(timespan).TotalDays;

        // assert
        Assert.Equal(expected, actual);
    }

    private void Nullable_FloorDaysTest(double? value, double? expected, Func<TimeSpan?, TimeSpan?> action)
    {
        // arrange
        var timespan = TimeSpanFromDays(value);

        // act
        var actual = action(timespan)?.TotalDays;

        // assert
        Assert.Equal(expected, actual);
    }
}
