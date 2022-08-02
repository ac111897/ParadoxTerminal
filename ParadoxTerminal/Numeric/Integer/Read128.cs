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
    public static Int128 ReadInt128(NumberStyles style = NumberStyles.Integer)
    {
        return ReadNumber<Int128>(style, Configuration.Int128);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="min"></param>
    /// <param name="max"></param>
    /// <param name="style"></param>
    /// <returns></returns>
    public static Int128 ReadInt128(Int128 min, Int128 max, NumberStyles style = NumberStyles.Integer)
    {
        return ReadNumber(min, max, style, Configuration.Int128);
    }
}
#endif
