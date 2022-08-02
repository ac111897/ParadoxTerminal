using System.Globalization;

namespace ParadoxTerminal;

public static partial class Terminal
{
    /// <summary>
    /// Reads a signed 32 bit integer from the standard input
    /// </summary>
    /// <param name="style"></param>
    /// <returns></returns>
    public static int ReadInt32(NumberStyles style = NumberStyles.Integer)
    {
        return ReadNumber<int>(
#if !NET7_0_OR_GREATER
            in Int,
#endif
            style, Configuration.Int32);
    }

    /// <summary>
    /// Reads a signed 32 bit integer from the standard input
    /// </summary>
    /// <param name="min">The minimum number that the user can enter</param>
    /// <param name="max">The maximum number that the user can enter</param>
    /// <param name="style">The style that the input must abide to</param>
    public static int ReadInt32(int min, int max, NumberStyles style = NumberStyles.Integer)
    {
        return ReadNumber(
#if !NET7_0_OR_GREATER
            in Int,
#endif
            min, max, style, Configuration.Int32);
    }
}
