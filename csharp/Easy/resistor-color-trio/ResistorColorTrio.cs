using System.Collections.Generic;
using System.Text;

public static class ResistorColorTrio
{

    public static Dictionary<string, int> Resistors => new Dictionary<string, int>()
        {
            {"black", 0},{"brown", 1}, {"red", 2}, {"orange", 3}, {"yellow", 4},
            {"green", 5}, {"blue", 6}, {"violet", 7}, {"grey", 8}, {"white", 9}
        };

    public static string Label(string[] colors)
    {

        // mach input to resistors collection and extract total number of ohms
        // if second number is 0, then adds it to trailing zero count instead of ohm value
        StringBuilder ohms = new StringBuilder();
        int trailingZeros = 0;

        for (int i = 0; i < colors.Length; i++)
        {

            Resistors.TryGetValue(colors[i], out int resistorValue);


            if (i < 2 && resistorValue == 0)
            {
                trailingZeros++;
            }
            else if (i < 2)
            {
                ohms.Append(resistorValue);
            }
            else
            {
                trailingZeros += resistorValue;
            }
        }

        return GetResult(ohms.ToString(), trailingZeros);
    }

    private static string GetResult(string ohms, int trailingZeros)
    {
        // generates output message based on number of trailing zeros
        string output = string.Empty;

        switch (trailingZeros)
        {
            case 0:
                output = $"{ohms} ohms";
                break;
            case 1:
            case 2:
                output = $"{ohms}{new string('0', trailingZeros)} ohms";
                break;

            case 3:
            case 4:
            case 5:
                output = $"{ohms}{new string('0', trailingZeros - 3)} kiloohms";
                break;
        }

        return output;

    }


}
