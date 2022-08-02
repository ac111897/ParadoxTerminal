using System.Globalization;

namespace ParadoxTerminal;

public static partial class Terminal
{
    /// <summary>
    /// Reads a decimal number from the standard input
    /// </summary>
    /// <param name="style">The style that the input must abide to</param>
    public static decimal ReadDecimal(NumberStyles style = NumberStyles.Float)
    {
        return ReadNumber<decimal>(
#if !NET7_0_OR_GREATER
            in Decimal,
#endif
            style, Configuration.Decimal);
    }

    /// <summary>
    /// Reads a decimal number from the standard input within the min and max range
    /// </summary>
    /// <param name="min">The minimum number that the user can enter</param>
    /// <param name="max">The maximum number that the user can enter</param>
    /// <param name="style">The style that the input must abide to</param>
    public static decimal ReadDecimal(decimal min, decimal max, NumberStyles style = NumberStyles.Float)
    {
        return ReadNumber(
#if !NET7_0_OR_GREATER
            in Decimal,
#endif
            min, max, style, Configuration.Decimal);
    }
}
