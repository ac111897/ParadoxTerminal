using System.Globalization;

namespace ParadoxTerminal;

public static partial class Terminal
{
    /// <summary>
    /// Reads a signed 64 bit integer from the standard input
    /// </summary>
    /// <param name="style">The style that the input must abide to</param>
    public static long ReadInt64(NumberStyles style = NumberStyles.Integer)
    {
        return ReadNumber<long>(
#if !NET7_0_OR_GREATER
            in Long,
#endif
            style, Configuration.Int64);
    }


    /// <summary>
    /// Reads a signed 64 bit integer from the standard input within the min and max range
    /// </summary>
    /// <param name="min">The minimum number that the user can enter</param>
    /// <param name="max">The maximum number that the user can enter</param>
    /// <param name="style">The style that the input must abide to</param>
    public static long ReadInt64(long min, long max, NumberStyles style = NumberStyles.Integer)
    {
        return ReadNumber(
#if !NET7_0_OR_GREATER
            in Long,
#endif
            min, max, style, Configuration.Int64);
    }
}
