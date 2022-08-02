using System.Globalization;

namespace ParadoxTerminal;

public static partial class Terminal
{
    /// <summary>
    /// Reads a signed 8 bit integer from the standard input
    /// </summary>
    /// <param name="style"></param>
    public static sbyte ReadInt8(NumberStyles style = NumberStyles.Integer)
    {
        return ReadNumber<sbyte>(
#if !NET7_0_OR_GREATER
            in SByte,
#endif
            style, Configuration.Int8);
    }

    /// <summary>
    /// Reads a signed 8 bit integer from the standard input within the min and max range
    /// </summary>
    /// <param name="min">The minimum number that the user can enter</param>
    /// <param name="max">The maximum number that the user can enter</param>
    /// <param name="style">The style that the input must abide to</param>
    public static sbyte ReadInt8(sbyte min, sbyte max, NumberStyles style = NumberStyles.Integer)
    {
        return ReadNumber<sbyte>(
#if !NET7_0_OR_GREATER
            in SByte,
#endif
            min, max, style, Configuration.Int8);
    }
}
