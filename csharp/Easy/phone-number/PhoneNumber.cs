using System;
using System.Linq;

public static class PhoneNumber
{
    public static string Clean(string phoneNumber)
    {
        //remove first digit if it is equal to 1
        char[] countryCode = new char[] { '+', '1' };
        string numberWithRemovedCountryCode = phoneNumber.TrimStart(countryCode);

        // cleans given number from all non digit characters
        string cleanedNumber = new string(numberWithRemovedCountryCode.Where(x => char.IsDigit(x)).ToArray());

        ValidatePhoneNumber(cleanedNumber);

        return cleanedNumber;
    }



    private static void ValidatePhoneNumber(string number)
    {
        if (number.Length != 10) { throw new ArgumentException(); }

        // constants to mark begining of area and exchange codes begining
        const int areaCodeIndex = 0;
        const int exchanegeCodeIndex = 3;

        // checks if area and contry codes start with valid numbers
        if (int.Parse(number[areaCodeIndex].ToString()) < 2 || int.Parse(number[areaCodeIndex].ToString()) == 9) { throw new ArgumentException(); }
        if (int.Parse(number[exchanegeCodeIndex].ToString()) < 2 || int.Parse(number[exchanegeCodeIndex].ToString()) == 9) { throw new ArgumentException(); }

        // checks if number holds no other values but digits
        if (!ulong.TryParse(number, out _)) { throw new ArgumentException(); }
    }
}