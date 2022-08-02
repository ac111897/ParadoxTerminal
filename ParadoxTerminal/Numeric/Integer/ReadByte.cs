using System.Globalization;

// ReadByte: reads an unsigned 8 bit integer from the standard input

namespace ParadoxTerminal;

public static partial class Terminal
{
    /// <summary>
    /// Reads a unsigned 8 bit integer from the standard input
    /// </summary>
    /// <param name="style"></param>
    /// <returns></returns>
    public static byte ReadUInt8(NumberStyles style = NumberStyles.Integer)
    {
        return ReadNumber<byte>(
#if !NET7_0_OR_GREATER
            in Byte,
#endif
            style, Configuration.UInt8);
    }

    /// <summary>
    /// Reads an unsigned 8 bit integer from the standard input within the min and max range
    /// </summary>
    /// <param name="min">The minimum number that the user can enter</param>
    /// <param name="max">The maximum number that the user can enter</param>
    /// <param name="style">The style that the input must abide to</param>
    public static byte ReadUInt8(byte min, byte max, NumberStyles style = NumberStyles.Integer)
    {
        return ReadNumber<byte>(
#if !NET7_0_OR_GREATER
            in Byte,
#endif
            min, max, style, Configuration.UInt8);
    }
}
