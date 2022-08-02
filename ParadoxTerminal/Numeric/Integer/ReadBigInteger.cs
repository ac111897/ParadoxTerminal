using System.Globalization;
using System.Numerics;

namespace ParadoxTerminal;

public static partial class Terminal
{
    /// <summary>
    /// Reads a arbitrary number from the standard input
    /// </summary>
    /// <param name="style">The style that the input must abide to</param>
    public static BigInteger ReadArbitrary(NumberStyles style = NumberStyles.Integer)
    {
        return ReadNumber<BigInteger>(
#if !NET7_0_OR_GREATER
            in Big,
#endif
            style, Configuration.Arbitrary);
    }

    /// <summary>
    /// Reads a arbitrary number from the standard input within the min and max range
    /// </summary>
    /// <param name="min">The minimum number that the user can enter</param>
    /// <param name="max">The maximum number that the user can enter</param>
    /// <param name="style">The style that the input must abide to</param>
    public static BigInteger ReadArbitrary(BigInteger min, BigInteger max, NumberStyles style = NumberStyles.Integer)
    {
        return ReadNumber(
#if !NET7_0_OR_GREATER
            in Big,
#endif
            min, max, style, Configuration.Arbitrary);
    }
}
