using System.Globalization;

namespace ParadoxTerminal;

#if NET5_0_OR_GREATER
public static partial class Terminal
{
    /// <summary>
    /// Reads a half precision number from the standard input
    /// </summary>
    /// <param name="style">Style that that the input uses</param>
    public static Half ReadHalf(NumberStyles style = NumberStyles.Float)
    {
        return ReadNumber<Half>(
#if !NET7_0_OR_GREATER
            in Half,
#endif
            style, Configuration.Half);
    }

    /// <summary>
    /// Reads a half precision number from the standard input within the min and max range
    /// </summary>
    /// <param name="min">The minimum number that the user can enter</param>
    /// <param name="max">The maximum number that the user can enter</param>
    /// <param name="style">The style that the input must abide to</param>
    public static Half ReadHalf(Half min, Half max, NumberStyles style = NumberStyles.Float)
    {
        return ReadNumber<Half>(
#if !NET7_0_OR_GREATER
            in Half,
#endif
            min, max, style, Configuration.Half);
    }
}
#endif
