using System.Globalization;

namespace ParadoxTerminal;

public static partial class Terminal
{
    /// <summary>
    /// Reads a single precision number from the standard input
    /// </summary>
    /// <param name="style">The style that the input must abide to</param>
    public static float ReadSingle(NumberStyles style = NumberStyles.Float)
    {
        return ReadNumber<float>(
#if !NET7_0_OR_GREATER
            in Float,
#endif
            style, Configuration.Single);
    }

    /// <summary>
    /// Reads a single precision number from the standard input within the min and max range
    /// </summary>
    /// <param name="min">The minimum number that the user can enter</param>
    /// <param name="max">The maximum number that the user can enter</param>
    /// <param name="style">The style that the input must abide to</param>
    public static float ReadSingle(float min, float max, NumberStyles style = NumberStyles.Float)
    {
        return ReadNumber(
#if !NET7_0_OR_GREATER
            in Float,
#endif
            min, max, style, Configuration.Single);
    }
}
