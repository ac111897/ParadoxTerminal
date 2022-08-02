using System.Globalization;

namespace ParadoxTerminal;

public static partial class Terminal
{
    /// <summary>
    /// Reads a unsigned 64 bit integer from the standard input
    /// </summary>
    /// <param name="style"></param>
    /// <returns></returns>
    public static ulong ReadUInt64(NumberStyles style = NumberStyles.Integer)
    {
        return ReadNumber<ulong>(
#if !NET7_0_OR_GREATER
            in ULong,
#endif
            style, Configuration.UInt64);
    }

    /// <summary>
    /// Reads a unsigned 64 bit integer from the standard input within the min and max range
    /// </summary>
    /// <param name="min">The minimum number that the user can enter</param>
    /// <param name="max">The maximum number that the user can enter</param>
    /// <param name="style">The style that the input must abide to</param>
    public static ulong ReadUInt64(ulong min, ulong max, NumberStyles style = NumberStyles.Integer)
    {
        return ReadNumber(
#if !NET7_0_OR_GREATER
            in ULong,
#endif            
            min, max, style, Configuration.UInt64);
    }
}
