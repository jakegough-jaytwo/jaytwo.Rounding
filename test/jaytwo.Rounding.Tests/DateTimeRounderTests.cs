using Xunit;

namespace jaytwo.Rounding.Tests;

public class DateTimeRounderTests
{
    [Theory]
    [InlineData("2023-01-01 00:00:00.0121", "2023-01-01 00:00:00.012")]
    [InlineData("2023-01-01 00:00:00.0130", "2023-01-01 00:00:00.013")]
    [InlineData("2023-01-01 00:00:00.0139", "2023-01-01 00:00:00.013")]
    public void FloorMillisecondsReturnsExpectedResults(string inputStr, string expectedStr)
    {
        // arrange
        var input = DateTime.Parse(inputStr);
        var expected = DateTime.Parse(expectedStr);

        // act
        var actual = DateTimeRounder.FloorMilliseconds(input);

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(null, null)]
    [InlineData("2023-01-01 00:00:00.0121", "2023-01-01 00:00:00.012")]
    [InlineData("2023-01-01 00:00:00.0130", "2023-01-01 00:00:00.013")]
    [InlineData("2023-01-01 00:00:00.0139", "2023-01-01 00:00:00.013")]
    public void NullableFloorMillisecondsReturnsExpectedResults(string? inputStr, string? expectedStr)
    {
        // arrange
        var input = NullableDateTimeParse(inputStr);
        var expected = NullableDateTimeParse(expectedStr);

        // act
        var actual = DateTimeRounder.FloorMilliseconds(input);

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("2023-01-01 00:00:12.1", "2023-01-01 00:00:12.0")]
    [InlineData("2023-01-01 00:00:13.0", "2023-01-01 00:00:13.0")]
    [InlineData("2023-01-01 00:00:13.9", "2023-01-01 00:00:13.0")]
    public void FloorSecondsReturnsExpectedResults(string inputStr, string expectedStr)
    {
        // arrange
        var input = DateTime.Parse(inputStr);
        var expected = DateTime.Parse(expectedStr);

        // act
        var actual = DateTimeRounder.FloorSeconds(input);

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(null, null)]
    [InlineData("2023-01-01 00:00:12.1", "2023-01-01 00:00:12.0")]
    [InlineData("2023-01-01 00:00:13.0", "2023-01-01 00:00:13.0")]
    [InlineData("2023-01-01 00:00:13.9", "2023-01-01 00:00:13.0")]
    public void NullableFloorSecondsReturnsExpectedResults(string? inputStr, string? expectedStr)
    {
        // arrange
        var input = NullableDateTimeParse(inputStr);
        var expected = NullableDateTimeParse(expectedStr);

        // act
        var actual = DateTimeRounder.FloorSeconds(input);

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("2023-01-01 00:12:01", "2023-01-01 00:12:00")]
    [InlineData("2023-01-01 00:13:00", "2023-01-01 00:13:00")]
    [InlineData("2023-01-01 00:13:59", "2023-01-01 00:13:00")]
    public void FloorMinutesReturnsExpectedResults(string inputStr, string expectedStr)
    {
        // arrange
        var input = DateTime.Parse(inputStr);
        var expected = DateTime.Parse(expectedStr);

        // act
        var actual = DateTimeRounder.FloorMinutes(input);

        // assert
        Assert.Equal(actual, actual);
    }

    [Theory]
    [InlineData(null, null)]
    [InlineData("2023-01-01 00:12:01", "2023-01-01 00:12:00")]
    [InlineData("2023-01-01 00:13:00", "2023-01-01 00:13:00")]
    [InlineData("2023-01-01 00:13:59", "2023-01-01 00:13:00")]
    public void NullableFloorMinutesReturnsExpectedResults(string? inputStr, string? expectedStr)
    {
        // arrange
        var input = NullableDateTimeParse(inputStr);
        var expected = NullableDateTimeParse(expectedStr);

        // act
        var actual = DateTimeRounder.FloorMinutes(input);

        // assert
        Assert.Equal(actual, actual);
    }

