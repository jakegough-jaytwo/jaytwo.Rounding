using System;
using System.Globalization;
using Xunit;

namespace jaytwo.Rounding.Tests.TimeQuantizerTests.DateTimeTests;

public class StartOfWeekTests : DateTimeQuantizeTests
{
    [Theory]
    [MemberData(nameof(StartOfWeekTestsCases))]
    public void StartOfWeek_Returns_Expected(string inputStr, DayOfWeek firstDayOfWeek, string expectedStr)
        => QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.StartOfWeek(x, firstDayOfWeek));

    [Theory]
    [InlineData(null, DayOfWeek.Sunday, null)]
    [MemberData(nameof(StartOfWeekTestsCases))]
    public void Nullable_StartOfWeek_Returns_Expected(string? inputStr, DayOfWeek firstDayOfWeek, string? expectedStr)
        => Nullable_QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.StartOfWeek(x, firstDayOfWeek));

    [Theory]
    [MemberData(nameof(StartOfWeekTestsCases))]
    public void Instance_StartOfWeek_Returns_Expected(string inputStr, DayOfWeek firstDayOfWeek, string expectedStr)
        => QuantizeTest(inputStr, expectedStr, x => new TimeQuantizer(default, firstDayOfWeek: firstDayOfWeek).StartOfWeek(x));

    [Theory]
    [InlineData(null, DayOfWeek.Sunday, null)]
    [MemberData(nameof(StartOfWeekTestsCases))]
    public void Nullable_Instance_StartOfWeek_Returns_Expected(string? inputStr, DayOfWeek firstDayOfWeek, string? expectedStr)
        => Nullable_QuantizeTest(inputStr, expectedStr, x => new TimeQuantizer(default, firstDayOfWeek: firstDayOfWeek).StartOfWeek(x));

    [Theory]
    [MemberData(nameof(StartOfWeekDateTimeKindTestsCases))]
    public void StartOfWeek_Returns_Expected_DateTimeKind(string inputStr, DateTimeKind kind, string expectedStr)
        => StartOfWeek_Returns_Expected_DateTimeKind_Test(inputStr, kind, expectedStr, x => TimeQuantizer.StartOfWeek(x, TimeQuantizer.DefaultFirstDayOfWeek));

    [Theory]
    [InlineData(null, DateTimeKind.Unspecified, null)]
    [MemberData(nameof(StartOfWeekDateTimeKindTestsCases))]
    public void Nullable_StartOfWeek_Returns_Expected_DateTimeKind(string? inputStr, DateTimeKind kind, string? expectedStr)
        => Nullable_StartOfWeek_Returns_Expected_DateTimeKind_Test(inputStr, kind, expectedStr, x => TimeQuantizer.StartOfWeek(x, TimeQuantizer.DefaultFirstDayOfWeek));

    [Theory]
    [MemberData(nameof(StartOfWeekDateTimeKindTestsCases))]
    public void Instance_StartOfWeek_Returns_Expected_DateTimeKind(string inputStr, DateTimeKind kind, string expectedStr)
        => StartOfWeek_Returns_Expected_DateTimeKind_Test(inputStr, kind, expectedStr, x => new TimeQuantizer(default).StartOfWeek(x));

    [Theory]
    [InlineData(null, DateTimeKind.Unspecified, null)]
    [MemberData(nameof(StartOfWeekDateTimeKindTestsCases))]
    public void Nullable_Instance_StartOfWeek_Returns_Expected_DateTimeKind(string? inputStr, DateTimeKind kind, string? expectedStr)
        => Nullable_StartOfWeek_Returns_Expected_DateTimeKind_Test(inputStr, kind, expectedStr, x => new TimeQuantizer(default).StartOfWeek(x));

    [Theory]
    [MemberData(nameof(CultureInfoStartOfWeekTestsCases))]
    public void StartOfWeek_CultureInfo_Returns_Expected(string inputStr, string culture, string expectedStr)
        => QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.StartOfWeek(x, CultureInfo.GetCultureInfo(culture)));

    [Theory]
    [InlineData(null, "en-US", null)]
    [MemberData(nameof(CultureInfoStartOfWeekTestsCases))]
    public void Nullable_StartOfWeek_CultureInfo_Returns_Expected(string? inputStr, string culture, string? expectedStr)
        => Nullable_QuantizeTest(inputStr, expectedStr, x => TimeQuantizer.StartOfWeek(x, CultureInfo.GetCultureInfo(culture)));

