using System.Globalization;

namespace ParadoxTerminal;

public static partial class Terminal
{
#if !NET7_0_OR_GREATER
    private static readonly TryParse<ushort> UInt16 = ushort.TryParse;
#endif
    /// <summary>
    /// Reads a unsigned 16 bit integer from the standard input
    /// </summary>
    /// <param name="style"></param>
    /// <returns></returns>
    public static ushort ReadUInt16(NumberStyles style = NumberStyles.Integer)
    {
        return ReadNumber<ushort>(
#if !NET7_0_OR_GREATER
            in UInt16,
#endif
            style, Configuration.UInt16);
    }

    /// <summary>
    /// Reads an unsigned 16 bit integer from the standard input between the specified min and max range
    /// </summary>
    /// <param name="min"></param>
    /// <param name="max"></param>
    /// <param name="style"></param>
    /// <returns></returns>
    public static ushort ReadUInt16(ushort min, ushort max, NumberStyles style = NumberStyles.Integer)
    {
        return ReadNumber<ushort>(
#if !NET7_0_OR_GREATER
            in UShort,
#endif
            min, max, style, Configuration.UInt16);
    }
}
