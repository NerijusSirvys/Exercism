using System;

public enum Schedule
{
    Teenth,
    First,
    Second,
    Third,
    Fourth,
    Last
}

public class Meetup
{
    public int Month { get; set; }
    public int Year { get; set; }

    public Meetup(int month, int year)
    {
        Month = month;
        Year = year;
    }

    public DateTime Day(DayOfWeek dayOfWeek, Schedule schedule)
    {
        int dayLookUpFrom = 0;
        int dayLookUpTo = 0;

        switch (schedule)
        {
            case Schedule.Teenth:
                dayLookUpFrom = 13;
                dayLookUpTo = 19;
                break;
            case Schedule.First:
                dayLookUpFrom = 1;
                dayLookUpTo = 7;
                break;
            case Schedule.Second:
                dayLookUpFrom = 8;
                dayLookUpTo = 14;
                break;
            case Schedule.Third:
                dayLookUpFrom = 15;
                dayLookUpTo = 21;
                break;
            case Schedule.Fourth:
                dayLookUpFrom = 22;
                dayLookUpTo = 28;
                break;
            case Schedule.Last:
                dayLookUpFrom = DateTime.DaysInMonth(Year, Month) / 4;
                dayLookUpTo = DateTime.DaysInMonth(Year, Month);
                break;
        }

        int day = GetDay(dayOfWeek, dayLookUpFrom, dayLookUpTo);

        return new DateTime(Year, Month, day);

    }

    private int GetDay(DayOfWeek dayOfWeek, int dayFrom, int dayTo)
    {
        int day = 0;

        for (int i = dayFrom; i <= dayTo; i++)
        {
            DateTime date = new DateTime(Year, Month, i);
            if (date.DayOfWeek == dayOfWeek)
            {
                day = date.Day;
            }
        }
        return day;
    }
}