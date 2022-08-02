using System.Globalization;

namespace ParadoxTerminal;

public static partial class Terminal
{
    /// <summary>
    /// Reads a signed 16 big integer from the standard input
    /// </summary>
    /// <param name="style"></param>
    public static short ReadInt16(NumberStyles style = NumberStyles.Integer)
    {
        return ReadNumber<short>(
#if !NET7_0_OR_GREATER
            in Short,
#endif
            style, Configuration.Int16);
    }

    /// <summary>
    /// Reads a signed 16 integer from the standard input within the min and max range
    /// </summary>
    /// <param name="min">The minimum number that the user can enter</param>
    /// <param name="max">The maximum number that the user can enter</param>
    /// <param name="style">The style that the input must abide to</param>
    public static short ReadInt16(short min, short max, NumberStyles style = NumberStyles.Integer)
    {
        return ReadNumber<short>(
#if !NET7_0_OR_GREATER
            in Short,
#endif
            min, max, style, Configuration.Int16);
    }
}