#if NET50_OR_GREATER
    [Theory]
    [MemberData(nameof(StartOfWeekTestsCases))]
    public void StartOfWeek_DateOnly_Returns_Expected(string inputStr, DayOfWeek firstDayOfWeek, string expectedStr)
        => QuantizeTest_DateOnly(inputStr, expectedStr, x => TimeQuantizer.StartOfWeek(x, firstDayOfWeek));

    [Theory]
    [InlineData(null, DayOfWeek.Sunday, null)]
    [MemberData(nameof(StartOfWeekTestsCases))]
    public void Nullable_StartOfWeek_DateOnly_Returns_Expected(string? inputStr, DayOfWeek firstDayOfWeek, string? expectedStr)
        => Nullable_QuantizeTest_DateOnly(inputStr, expectedStr, x => TimeQuantizer.StartOfWeek(x, firstDayOfWeek));

    [Theory]
    [MemberData(nameof(StartOfWeekTestsCases))]
    public void Instance_StartOfWeek_DateOnly_Returns_Expected(string inputStr, DayOfWeek firstDayOfWeek, string expectedStr)
        => QuantizeTest_DateOnly(inputStr, expectedStr, x => new TimeQuantizer(default, firstDayOfWeek: firstDayOfWeek).StartOfWeek(x));

    [Theory]
    [InlineData(null, DayOfWeek.Sunday, null)]
    [MemberData(nameof(StartOfWeekTestsCases))]
    public void Nullable_Instance_StartOfWeek_DateOnly_Returns_Expected(string? inputStr, DayOfWeek firstDayOfWeek, string? expectedStr)
        => Nullable_QuantizeTest_DateOnly(inputStr, expectedStr, x => new TimeQuantizer(default, firstDayOfWeek: firstDayOfWeek).StartOfWeek(x));

    [Theory]
    [MemberData(nameof(CultureInfoStartOfWeekTestsCases))]
    public void StartOfWeek_DateOnly_CultureInfo_Returns_Expected(string inputStr, string culture, string expectedStr)
        => QuantizeTest_DateOnly(inputStr, expectedStr, x => TimeQuantizer.StartOfWeek(x, CultureInfo.GetCultureInfo(culture)));

    [Theory]
    [InlineData(null, "en-US", null)]
    [MemberData(nameof(CultureInfoStartOfWeekTestsCases))]
    public void Nullable_StartOfWeek_DateOnly_CultureInfo_Returns_Expected(string? inputStr, string culture, string? expectedStr)
        => Nullable_QuantizeTest_DateOnly(inputStr, expectedStr, x => TimeQuantizer.StartOfWeek(x, CultureInfo.GetCultureInfo(culture)));
#endif

    internal static void StartOfWeek_Returns_Expected_DateTimeKind_Test(string inputStr, DateTimeKind kind, string expectedStr, Func<DateTime, DateTime> action)
    {
        var actual = QuantizeTest(inputStr, expectedStr, x => action(DateTime.SpecifyKind(x, kind)));

        Assert.Equal(kind, actual.Kind);
    }

    internal static void Nullable_StartOfWeek_Returns_Expected_DateTimeKind_Test(string? inputStr, DateTimeKind kind, string? expectedStr, Func<DateTime?, DateTime?> action)
    {
        var actual = Nullable_QuantizeTest(inputStr, expectedStr, x => action(DateTimeSpecifyKind(x, kind)));

        if (actual.HasValue)
        {
            Assert.Equal(kind, actual.Value.Kind);
        }
    }

    internal static DateTime? DateTimeSpecifyKind(DateTime? input, DateTimeKind kind)
        => input.HasValue ? DateTime.SpecifyKind(input.Value, kind) : null;
}
