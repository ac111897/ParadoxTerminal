using System.Globalization;
using System.Numerics;

namespace ParadoxTerminal;

public static partial class Terminal
{
    // 8 bit integers
    /// <summary>
    /// Reads a signed 8 bit integer from the standard input
    /// </summary>
    /// <param name="style"></param>
    public static sbyte ReadInt8(NumberStyles style = NumberStyles.Integer)
    {
        return ReadNumericInternal(in SByte, style, Configuration.Int64);
    }
    
    /// <summary>
    /// Reads a signed 8 bit integer from the standard input
    /// </summary>
    /// <remarks>
    /// Retries if the value is outside the bounds of min and max
    /// </remarks>
    /// <param name="min"></param>
    /// <param name="max"></param>
    /// <param name="style"></param>
    public static sbyte ReadInt8(sbyte min, sbyte max, NumberStyles style = NumberStyles.Integer)
    {
        return ReadNumericInternal(min, max, in SByte, style, Configuration.Int8);
    }

    public static byte ReadUInt8(NumberStyles style = NumberStyles.Integer)
    {
        return ReadNumericInternal(in Byte, style, Configuration.UInt8);
    }

    public static byte ReadUInt8(byte min, byte max, NumberStyles style = NumberStyles.Integer)
    {
        return ReadNumericInternal(min, max, in Byte, style, Configuration.UInt8);
    }

    public static short ReadInt16(NumberStyles style = NumberStyles.Integer)
    {
        return ReadNumericInternal(in Short, style, Configuration.Int16);
    }

    public static short ReadInt16(short min, short max, NumberStyles style = NumberStyles.Integer)
    {
        return ReadNumericInternal(min, max, in Short, style, Configuration.Int16);
    }

    public static ushort ReadUInt16(NumberStyles style = NumberStyles.Integer)
    {
        return ReadNumericInternal(in UShort, style, Configuration.UInt16);
    }

    public static int ReadInt32(NumberStyles style = NumberStyles.Integer)
    {
        return ReadNumericInternal(in Int, style, Configuration.Int32);
    }

    public static int ReadInt32(int min, int max, NumberStyles style = NumberStyles.Integer)
    {
        return ReadNumericInternal(min, max, in Int, style, Configuration.Int32);
    }

    public static uint ReadUInt32(uint min, uint max, NumberStyles style = NumberStyles.Integer)
    {
        return ReadNumericInternal(min, max, in UInt, style, Configuration.UInt32);
    }


    public static long ReadInt64(NumberStyles style = NumberStyles.Integer)
    {
        return ReadNumericInternal(in Long, style, Configuration.Int64);
    }

    public static long ReadInt64(long min, long max, NumberStyles style = NumberStyles.Integer)
    {
        return ReadNumericInternal(min, max, in Long, style, Configuration.Int64);
    }

    public static ulong ReadUInt64(NumberStyles style = NumberStyles.Integer)
    {
        return ReadNumericInternal(in ULong, style, Configuration.UInt64);
    }

    public static ulong ReadUInt64(ulong min, ulong max, NumberStyles style = NumberStyles.Integer)
    {
        return ReadNumericInternal(min, max, in ULong, style, Configuration.UInt64);
    }

    public static BigInteger ReadArbitrary(NumberStyles style = NumberStyles.Integer)
    {
        return ReadNumericInternal(in Big, style, Configuration.Arbitrary);
    }

    public static BigInteger ReadArbitrary(BigInteger min, BigInteger max, NumberStyles style = NumberStyles.Integer)
    {
        return ReadNumericInternal(min, max, in Big, style, Configuration.Arbitrary);
    }
}
