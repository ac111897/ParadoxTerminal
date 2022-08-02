using System.Globalization;

namespace ParadoxTerminal;

public static partial class Terminal
{
    /// <summary>
    /// Reads a signed 32 bit integer from the standard input
    /// </summary>
    /// <param name="style">The style that the input must abide to</param>
    public static uint ReadUInt32(NumberStyles style = NumberStyles.Integer)
    {
        return ReadNumber<uint>(
#if !NET7_0_OR_GREATER
            in UInt,
#endif
            style, Configuration.UInt32);
    }

    /// <summary>
    /// Reads an unsigned 32 bit integer from the standard input
    /// </summary>
    /// <param name="min">The minimum number that the user can enter</param>
    /// <param name="max">The maximum number that the user can enter</param>
    /// <param name="style">The style that the input must abide to</param>
    public static uint ReadUInt32(uint min, uint max, NumberStyles style = NumberStyles.Integer)
    {
        return ReadNumber(
#if !NET7_0_OR_GREATER
            in UInt,
#endif
            min, max, style, Configuration.UInt32);
    }
}
