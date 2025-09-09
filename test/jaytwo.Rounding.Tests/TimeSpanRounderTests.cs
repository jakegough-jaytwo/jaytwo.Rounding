using Xunit;

namespace jaytwo.Rounding.Tests;

public class TimeSpanRounderTests
{
    [Theory]
    [InlineData(1.5, 1)]
    [InlineData(1, 1)]
    [InlineData(-1.5, -2)]
    public void FloorMillisecondsReturnsExpectedResults(double value, double expected)
    {
        // arrange
        var timespan = TimeSpan.FromMilliseconds(value);

        // act
        var actual = TimeSpanRounder.FloorMilliseconds(timespan).TotalMilliseconds;

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(null, null)]
    [InlineData(1.5, 1)]
    [InlineData(1, 1)]
    [InlineData(-1.5, -2)]
    public void NullableFloorMillisecondsReturnsExpectedResults(double? value, double? expected)
    {
        // arrange
        var timespan = TimeSpanFromMilliseconds(value);

        // act
        var actual = TimeSpanRounder.FloorMilliseconds(timespan)?.TotalMilliseconds;

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(1.5, 1)]
    [InlineData(1, 1)]
    [InlineData(-1.5, -2)]
    public void FloorSecondsReturnsExpectedResults(double value, double expected)
    {
        // arrange
        var timespan = TimeSpan.FromSeconds(value);

        // act
        var actual = TimeSpanRounder.FloorSeconds(timespan).TotalSeconds;

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(null, null)]
    [InlineData(1.5, 1)]
    [InlineData(1, 1)]
    [InlineData(-1.5, -2)]
    public void NullableFloorSecondsReturnsExpectedResults(double? value, double? expected)
    {
        // arrange
        var timespan = TimeSpanFromSeconds(value);

        // act
        var actual = TimeSpanRounder.FloorSeconds(timespan)?.TotalSeconds;

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(1.5, 1)]
    [InlineData(1, 1)]
    [InlineData(-1.5, -2)]
    public void FloorMinutesReturnsExpectedResults(double value, double expected)
    {
        // arrange
        var timespan = TimeSpan.FromMinutes(value);

        // act
        var actual = TimeSpanRounder.FloorMinutes(timespan).TotalMinutes;

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(null, null)]
    [InlineData(1.5, 1)]
    [InlineData(1, 1)]
    [InlineData(-1.5, -2)]
    public void NullableFloorMinutesReturnsExpectedResults(double? value, double? expected)
    {
        // arrange
        var timespan = TimeSpanFromMinutes(value);

        // act
        var actual = TimeSpanRounder.FloorMinutes(timespan)?.TotalMinutes;

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(1.5, 1)]
    [InlineData(1, 1)]
    [InlineData(-1.5, -2)]
    public void FloorHoursReturnsExpectedResults(double value, double expected)
    {
        // arrange
        var timespan = TimeSpan.FromHours(value);

        // act
        var actual = TimeSpanRounder.FloorHours(timespan).TotalHours;

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(null, null)]
    [InlineData(1.5, 1)]
    [InlineData(1, 1)]
    [InlineData(-1.5, -2)]
    public void NullableFloorHoursReturnsExpectedResults(double? value, double? expected)
    {
        // arrange
        var timespan = TimeSpanFromHours(value);

        // act
        var actual = TimeSpanRounder.FloorHours(timespan)?.TotalHours;

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(1.5, 1)]
    [InlineData(1, 1)]
    [InlineData(-1.5, -2)]
    public void FloorDaysReturnsExpectedResults(double value, double expected)
    {
        // arrange
        var timespan = TimeSpan.FromDays(value);

        // act
        var actual = TimeSpanRounder.FloorDays(timespan).TotalDays;

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(null, null)]
    [InlineData(1.5, 1)]
    [InlineData(1, 1)]
    [InlineData(-1.5, -2)]
    public void NullableFloorDaysReturnsExpectedResults(double? value, double? expected)
    {
        // arrange
        var timespan = TimeSpanFromDays(value);

        // act
        var actual = TimeSpanRounder.FloorDays(timespan)?.TotalDays;

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(1.5, 2)]
    [InlineData(1, 1)]
    [InlineData(-1.5, -1)]
    public void CeilingMillisecondsReturnsExpectedResults(double value, double expected)
    {
        // arrange
        var timespan = TimeSpan.FromMilliseconds(value);

        // act
        var actual = TimeSpanRounder.CeilingMilliseconds(timespan).TotalMilliseconds;

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(null, null)]
    [InlineData(1.5, 2)]
    [InlineData(1, 1)]
    [InlineData(-1.5, -1)]
    public void NullableCeilingMillisecondsReturnsExpectedResults(double? value, double? expected)
    {
        // arrange
        var timespan = TimeSpanFromMilliseconds(value);

        // act
        var actual = TimeSpanRounder.CeilingMilliseconds(timespan)?.TotalMilliseconds;

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(1.5, 2)]
    [InlineData(1, 1)]
    [InlineData(-1.5, -1)]
    public void CeilingSecondsReturnsExpectedResults(double value, double expected)
    {
        // arrange
        var timespan = TimeSpan.FromSeconds(value);

        // act
        var actual = TimeSpanRounder.CeilingSeconds(timespan).TotalSeconds;

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(null, null)]
    [InlineData(1.5, 2)]
    [InlineData(1, 1)]
    [InlineData(-1.5, -1)]
    public void NullableCeilingSecondsReturnsExpectedResults(double? value, double? expected)
    {
        // arrange
        var timespan = TimeSpanFromSeconds(value);

        // act
        var actual = TimeSpanRounder.CeilingSeconds(timespan)?.TotalSeconds;

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(1.5, 2)]
    [InlineData(1, 1)]
    [InlineData(-1.5, -1)]
    public void CeilingMinutesReturnsExpectedResults(double value, double expected)
    {
        // arrange
        var timespan = TimeSpan.FromMinutes(value);

        // act
        var actual = TimeSpanRounder.CeilingMinutes(timespan).TotalMinutes;

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(null, null)]
    [InlineData(1.5, 2)]
    [InlineData(1, 1)]
    [InlineData(-1.5, -1)]
    public void NullableCeilingMinutesReturnsExpectedResults(double? value, double? expected)
    {
        // arrange
        var timespan = TimeSpanFromMinutes(value);

        // act
        var actual = TimeSpanRounder.CeilingMinutes(timespan)?.TotalMinutes;

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(1.5, 2)]
    [InlineData(1, 1)]
    [InlineData(-1.5, -1)]
    public void CeilingHoursReturnsExpectedResults(double value, double expected)
    {
        // arrange
        var timespan = TimeSpan.FromHours(value);

        // act
        var actual = TimeSpanRounder.CeilingHours(timespan).TotalHours;

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(null, null)]
    [InlineData(1.5, 2)]
    [InlineData(1, 1)]
    [InlineData(-1.5, -1)]
    public void NullableCeilingHoursReturnsExpectedResults(double? value, double? expected)
    {
        // arrange
        var timespan = TimeSpanFromHours(value);

        // act
        var actual = TimeSpanRounder.CeilingHours(timespan)?.TotalHours;

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(1.5, 2)]
    [InlineData(1, 1)]
    [InlineData(-1.5, -1)]
    public void CeilingDaysReturnsExpectedResults(double value, double expected)
    {
        // arrange
        var timespan = TimeSpan.FromDays(value);

        // act
        var actual = TimeSpanRounder.CeilingDays(timespan).TotalDays;

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(null, null)]
    [InlineData(1.5, 2)]
    [InlineData(1, 1)]
    [InlineData(-1.5, -1)]
    public void NullableCeilingDaysReturnsExpectedResults(double? value, double? expected)
    {
        // arrange
        var timespan = TimeSpanFromDays(value);

        // act
        var actual = TimeSpanRounder.CeilingDays(timespan)?.TotalDays;

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(1.5, 1)]
    [InlineData(1, 1)]
    [InlineData(-1.5, -1)]
    public void TruncateMillisecondsReturnsExpectedResults(double value, double expected)
    {
        // arrange
        var timespan = TimeSpan.FromMilliseconds(value);

        // act
        var actual = TimeSpanRounder.TruncateMilliseconds(timespan).TotalMilliseconds;

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(null, null)]
    [InlineData(1.5, 1)]
    [InlineData(1, 1)]
    [InlineData(-1.5, -1)]
    public void NullableTruncateMillisecondsReturnsExpectedResults(double? value, double? expected)
    {
        // arrange
        var timespan = TimeSpanFromMilliseconds(value);

        // act
        var actual = TimeSpanRounder.TruncateMilliseconds(timespan)?.TotalMilliseconds;

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(1.5, 1)]
    [InlineData(1, 1)]
    [InlineData(-1.5, -1)]
    public void TruncateSecondsReturnsExpectedResults(double value, double expected)
    {
        // arrange
        var timespan = TimeSpan.FromSeconds(value);

        // act
        var actual = TimeSpanRounder.TruncateSeconds(timespan).TotalSeconds;

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(null, null)]
    [InlineData(1.5, 1)]
    [InlineData(1, 1)]
    [InlineData(-1.5, -1)]
    public void NullableTruncateSecondsReturnsExpectedResults(double? value, double? expected)
    {
        // arrange
        var timespan = TimeSpanFromSeconds(value);

        // act
        var actual = TimeSpanRounder.TruncateSeconds(timespan)?.TotalSeconds;

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(1.5, 1)]
    [InlineData(1, 1)]
    [InlineData(-1.5, -1)]
    public void TruncateMinutesReturnsExpectedResults(double value, double expected)
    {
        // arrange
        var timespan = TimeSpan.FromMinutes(value);

        // act
        var actual = TimeSpanRounder.TruncateMinutes(timespan).TotalMinutes;

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(null, null)]
    [InlineData(1.5, 1)]
    [InlineData(1, 1)]
    [InlineData(-1.5, -1)]
    public void NullableTruncateMinutesReturnsExpectedResults(double? value, double? expected)
    {
        // arrange
        var timespan = TimeSpanFromMinutes(value);

        // act
        var actual = TimeSpanRounder.TruncateMinutes(timespan)?.TotalMinutes;

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(1.5, 1)]
    [InlineData(1, 1)]
    [InlineData(-1.5, -1)]
    public void TruncateHoursReturnsExpectedResults(double value, double expected)
    {
        // arrange
        var timespan = TimeSpan.FromHours(value);

        // act
        var actual = TimeSpanRounder.TruncateHours(timespan).TotalHours;

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(null, null)]
    [InlineData(1.5, 1)]
    [InlineData(1, 1)]
    [InlineData(-1.5, -1)]
    public void NullableTruncateHoursReturnsExpectedResults(double? value, double? expected)
    {
        // arrange
        var timespan = TimeSpanFromHours(value);

        // act
        var actual = TimeSpanRounder.TruncateHours(timespan)?.TotalHours;

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(1.5, 1)]
    [InlineData(1, 1)]
    [InlineData(-1.5, -1)]
    public void TruncateDaysReturnsExpectedResults(double value, double expected)
    {
        // arrange
        var timespan = TimeSpan.FromDays(value);

        // act
        var actual = TimeSpanRounder.TruncateDays(timespan).TotalDays;

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(null, null)]
    [InlineData(1.5, 1)]
    [InlineData(1, 1)]
    [InlineData(-1.5, -1)]
    public void NullableTruncateDaysReturnsExpectedResults(double? value, double? expected)
    {
        // arrange
        var timespan = TimeSpanFromDays(value);

        // act
        var actual = TimeSpanRounder.TruncateDays(timespan)?.TotalDays;

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(-0.5, MidpointRounding.AwayFromZero, -1)]
    [InlineData(-1.5, MidpointRounding.AwayFromZero, -2)]
    [InlineData(0.5, MidpointRounding.AwayFromZero, 1)]
    [InlineData(1.5, MidpointRounding.AwayFromZero, 2)]
    [InlineData(-0.5, MidpointRounding.ToEven, 0)]
    [InlineData(-1.5, MidpointRounding.ToEven, -2)]
    [InlineData(0.5, MidpointRounding.ToEven, 0)]
    [InlineData(1.5, MidpointRounding.ToEven, 2)]
    public void NearestMicrosecondWithMidpointRoundingReturnsExpectedResults(double value, MidpointRounding midpointRounding, double expected)
    {
        // arrange
        var timespan = TimeSpan.FromMilliseconds(value / 1000d);

        // act
        var actual = TimeSpanRounder.NearestMicrosecond(timespan, midpointRounding).TotalMilliseconds * 1000d;

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(null, MidpointRounding.AwayFromZero, null)]
    [InlineData(null, MidpointRounding.ToEven, null)]
    [InlineData(-0.5, MidpointRounding.AwayFromZero, -1)]
    [InlineData(-1.5, MidpointRounding.AwayFromZero, -2)]
    [InlineData(0.5, MidpointRounding.AwayFromZero, 1)]
    [InlineData(1.5, MidpointRounding.AwayFromZero, 2)]
    [InlineData(-0.5, MidpointRounding.ToEven, 0)]
    [InlineData(-1.5, MidpointRounding.ToEven, -2)]
    [InlineData(0.5, MidpointRounding.ToEven, 0)]
    [InlineData(1.5, MidpointRounding.ToEven, 2)]
    public void NullableNearestMicrosecondWithMidpointRoundingReturnsExpectedResults(double? value, MidpointRounding midpointRounding, double? expected)
    {
        // arrange
        var timespan = TimeSpanFromMilliseconds(value / 1000d);

        // act
        var actual = TimeSpanRounder.NearestMicrosecond(timespan, midpointRounding)?.TotalMilliseconds * 1000d;

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(-0.4, -0)]
    [InlineData(-0.6, -1)]
    [InlineData(0.4, 0)]
    [InlineData(0.6, 1)]
    public void NearestMillisecondReturnsExpectedResults(double value, double expected)
    {
        // arrange
        var timespan = TimeSpan.FromMilliseconds(value);

        // act
        var actual = TimeSpanRounder.NearestMillisecond(timespan).TotalMilliseconds;

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(null, null)]
    [InlineData(-0.4, -0)]
    [InlineData(-0.6, -1)]
    [InlineData(0.4, 0)]
    [InlineData(0.6, 1)]
    public void NullableNearestMillisecondReturnsExpectedResults(double? value, double? expected)
    {
        // arrange
        var timespan = TimeSpanFromMilliseconds(value);

        // act
        var actual = TimeSpanRounder.NearestMillisecond(timespan)?.TotalMilliseconds;

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(-0.5, MidpointRounding.AwayFromZero, -1)]
    [InlineData(-1.5, MidpointRounding.AwayFromZero, -2)]
    [InlineData(0.5, MidpointRounding.AwayFromZero, 1)]
    [InlineData(1.5, MidpointRounding.AwayFromZero, 2)]
    [InlineData(-0.5, MidpointRounding.ToEven, 0)]
    [InlineData(-1.5, MidpointRounding.ToEven, -2)]
    [InlineData(0.5, MidpointRounding.ToEven, 0)]
    [InlineData(1.5, MidpointRounding.ToEven, 2)]
    public void NearestMillisecondWithMidpointRoundingReturnsExpectedResults(double value, MidpointRounding midpointRounding, double expected)
    {
        // arrange
        var timespan = TimeSpan.FromMilliseconds(value);

        // act
        var actual = TimeSpanRounder.NearestMillisecond(timespan, midpointRounding).TotalMilliseconds;

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(null, MidpointRounding.AwayFromZero, null)]
    [InlineData(null, MidpointRounding.ToEven, null)]
    [InlineData(-0.5, MidpointRounding.AwayFromZero, -1)]
    [InlineData(-1.5, MidpointRounding.AwayFromZero, -2)]
    [InlineData(0.5, MidpointRounding.AwayFromZero, 1)]
    [InlineData(1.5, MidpointRounding.AwayFromZero, 2)]
    [InlineData(-0.5, MidpointRounding.ToEven, 0)]
    [InlineData(-1.5, MidpointRounding.ToEven, -2)]
    [InlineData(0.5, MidpointRounding.ToEven, 0)]
    [InlineData(1.5, MidpointRounding.ToEven, 2)]
    public void NullableNearestMillisecondWithMidpointRoundingReturnsExpectedResults(double? value, MidpointRounding midpointRounding, double? expected)
    {
        // arrange
        var timespan = TimeSpanFromMilliseconds(value);

        // act
        var actual = TimeSpanRounder.NearestMillisecond(timespan, midpointRounding)?.TotalMilliseconds;

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(-0.4, 0)]
    [InlineData(-0.6, -1)]
    [InlineData(0.4, 0)]
    [InlineData(0.6, 1)]
    public void NearestSecondReturnsExpectedResults(double value, double expected)
    {
        // arrange
        var timespan = TimeSpan.FromSeconds(value);

        // act
        var actual = TimeSpanRounder.NearestSecond(timespan).TotalSeconds;

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(null, null)]
    [InlineData(-0.4, 0)]
    [InlineData(-0.6, -1)]
    [InlineData(0.4, 0)]
    [InlineData(0.6, 1)]
    public void NullableNearestSecondReturnsExpectedResults(double? value, double? expected)
    {
        // arrange
        var timespan = TimeSpanFromSeconds(value);

        // act
        var actual = TimeSpanRounder.NearestSecond(timespan)?.TotalSeconds;

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(-0.5, MidpointRounding.AwayFromZero, -1)]
    [InlineData(-1.5, MidpointRounding.AwayFromZero, -2)]
    [InlineData(0.5, MidpointRounding.AwayFromZero, 1)]
    [InlineData(1.5, MidpointRounding.AwayFromZero, 2)]
    [InlineData(-0.5, MidpointRounding.ToEven, 0)]
    [InlineData(-1.5, MidpointRounding.ToEven, -2)]
    [InlineData(0.5, MidpointRounding.ToEven, 0)]
    [InlineData(1.5, MidpointRounding.ToEven, 2)]
    public void NearestSecondWithMidpointRoundingReturnsExpectedResults(double value, MidpointRounding midpointRounding, double expected)
    {
        // arrange
        var timespan = TimeSpan.FromSeconds(value);

        // act
        var actual = TimeSpanRounder.NearestSecond(timespan, midpointRounding).TotalSeconds;

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(null, MidpointRounding.AwayFromZero, null)]
    [InlineData(null, MidpointRounding.ToEven, null)]
    [InlineData(-0.5, MidpointRounding.AwayFromZero, -1)]
    [InlineData(-1.5, MidpointRounding.AwayFromZero, -2)]
    [InlineData(0.5, MidpointRounding.AwayFromZero, 1)]
    [InlineData(1.5, MidpointRounding.AwayFromZero, 2)]
    [InlineData(-0.5, MidpointRounding.ToEven, 0)]
    [InlineData(-1.5, MidpointRounding.ToEven, -2)]
    [InlineData(0.5, MidpointRounding.ToEven, 0)]
    [InlineData(1.5, MidpointRounding.ToEven, 2)]
    public void NullableNearestSecondWithMidpointRoundingReturnsExpectedResults(double? value, MidpointRounding midpointRounding, double? expected)
    {
        // arrange
        var timespan = TimeSpanFromSeconds(value);

        // act
        var actual = TimeSpanRounder.NearestSecond(timespan, midpointRounding)?.TotalSeconds;

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(-0.4, 0)]
    [InlineData(-0.6, -1)]
    [InlineData(0.4, 0)]
    [InlineData(0.6, 1)]
    public void NearestMinuteReturnsExpectedResults(double value, double expected)
    {
        // arrange
        var timespan = TimeSpan.FromMinutes(value);

        // act
        var actual = TimeSpanRounder.NearestMinute(timespan).TotalMinutes;

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(null, null)]
    [InlineData(-0.4, 0)]
    [InlineData(-0.6, -1)]
    [InlineData(0.4, 0)]
    [InlineData(0.6, 1)]
    public void NullableNearestMinuteReturnsExpectedResults(double? value, double? expected)
    {
        // arrange
        var timespan = TimeSpanFromMinutes(value);

        // act
        var actual = TimeSpanRounder.NearestMinute(timespan)?.TotalMinutes;

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(-0.5, MidpointRounding.AwayFromZero, -1)]
    [InlineData(-1.5, MidpointRounding.AwayFromZero, -2)]
    [InlineData(0.5, MidpointRounding.AwayFromZero, 1)]
    [InlineData(1.5, MidpointRounding.AwayFromZero, 2)]
    [InlineData(-0.5, MidpointRounding.ToEven, 0)]
    [InlineData(-1.5, MidpointRounding.ToEven, -2)]
    [InlineData(0.5, MidpointRounding.ToEven, 0)]
    [InlineData(1.5, MidpointRounding.ToEven, 2)]
    public void NearestMinuteWithMidpointRoundingReturnsExpectedResults(double value, MidpointRounding midpointRounding, double expected)
    {
        // arrange
        var timespan = TimeSpan.FromMinutes(value);

        // act
        var actual = TimeSpanRounder.NearestMinute(timespan, midpointRounding).TotalMinutes;

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(null, MidpointRounding.AwayFromZero, null)]
    [InlineData(null, MidpointRounding.ToEven, null)]
    [InlineData(-0.5, MidpointRounding.AwayFromZero, -1)]
    [InlineData(-1.5, MidpointRounding.AwayFromZero, -2)]
    [InlineData(0.5, MidpointRounding.AwayFromZero, 1)]
    [InlineData(1.5, MidpointRounding.AwayFromZero, 2)]
    [InlineData(-0.5, MidpointRounding.ToEven, 0)]
    [InlineData(-1.5, MidpointRounding.ToEven, -2)]
    [InlineData(0.5, MidpointRounding.ToEven, 0)]
    [InlineData(1.5, MidpointRounding.ToEven, 2)]
    public void NullableNearestMinuteWithMidpointRoundingReturnsExpectedResults(double? value, MidpointRounding midpointRounding, double? expected)
    {
        // arrange
        var timespan = TimeSpanFromMinutes(value);

        // act
        var actual = TimeSpanRounder.NearestMinute(timespan, midpointRounding)?.TotalMinutes;

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(-0.4, 0)]
    [InlineData(-0.6, -1)]
    [InlineData(0.4, 0)]
    [InlineData(0.6, 1)]
    public void NearestHourReturnsExpectedResults(double value, double expected)
    {
        // arrange
        var timespan = TimeSpan.FromHours(value);

        // act
        var actual = TimeSpanRounder.NearestHour(timespan).TotalHours;

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(null, null)]
    [InlineData(-0.4, 0)]
    [InlineData(-0.6, -1)]
    [InlineData(0.4, 0)]
    [InlineData(0.6, 1)]
    public void NullableNearestHourReturnsExpectedResults(double? value, double? expected)
    {
        // arrange
        var timespan = TimeSpanFromHours(value);

        // act
        var actual = TimeSpanRounder.NearestHour(timespan)?.TotalHours;

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(-0.5, MidpointRounding.AwayFromZero, -1)]
    [InlineData(-1.5, MidpointRounding.AwayFromZero, -2)]
    [InlineData(0.5, MidpointRounding.AwayFromZero, 1)]
    [InlineData(1.5, MidpointRounding.AwayFromZero, 2)]
    [InlineData(-0.5, MidpointRounding.ToEven, 0)]
    [InlineData(-1.5, MidpointRounding.ToEven, -2)]
    [InlineData(0.5, MidpointRounding.ToEven, 0)]
    [InlineData(1.5, MidpointRounding.ToEven, 2)]
    public void NearestHourWithMidpointRoundingReturnsExpectedResults(double value, MidpointRounding midpointRounding, double expected)
    {
        // arrange
        var timespan = TimeSpan.FromHours(value);

        // act
        var actual = TimeSpanRounder.NearestHour(timespan, midpointRounding).TotalHours;

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(null, MidpointRounding.AwayFromZero, null)]
    [InlineData(null, MidpointRounding.ToEven, null)]
    [InlineData(-0.5, MidpointRounding.AwayFromZero, -1)]
    [InlineData(-1.5, MidpointRounding.AwayFromZero, -2)]
    [InlineData(0.5, MidpointRounding.AwayFromZero, 1)]
    [InlineData(1.5, MidpointRounding.AwayFromZero, 2)]
    [InlineData(-0.5, MidpointRounding.ToEven, 0)]
    [InlineData(-1.5, MidpointRounding.ToEven, -2)]
    [InlineData(0.5, MidpointRounding.ToEven, 0)]
    [InlineData(1.5, MidpointRounding.ToEven, 2)]
    public void NullableNearestHourWithMidpointRoundingReturnsExpectedResults(double? value, MidpointRounding midpointRounding, double? expected)
    {
        // arrange
        var timespan = TimeSpanFromHours(value);

        // act
        var actual = TimeSpanRounder.NearestHour(timespan, midpointRounding)?.TotalHours;

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(-0.4, 0)]
    [InlineData(-0.6, -1)]
    [InlineData(0.4, 0)]
    [InlineData(0.6, 1)]
    public void NearestDayReturnsExpectedResults(double value, double expected)
    {
        // arrange
        var timespan = TimeSpan.FromDays(value);

        // act
        var actual = TimeSpanRounder.NearestDay(timespan).TotalDays;

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(null, null)]
    [InlineData(-0.4, 0)]
    [InlineData(-0.6, -1)]
    [InlineData(0.4, 0)]
    [InlineData(0.6, 1)]
    public void NullableNearestDayReturnsExpectedResults(double? value, double? expected)
    {
        // arrange
        var timespan = TimeSpanFromDays(value);

        // act
        var actual = TimeSpanRounder.NearestDay(timespan)?.TotalDays;

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(-0.5, MidpointRounding.AwayFromZero, -1)]
    [InlineData(-1.5, MidpointRounding.AwayFromZero, -2)]
    [InlineData(0.5, MidpointRounding.AwayFromZero, 1)]
    [InlineData(1.5, MidpointRounding.AwayFromZero, 2)]
    [InlineData(-0.5, MidpointRounding.ToEven, 0)]
    [InlineData(-1.5, MidpointRounding.ToEven, -2)]
    [InlineData(0.5, MidpointRounding.ToEven, 0)]
    [InlineData(1.5, MidpointRounding.ToEven, 2)]
    public void NearestDayWithMidpointRoundingReturnsExpectedResults(double value, MidpointRounding midpointRounding, double expected)
    {
        // arrange
        var timespan = TimeSpan.FromDays(value);

        // act
        var actual = TimeSpanRounder.NearestDay(timespan, midpointRounding).TotalDays;

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(null, MidpointRounding.AwayFromZero, null)]
    [InlineData(null, MidpointRounding.ToEven, null)]
    [InlineData(-0.5, MidpointRounding.AwayFromZero, -1)]
    [InlineData(-1.5, MidpointRounding.AwayFromZero, -2)]
    [InlineData(0.5, MidpointRounding.AwayFromZero, 1)]
    [InlineData(1.5, MidpointRounding.AwayFromZero, 2)]
    [InlineData(-0.5, MidpointRounding.ToEven, 0)]
    [InlineData(-1.5, MidpointRounding.ToEven, -2)]
    [InlineData(0.5, MidpointRounding.ToEven, 0)]
    [InlineData(1.5, MidpointRounding.ToEven, 2)]
    public void NullableNearestDayWithMidpointRoundingReturnsExpectedResults(double? value, MidpointRounding midpointRounding, double? expected)
    {
        // arrange
        var timespan = TimeSpanFromDays(value);

        // act
        var actual = TimeSpanRounder.NearestDay(timespan, midpointRounding)?.TotalDays;

        // assert
        Assert.Equal(expected, actual);
    }

    private TimeSpan? TimeSpanFromDays(double? value) => value.HasValue ? TimeSpan.FromDays(value.Value) : null;

    private TimeSpan? TimeSpanFromHours(double? value) => value.HasValue ? TimeSpan.FromHours(value.Value) : null;

    private TimeSpan? TimeSpanFromMinutes(double? value) => value.HasValue ? TimeSpan.FromMinutes(value.Value) : null;

    private TimeSpan? TimeSpanFromSeconds(double? value) => value.HasValue ? TimeSpan.FromSeconds(value.Value) : null;

    private TimeSpan? TimeSpanFromMilliseconds(double? value) => value.HasValue ? TimeSpan.FromMilliseconds(value.Value) : null;
}
