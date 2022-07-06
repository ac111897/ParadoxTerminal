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
    /// Reads a signed 8 bit integer from the standard input within the min and max range
    /// </summary>
    /// <param name="min">The minimum number that the user can enter</param>
    /// <param name="max">The maximum number that the user can enter</param>
    /// <param name="style">The style that the input must abide to</param>
    public static sbyte ReadInt8(sbyte min, sbyte max, NumberStyles style = NumberStyles.Integer)
    {
        return ReadNumericInternal(min, max, in SByte, style, Configuration.Int8);
    }

    /// <summary>
    /// Reads a unsigned 8 bit integer from the standard input
    /// </summary>
    /// <param name="style"></param>
    /// <returns></returns>
    public static byte ReadUInt8(NumberStyles style = NumberStyles.Integer)
    {
        return ReadNumericInternal(in Byte, style, Configuration.UInt8);
    }

    /// <summary>
    /// Reads an unsigned 8 bit integer from the standard input within the min and max range
    /// </summary>
    /// <param name="min">The minimum number that the user can enter</param>
    /// <param name="max">The maximum number that the user can enter</param>
    /// <param name="style">The style that the input must abide to</param>
    public static byte ReadUInt8(byte min, byte max, NumberStyles style = NumberStyles.Integer)
    {
        return ReadNumericInternal(min, max, in Byte, style, Configuration.UInt8);
    }

    /// <summary>
    /// Reads a signed 16 big integer from the standard input
    /// </summary>
    /// <param name="style"></param>
    public static short ReadInt16(NumberStyles style = NumberStyles.Integer)
    {
        return ReadNumericInternal(in Short, style, Configuration.Int16);
    }

    /// <summary>
    /// Reads a signed 16 integer from the standard input within the min and max range
    /// </summary>
    /// <param name="min">The minimum number that the user can enter</param>
    /// <param name="max">The maximum number that the user can enter</param>
    /// <param name="style">The style that the input must abide to</param>
    public static short ReadInt16(short min, short max, NumberStyles style = NumberStyles.Integer)
    {
        return ReadNumericInternal(min, max, in Short, style, Configuration.Int16);
    }

    /// <summary>
    /// Reads a unsigned 16 bit integer from the standard input
    /// </summary>
    /// <param name="style"></param>
    /// <returns></returns>
    public static ushort ReadUInt16(NumberStyles style = NumberStyles.Integer)
    {
        return ReadNumericInternal(in UShort, style, Configuration.UInt16);
    }

    /// <summary>
    /// Reads a signed 32 bit integer from the standard input
    /// </summary>
    /// <param name="style"></param>
    /// <returns></returns>
    public static int ReadInt32(NumberStyles style = NumberStyles.Integer)
    {
        return ReadNumericInternal(in Int, style, Configuration.Int32);
    }

    /// <summary>
    /// Reads a signed 32 bit integer from the standard input
    /// </summary>
    /// <param name="min">The minimum number that the user can enter</param>
    /// <param name="max">The maximum number that the user can enter</param>
    /// <param name="style">The style that the input must abide to</param>
    public static int ReadInt32(int min, int max, NumberStyles style = NumberStyles.Integer)
    {
        return ReadNumericInternal(min, max, in Int, style, Configuration.Int32);
    }

    /// <summary>
    /// Reads a signed 32 bit integer from the standard input
    /// </summary>
    /// <param name="style">The style that the input must abide to</param>
    public static uint ReadUInt32(NumberStyles style = NumberStyles.Integer)
    {
        return ReadNumericInternal(in UInt, style, Configuration.UInt32);
    }

    /// <summary>
    /// Reads a signed 32 bit integer from the standard input
    /// </summary>
    /// <param name="min">The minimum number that the user can enter</param>
    /// <param name="max">The maximum number that the user can enter</param>
    /// <param name="style">The style that the input must abide to</param>
    public static uint ReadUInt32(uint min, uint max, NumberStyles style = NumberStyles.Integer)
    {
        return ReadNumericInternal(min, max, in UInt, style, Configuration.UInt32);
    }

    /// <summary>
    /// Reads a signed 64 bit integer from the standard input
    /// </summary>
    /// <param name="style">The style that the input must abide to</param>
    public static long ReadInt64(NumberStyles style = NumberStyles.Integer)
    {
        return ReadNumericInternal(in Long, style, Configuration.Int64);
    }


    /// <summary>
    /// Reads a signed 64 bit integer from the standard input within the min and max range
    /// </summary>
    /// <param name="min">The minimum number that the user can enter</param>
    /// <param name="max">The maximum number that the user can enter</param>
    /// <param name="style">The style that the input must abide to</param>
    public static long ReadInt64(long min, long max, NumberStyles style = NumberStyles.Integer)
    {
        return ReadNumericInternal(min, max, in Long, style, Configuration.Int64);
    }

    /// <summary>
    /// Reads a unsigned 64 bit integer from the standard input
    /// </summary>
    /// <param name="style"></param>
    /// <returns></returns>
    public static ulong ReadUInt64(NumberStyles style = NumberStyles.Integer)
    {
        return ReadNumericInternal(in ULong, style, Configuration.UInt64);
    }

    /// <summary>
    /// Reads a unsigned 64 bit integer from the standard input within the min and max range
    /// </summary>
    /// <param name="min">The minimum number that the user can enter</param>
    /// <param name="max">The maximum number that the user can enter</param>
    /// <param name="style">The style that the input must abide to</param>
    public static ulong ReadUInt64(ulong min, ulong max, NumberStyles style = NumberStyles.Integer)
    {
        return ReadNumericInternal(min, max, in ULong, style, Configuration.UInt64);
    }

    /// <summary>
    /// Reads a arbitrary number from the standard input
    /// </summary>
    /// <param name="style">The style that the input must abide to</param>
    public static BigInteger ReadArbitrary(NumberStyles style = NumberStyles.Integer)
    {
        return ReadNumericInternal(in Big, style, Configuration.Arbitrary);
    }

    /// <summary>
    /// Reads a arbitrary number from the standard input within the min and max range
    /// </summary>
    /// <param name="min">The minimum number that the user can enter</param>
    /// <param name="max">The maximum number that the user can enter</param>
    /// <param name="style">The style that the input must abide to</param>
    public static BigInteger ReadArbitrary(BigInteger min, BigInteger max, NumberStyles style = NumberStyles.Integer)
    {
        return ReadNumericInternal(min, max, in Big, style, Configuration.Arbitrary);
    }
}
