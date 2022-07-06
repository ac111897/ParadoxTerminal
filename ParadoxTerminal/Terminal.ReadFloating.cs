using System.Globalization;

namespace ParadoxTerminal;

public static partial class Terminal
{
    /// <summary>
    /// Reads a half precision number from the standard input
    /// </summary>
    /// <param name="style">Style that that the input uses</param>
    public static Half ReadHalf(NumberStyles style = NumberStyles.Float)
    {
        return ReadNumericInternal(in Half, style, Configuration.Half);
    }

    /// <summary>
    /// Reads a half precision number from the standard input within the min and max range
    /// </summary>
    /// <param name="min">The minimum number that the user can enter</param>
    /// <param name="max">The maximum number that the user can enter</param>
    /// <param name="style">The style that the input must abide to</param>
    public static Half ReadHalf(Half min, Half max, NumberStyles style = NumberStyles.Float)
    {
        return ReadNumericInternal(min, max, in Half, style, Configuration.Half);
    }

    /// <summary>
    /// Reads a single precision number from the standard input
    /// </summary>
    /// <param name="style">The style that the input must abide to</param>
    public static float ReadSingle(NumberStyles style = NumberStyles.Float)
    {
        return ReadNumericInternal(in Float, style, Configuration.Single);
    }

    /// <summary>
    /// Reads a single precision number from the standard input within the min and max range
    /// </summary>
    /// <param name="min">The minimum number that the user can enter</param>
    /// <param name="max">The maximum number that the user can enter</param>
    /// <param name="style">The style that the input must abide to</param>
    public static float ReadSingle(float min, float max, NumberStyles style = NumberStyles.Float)
    {
        return ReadNumericInternal(min, max, in Float, style, Configuration.Single);
    }

    /// <summary>
    /// Reads a double precision number from the standard input
    /// </summary>
    /// <param name="style">The style that the input must abide to</param>
    public static double ReadDouble(NumberStyles style = NumberStyles.Float)
    {
        return ReadNumericInternal(in Double, style, Configuration.Double);
    }

    /// <summary>
    /// Reads a double precision number from the standard input within the min and max range
    /// </summary>
    /// <param name="min">The minimum number that the user can enter</param>
    /// <param name="max">The maximum number that the user can enter</param>
    /// <param name="style">The style that the input must abide to</param>
    public static double ReadDouble(double min, double max, NumberStyles style = NumberStyles.Float)
    {
        return ReadNumericInternal(min, max, in Double, style, Configuration.Double);
    }

    /// <summary>
    /// Reads a decimal number from the standard input
    /// </summary>
    /// <param name="style">The style that the input must abide to</param>
    public static decimal ReadDecimal(NumberStyles style = NumberStyles.Float)
    {
        return ReadNumericInternal(in Decimal, style, Configuration.Decimal);
    }

    /// <summary>
    /// Reads a decimal number from the standard input within the min and max range
    /// </summary>
    /// <param name="min">The minimum number that the user can enter</param>
    /// <param name="max">The maximum number that the user can enter</param>
    /// <param name="style">The style that the input must abide to</param>
    public static decimal ReadDecimal(decimal min, decimal max, NumberStyles style = NumberStyles.Float)
    {
        return ReadNumericInternal(min, max, in Decimal, style, Configuration.Decimal);
    }
}
