#if NET7_0_OR_GREATER
using System.Globalization;

namespace ParadoxTerminal;

public static partial class Terminal
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="style"></param>
    /// <returns></returns>
    public static UInt128 ReadUInt128(NumberStyles style = NumberStyles.Integer)
    {
        return ReadNumber<UInt128>(style, Configuration.UInt128);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="min"></param>
    /// <param name="max"></param>
    /// <param name="style"></param>
    /// <returns></returns>
    public static UInt128 ReadUInt128(UInt128 min, UInt128 max, NumberStyles style = NumberStyles.Integer)
    {
        return ReadNumber(min, max, style, Configuration.UInt128);
    }
}

#endif
