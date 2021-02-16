public static class Leap
{
    public static bool IsLeapYear(int year)
    {
        bool isLeap = false;

        isLeap = year % 4 == 0;

        if (year % 100 == 0)
        {
            isLeap = year % 400 == 0;
        }

        return isLeap;
    }
}