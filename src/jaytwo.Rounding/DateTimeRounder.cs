namespace jaytwo.Rounding;

public class DateTimeRounder
{
    public static DateTime Round(DateTime input, TimeSpanRounding precision, AbsoluteRounding mode)
        => input.Date.Add(TimeSpanRounder.Round(input.TimeOfDay, precision, mode));

    public static DateTime Round(DateTime input, TimeSpanRounding precision, MidpointRounding mode)
        => input.Date.Add(TimeSpanRounder.Round(input.TimeOfDay, precision, mode));
}
