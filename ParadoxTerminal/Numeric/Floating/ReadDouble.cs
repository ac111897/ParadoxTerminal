using System.Globalization;

namespace ParadoxTerminal;

public static partial class Terminal
{
    /// <summary>
    /// Reads a double precision number from the standard input
    /// </summary>
    /// <param name="style">The style that the input must abide to</param>
    public static double ReadDouble(NumberStyles style = NumberStyles.Float)
    {
        return ReadNumber<double>(
#if !NET7_0_OR_GREATER
            in Double,
#endif
            style, Configuration.Double);
    }

    /// <summary>
    /// Reads a double precision number from the standard input within the min and max range
    /// </summary>
    /// <param name="min">The minimum number that the user can enter</param>
    /// <param name="max">The maximum number that the user can enter</param>
    /// <param name="style">The style that the input must abide to</param>
    public static double ReadDouble(double min, double max, NumberStyles style = NumberStyles.Float)
    {
        return ReadNumber(
#if !NET7_0_OR_GREATER
            in Double,
#endif
            min, max, style, Configuration.Double);
    }
}