    [Theory]
    [InlineData("2023-01-01 12:00:01", "2023-01-01 12:00:00")]
    [InlineData("2023-01-01 13:00:00", "2023-01-01 13:00:00")]
    [InlineData("2023-01-01 13:59:59", "2023-01-01 13:00:00")]
    public void FloorHoursReturnsExpectedResults(string inputStr, string expectedStr)
    {
        // arrange
        var input = DateTime.Parse(inputStr);
        var expected = DateTime.Parse(expectedStr);

        // act
        var actual = DateTimeRounder.FloorHours(input);

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(null, null)]
    [InlineData("2023-01-01 12:00:01", "2023-01-01 12:00:00")]
    [InlineData("2023-01-01 13:00:00", "2023-01-01 13:00:00")]
    [InlineData("2023-01-01 13:59:59", "2023-01-01 13:00:00")]
    public void NullableFloorHoursReturnsExpectedResults(string? inputStr, string? expectedStr)
    {
        // arrange
        var input = NullableDateTimeParse(inputStr);
        var expected = NullableDateTimeParse(expectedStr);

        // act
        var actual = DateTimeRounder.FloorHours(input);

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("2023-01-01 00:00:00", "2023-01-01 00:00:00")]
    [InlineData("2023-01-01 00:00:01", "2023-01-01 00:00:00")]
    [InlineData("2023-01-01 23:59:59", "2023-01-01 00:00:00")]
    public void FloorDaysReturnsExpectedResults(string inputStr, string expectedStr)
    {
        // arrange
        var input = DateTime.Parse(inputStr);
        var expected = DateTime.Parse(expectedStr);

        // act
        var actual = DateTimeRounder.FloorDays(input);

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(null, null)]
    [InlineData("2023-01-01 00:00:00", "2023-01-01 00:00:00")]
    [InlineData("2023-01-01 00:00:01", "2023-01-01 00:00:00")]
    [InlineData("2023-01-01 23:59:59", "2023-01-01 00:00:00")]
    public void NullableFloorDaysReturnsExpectedResults(string? inputStr, string? expectedStr)
    {
        // arrange
        var input = NullableDateTimeParse(inputStr);
        var expected = NullableDateTimeParse(expectedStr);

        // act
        var actual = DateTimeRounder.FloorDays(input);

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("2023-01-01 00:00:00.0121", "2023-01-01 00:00:00.013")]
    [InlineData("2023-01-01 00:00:00.0130", "2023-01-01 00:00:00.013")]
    [InlineData("2023-01-01 00:00:00.0139", "2023-01-01 00:00:00.014")]
    public void CeilingMillisecondsReturnsExpectedResults(string inputStr, string expectedStr)
    {
        // arrange
        var input = DateTime.Parse(inputStr);
        var expected = DateTime.Parse(expectedStr);

        // act
        var actual = DateTimeRounder.CeilingMilliseconds(input);

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(null, null)]
    [InlineData("2023-01-01 00:00:00.0121", "2023-01-01 00:00:00.013")]
    [InlineData("2023-01-01 00:00:00.0130", "2023-01-01 00:00:00.013")]
    [InlineData("2023-01-01 00:00:00.0139", "2023-01-01 00:00:00.014")]
    public void NullableCeilingMillisecondsReturnsExpectedResults(string? inputStr, string? expectedStr)
    {
        // arrange
        var input = NullableDateTimeParse(inputStr);
        var expected = NullableDateTimeParse(expectedStr);

        // act
        var actual = DateTimeRounder.CeilingMilliseconds(input);

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("2023-01-01 00:00:12.1", "2023-01-01 00:00:13.0")]
    [InlineData("2023-01-01 00:00:13.0", "2023-01-01 00:00:13.0")]
    [InlineData("2023-01-01 00:00:13.9", "2023-01-01 00:00:14.0")]
    public void CeilingSecondsReturnsExpectedResults(string inputStr, string expectedStr)
    {
        // arrange
        var input = DateTime.Parse(inputStr);
        var expected = DateTime.Parse(expectedStr);

        // act
        var actual = DateTimeRounder.CeilingSeconds(input);

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(null, null)]
    [InlineData("2023-01-01 00:00:12.1", "2023-01-01 00:00:13.0")]
    [InlineData("2023-01-01 00:00:13.0", "2023-01-01 00:00:13.0")]
    [InlineData("2023-01-01 00:00:13.9", "2023-01-01 00:00:14.0")]
    public void NullableCeilingSecondsReturnsExpectedResults(string? inputStr, string? expectedStr)
    {
        // arrange
        var input = NullableDateTimeParse(inputStr);
        var expected = NullableDateTimeParse(expectedStr);

        // act
        var actual = DateTimeRounder.CeilingSeconds(input);

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("2023-01-01 00:12:01", "2023-01-01 00:13:00")]
    [InlineData("2023-01-01 00:13:00", "2023-01-01 00:13:00")]
    [InlineData("2023-01-01 00:13:59", "2023-01-01 00:14:00")]
    public void CeilingMinutesReturnsExpectedResults(string inputStr, string expectedStr)
    {
        // arrange
        var input = DateTime.Parse(inputStr);
        var expected = DateTime.Parse(expectedStr);

        // act
        var actual = DateTimeRounder.CeilingMinutes(input);

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(null, null)]
    [InlineData("2023-01-01 00:12:01", "2023-01-01 00:13:00")]
    [InlineData("2023-01-01 00:13:00", "2023-01-01 00:13:00")]
    [InlineData("2023-01-01 00:13:59", "2023-01-01 00:14:00")]
    public void NullableCeilingMinutesReturnsExpectedResults(string? inputStr, string? expectedStr)
    {
        // arrange
        var input = NullableDateTimeParse(inputStr);
        var expected = NullableDateTimeParse(expectedStr);

        // act
        var actual = DateTimeRounder.CeilingMinutes(input);

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("2023-01-01 12:00:01", "2023-01-01 13:00:00")]
    [InlineData("2023-01-01 13:00:00", "2023-01-01 13:00:00")]
    [InlineData("2023-01-01 13:59:59", "2023-01-01 14:00:00")]
    public void CeilingHoursReturnsExpectedResults(string inputStr, string expectedStr)
    {
        // arrange
        var input = DateTime.Parse(inputStr);
        var expected = DateTime.Parse(expectedStr);

        // act
        var actual = DateTimeRounder.CeilingHours(input);

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(null, null)]
    [InlineData("2023-01-01 12:00:01", "2023-01-01 13:00:00")]
    [InlineData("2023-01-01 13:00:00", "2023-01-01 13:00:00")]
    [InlineData("2023-01-01 13:59:59", "2023-01-01 14:00:00")]
    public void NullableCeilingHoursReturnsExpectedResults(string? inputStr, string? expectedStr)
    {
        // arrange
        var input = NullableDateTimeParse(inputStr);
        var expected = NullableDateTimeParse(expectedStr);

        // act
        var actual = DateTimeRounder.CeilingHours(input);

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("2023-01-01 00:00:00", "2023-01-01 00:00:00")]
    [InlineData("2023-01-01 00:00:01", "2023-01-02 00:00:00")]
    [InlineData("2023-01-01 23:59:59", "2023-01-02 00:00:00")]
    public void CeilingDaysReturnsExpectedResults(string inputStr, string expectedStr)
    {
        // arrange
        var input = DateTime.Parse(inputStr);
        var expected = DateTime.Parse(expectedStr);

        // act
        var actual = DateTimeRounder.CeilingDays(input);

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(null, null)]
    [InlineData("2023-01-01 00:00:00", "2023-01-01 00:00:00")]
    [InlineData("2023-01-01 00:00:01", "2023-01-02 00:00:00")]
    [InlineData("2023-01-01 23:59:59", "2023-01-02 00:00:00")]
    public void NullableCeilingDaysReturnsExpectedResults(string? inputStr, string? expectedStr)
    {
        // arrange
        var input = NullableDateTimeParse(inputStr);
        var expected = NullableDateTimeParse(expectedStr);

        // act
        var actual = DateTimeRounder.CeilingDays(input);

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("2023-01-01 00:00:00.0121", "2023-01-01 00:00:00.012")]
    [InlineData("2023-01-01 00:00:00.0130", "2023-01-01 00:00:00.013")]
    [InlineData("2023-01-01 00:00:00.0139", "2023-01-01 00:00:00.013")]
    public void TruncateMillisecondsReturnsExpectedResults(string inputStr, string expectedStr)
    {
        // arrange
        var input = DateTime.Parse(inputStr);
        var expected = DateTime.Parse(expectedStr);

        // act
        var actual = DateTimeRounder.TruncateMilliseconds(input);

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(null, null)]
    [InlineData("2023-01-01 00:00:00.0121", "2023-01-01 00:00:00.012")]
    [InlineData("2023-01-01 00:00:00.0130", "2023-01-01 00:00:00.013")]
    [InlineData("2023-01-01 00:00:00.0139", "2023-01-01 00:00:00.013")]
    public void NullableTruncateMillisecondsReturnsExpectedResults(string? inputStr, string? expectedStr)
    {
        // arrange
        var input = NullableDateTimeParse(inputStr);
        var expected = NullableDateTimeParse(expectedStr);

        // act
        var actual = DateTimeRounder.TruncateMilliseconds(input);

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("2023-01-01 00:00:12.1", "2023-01-01 00:00:12.0")]
    [InlineData("2023-01-01 00:00:13.0", "2023-01-01 00:00:13.0")]
    [InlineData("2023-01-01 00:00:13.9", "2023-01-01 00:00:13.0")]
    public void TruncateSecondsReturnsExpectedResults(string inputStr, string expectedStr)
    {
        // arrange
        var input = DateTime.Parse(inputStr);
        var expected = DateTime.Parse(expectedStr);

        // act
        var actual = DateTimeRounder.TruncateSeconds(input);

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(null, null)]
    [InlineData("2023-01-01 00:00:12.1", "2023-01-01 00:00:12.0")]
    [InlineData("2023-01-01 00:00:13.0", "2023-01-01 00:00:13.0")]
    [InlineData("2023-01-01 00:00:13.9", "2023-01-01 00:00:13.0")]
    public void NullableTruncateSecondsReturnsExpectedResults(string? inputStr, string? expectedStr)
    {
        // arrange
        var input = NullableDateTimeParse(inputStr);
        var expected = NullableDateTimeParse(expectedStr);

        // act
        var actual = DateTimeRounder.TruncateSeconds(input);

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("2023-01-01 00:12:01", "2023-01-01 00:12:00")]
    [InlineData("2023-01-01 00:13:00", "2023-01-01 00:13:00")]
    [InlineData("2023-01-01 00:13:59", "2023-01-01 00:13:00")]
    public void TruncateMinutesReturnsExpectedResults(string inputStr, string expectedStr)
    {
        // arrange
        var input = DateTime.Parse(inputStr);
        var expected = DateTime.Parse(expectedStr);

        // act
        var actual = DateTimeRounder.TruncateMinutes(input);

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(null, null)]
    [InlineData("2023-01-01 00:12:01", "2023-01-01 00:12:00")]
    [InlineData("2023-01-01 00:13:00", "2023-01-01 00:13:00")]
    [InlineData("2023-01-01 00:13:59", "2023-01-01 00:13:00")]
    public void NullableTruncateMinutesReturnsExpectedResults(string? inputStr, string? expectedStr)
    {
        // arrange
        var input = NullableDateTimeParse(inputStr);
        var expected = NullableDateTimeParse(expectedStr);

        // act
        var actual = DateTimeRounder.TruncateMinutes(input);

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("2023-01-01 12:00:01", "2023-01-01 12:00:00")]
    [InlineData("2023-01-01 13:00:00", "2023-01-01 13:00:00")]
    [InlineData("2023-01-01 13:59:59", "2023-01-01 13:00:00")]
    public void TruncateHoursReturnsExpectedResults(string inputStr, string expectedStr)
    {
        // arrange
        var input = DateTime.Parse(inputStr);
        var expected = DateTime.Parse(expectedStr);

        // act
        var actual = DateTimeRounder.TruncateHours(input);

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(null, null)]
    [InlineData("2023-01-01 12:00:01", "2023-01-01 12:00:00")]
    [InlineData("2023-01-01 13:00:00", "2023-01-01 13:00:00")]
    [InlineData("2023-01-01 13:59:59", "2023-01-01 13:00:00")]
    public void NullableTruncateHoursReturnsExpectedResults(string? inputStr, string? expectedStr)
    {
        // arrange
        var input = NullableDateTimeParse(inputStr);
        var expected = NullableDateTimeParse(expectedStr);

        // act
        var actual = DateTimeRounder.TruncateHours(input);

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("2023-01-01 00:00:00", "2023-01-01 00:00:00")]
    [InlineData("2023-01-01 00:00:01", "2023-01-01 00:00:00")]
    [InlineData("2023-01-01 23:59:59", "2023-01-01 00:00:00")]
    public void TruncateDaysReturnsExpectedResults(string inputStr, string expectedStr)
    {
        // arrange
        var input = DateTime.Parse(inputStr);
        var expected = DateTime.Parse(expectedStr);

        // act
        var actual = DateTimeRounder.TruncateDays(input);

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(null, null)]
    [InlineData("2023-01-01 00:00:00", "2023-01-01 00:00:00")]
    [InlineData("2023-01-01 00:00:01", "2023-01-01 00:00:00")]
    [InlineData("2023-01-01 23:59:59", "2023-01-01 00:00:00")]
    public void NullableTruncateDaysReturnsExpectedResults(string? inputStr, string? expectedStr)
    {
        // arrange
        var input = NullableDateTimeParse(inputStr);
        var expected = NullableDateTimeParse(expectedStr);

        // act
        var actual = DateTimeRounder.TruncateDays(input);

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("2023-01-01 00:00:00.0000125", "2023-01-01 00:00:00.000012")]
    [InlineData("2023-01-01 00:00:00.0000130", "2023-01-01 00:00:00.000013")]
    [InlineData("2023-01-01 00:00:00.0000135", "2023-01-01 00:00:00.000014")]
    public void NearestMicrosecondReturnsExpectedResults(string inputStr, string expectedStr)
    {
        // arrange
        var input = DateTime.Parse(inputStr);
        var expected = DateTime.Parse(expectedStr);

        // act
        var actual = DateTimeRounder.NearestMicrosecond(input);

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(null, null)]
    [InlineData("2023-01-01 00:00:00.0000125", "2023-01-01 00:00:00.000012")]
    [InlineData("2023-01-01 00:00:00.0000130", "2023-01-01 00:00:00.000013")]
    [InlineData("2023-01-01 00:00:00.0000135", "2023-01-01 00:00:00.000014")]
    public void NullableNearestMicrosecondReturnsExpectedResults(string? inputStr, string? expectedStr)
    {
        // arrange
        var input = NullableDateTimeParse(inputStr);
        var expected = NullableDateTimeParse(expectedStr);

        // act
        var actual = DateTimeRounder.NearestMicrosecond(input);

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("2023-01-01 00:00:00.0000125", MidpointRounding.AwayFromZero, "2023-01-01 00:00:00.000013")]
    [InlineData("2023-01-01 00:00:00.0000130", MidpointRounding.AwayFromZero, "2023-01-01 00:00:00.000013")]
    [InlineData("2023-01-01 00:00:00.0000135", MidpointRounding.AwayFromZero, "2023-01-01 00:00:00.000014")]
    [InlineData("2023-01-01 00:00:00.0000125", MidpointRounding.ToEven, "2023-01-01 00:00:00.000012")]
    [InlineData("2023-01-01 00:00:00.0000130", MidpointRounding.ToEven, "2023-01-01 00:00:00.000013")]
    [InlineData("2023-01-01 00:00:00.0000135", MidpointRounding.ToEven, "2023-01-01 00:00:00.000014")]
    public void NearestMicrosecondWithMidpointRoundingReturnsExpectedResults(string inputStr, MidpointRounding midpointRounding, string expectedStr)
    {
        // arrange
        var input = DateTime.Parse(inputStr);
        var expected = DateTime.Parse(expectedStr);

        // act
        var actual = DateTimeRounder.NearestMicrosecond(input, midpointRounding);

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(null, MidpointRounding.AwayFromZero, null)]
    [InlineData(null, MidpointRounding.ToEven, null)]
    [InlineData("2023-01-01 00:00:00.0000125", MidpointRounding.AwayFromZero, "2023-01-01 00:00:00.000013")]
    [InlineData("2023-01-01 00:00:00.0000130", MidpointRounding.AwayFromZero, "2023-01-01 00:00:00.000013")]
    [InlineData("2023-01-01 00:00:00.0000135", MidpointRounding.AwayFromZero, "2023-01-01 00:00:00.000014")]
    [InlineData("2023-01-01 00:00:00.0000125", MidpointRounding.ToEven, "2023-01-01 00:00:00.000012")]
    [InlineData("2023-01-01 00:00:00.0000130", MidpointRounding.ToEven, "2023-01-01 00:00:00.000013")]
    [InlineData("2023-01-01 00:00:00.0000135", MidpointRounding.ToEven, "2023-01-01 00:00:00.000014")]
    public void NullableNearestMicrosecondWithMidpointRoundingReturnsExpectedResults(string? inputStr, MidpointRounding midpointRounding, string? expectedStr)
    {
        // arrange
        var input = NullableDateTimeParse(inputStr);
        var expected = NullableDateTimeParse(expectedStr);

        // act
        var actual = DateTimeRounder.NearestMicrosecond(input, midpointRounding);

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("2023-01-01 00:00:00.0125", "2023-01-01 00:00:00.012")]
    [InlineData("2023-01-01 00:00:00.0130", "2023-01-01 00:00:00.013")]
    [InlineData("2023-01-01 00:00:00.0135", "2023-01-01 00:00:00.014")]
    public void NearestMillisecondReturnsExpectedResults(string inputStr, string expectedStr)
    {
        // arrange
        var input = DateTime.Parse(inputStr);
        var expected = DateTime.Parse(expectedStr);

        // act
        var actual = DateTimeRounder.NearestMillisecond(input);

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(null, null)]
    [InlineData("2023-01-01 00:00:00.0125", "2023-01-01 00:00:00.012")]
    [InlineData("2023-01-01 00:00:00.0130", "2023-01-01 00:00:00.013")]
    [InlineData("2023-01-01 00:00:00.0135", "2023-01-01 00:00:00.014")]
    public void NullableNearestMillisecondReturnsExpectedResults(string? inputStr, string? expectedStr)
    {
        // arrange
        var input = NullableDateTimeParse(inputStr);
        var expected = NullableDateTimeParse(expectedStr);

        // act
        var actual = DateTimeRounder.NearestMillisecond(input);

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("2023-01-01 00:00:00.0125", MidpointRounding.AwayFromZero, "2023-01-01 00:00:00.013")]
    [InlineData("2023-01-01 00:00:00.0130", MidpointRounding.AwayFromZero, "2023-01-01 00:00:00.013")]
    [InlineData("2023-01-01 00:00:00.0135", MidpointRounding.AwayFromZero, "2023-01-01 00:00:00.014")]
    [InlineData("2023-01-01 00:00:00.0125", MidpointRounding.ToEven, "2023-01-01 00:00:00.012")]
    [InlineData("2023-01-01 00:00:00.0130", MidpointRounding.ToEven, "2023-01-01 00:00:00.013")]
    [InlineData("2023-01-01 00:00:00.0135", MidpointRounding.ToEven, "2023-01-01 00:00:00.014")]
    public void NearestMillisecondWithMidpointRoundingReturnsExpectedResults(string inputStr, MidpointRounding midpointRounding, string expectedStr)
    {
        // arrange
        var input = DateTime.Parse(inputStr);
        var expected = DateTime.Parse(expectedStr);

        // act
        var actual = DateTimeRounder.NearestMillisecond(input, midpointRounding);

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(null, MidpointRounding.AwayFromZero, null)]
    [InlineData(null, MidpointRounding.ToEven, null)]
    [InlineData("2023-01-01 00:00:00.0125", MidpointRounding.AwayFromZero, "2023-01-01 00:00:00.013")]
    [InlineData("2023-01-01 00:00:00.0130", MidpointRounding.AwayFromZero, "2023-01-01 00:00:00.013")]
    [InlineData("2023-01-01 00:00:00.0135", MidpointRounding.AwayFromZero, "2023-01-01 00:00:00.014")]
    [InlineData("2023-01-01 00:00:00.0125", MidpointRounding.ToEven, "2023-01-01 00:00:00.012")]
    [InlineData("2023-01-01 00:00:00.0130", MidpointRounding.ToEven, "2023-01-01 00:00:00.013")]
    [InlineData("2023-01-01 00:00:00.0135", MidpointRounding.ToEven, "2023-01-01 00:00:00.014")]
    public void NullableNearestMillisecondWithMidpointRoundingReturnsExpectedResults(string? inputStr, MidpointRounding midpointRounding, string? expectedStr)
    {
        // arrange
        var input = NullableDateTimeParse(inputStr);
        var expected = NullableDateTimeParse(expectedStr);

        // act
        var actual = DateTimeRounder.NearestMillisecond(input, midpointRounding);

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("2023-01-01 00:00:12.5", "2023-01-01 00:00:12.0")]
    [InlineData("2023-01-01 00:00:13.0", "2023-01-01 00:00:13.0")]
    [InlineData("2023-01-01 00:00:13.5", "2023-01-01 00:00:14.0")]
    public void NearestSecondReturnsExpectedResults(string inputStr, string expectedStr)
    {
        // arrange
        var input = DateTime.Parse(inputStr);
        var expected = DateTime.Parse(expectedStr);

        // act
        var actual = DateTimeRounder.NearestSecond(input);

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(null, null)]
    [InlineData("2023-01-01 00:00:12.5", "2023-01-01 00:00:12.0")]
    [InlineData("2023-01-01 00:00:13.0", "2023-01-01 00:00:13.0")]
    [InlineData("2023-01-01 00:00:13.5", "2023-01-01 00:00:14.0")]
    public void NullableNearestSecondReturnsExpectedResults(string? inputStr, string? expectedStr)
    {
        // arrange
        var input = NullableDateTimeParse(inputStr);
        var expected = NullableDateTimeParse(expectedStr);

        // act
        var actual = DateTimeRounder.NearestSecond(input);

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("2023-01-01 00:00:12.5", MidpointRounding.AwayFromZero, "2023-01-01 00:00:13.0")]
    [InlineData("2023-01-01 00:00:13.0", MidpointRounding.AwayFromZero, "2023-01-01 00:00:13.0")]
    [InlineData("2023-01-01 00:00:13.5", MidpointRounding.AwayFromZero, "2023-01-01 00:00:14.0")]
    [InlineData("2023-01-01 00:00:12.5", MidpointRounding.ToEven, "2023-01-01 00:00:12.0")]
    [InlineData("2023-01-01 00:00:13.0", MidpointRounding.ToEven, "2023-01-01 00:00:13.0")]
    [InlineData("2023-01-01 00:00:13.5", MidpointRounding.ToEven, "2023-01-01 00:00:14.0")]
    public void NearestSecondWithMidpointRoundingReturnsExpectedResults(string inputStr, MidpointRounding midpointRounding, string expectedStr)
    {
        // arrange
        var input = DateTime.Parse(inputStr);
        var expected = DateTime.Parse(expectedStr);

        // act
        var actual = DateTimeRounder.NearestSecond(input, midpointRounding);

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(null, MidpointRounding.AwayFromZero, null)]
    [InlineData(null, MidpointRounding.ToEven, null)]
    [InlineData("2023-01-01 00:00:12.5", MidpointRounding.AwayFromZero, "2023-01-01 00:00:13.0")]
    [InlineData("2023-01-01 00:00:13.0", MidpointRounding.AwayFromZero, "2023-01-01 00:00:13.0")]
    [InlineData("2023-01-01 00:00:13.5", MidpointRounding.AwayFromZero, "2023-01-01 00:00:14.0")]
    [InlineData("2023-01-01 00:00:12.5", MidpointRounding.ToEven, "2023-01-01 00:00:12.0")]
    [InlineData("2023-01-01 00:00:13.0", MidpointRounding.ToEven, "2023-01-01 00:00:13.0")]
    [InlineData("2023-01-01 00:00:13.5", MidpointRounding.ToEven, "2023-01-01 00:00:14.0")]
    public void NullableNearestSecondWithMidpointRoundingReturnsExpectedResults(string? inputStr, MidpointRounding midpointRounding, string? expectedStr)
    {
        // arrange
        var input = NullableDateTimeParse(inputStr);
        var expected = NullableDateTimeParse(expectedStr);

        // act
        var actual = DateTimeRounder.NearestSecond(input, midpointRounding);

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(TimeSpanRounding.Minute)]
    [InlineData(TimeSpanRounding.Hour)]
    [InlineData(TimeSpanRounding.Day)]
    public void RoundShouldThrow(TimeSpanRounding precision)
    {
        // arrange
        var input = DateTime.MinValue;

        // act
        var ex = Assert.Throws<NotSupportedException>(() => DateTimeRounder.Round(DateTime.MinValue, precision, MidpointRounding.ToEven));

        // assert
        Assert.Contains(precision.ToString(), ex.Message);
    }

    private static DateTime? NullableDateTimeParse(string? value)
        => !string.IsNullOrEmpty(value) ? DateTime.Parse(value!) : default(DateTime?);
}
