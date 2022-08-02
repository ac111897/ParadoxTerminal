using ParadoxTerminal.Options;
using System.Globalization;
using System.Numerics;

namespace ParadoxTerminal;

public static partial class Terminal
{
#if NET7_0_OR_GREATER
    /// <summary>
    /// Reads a generic floating point number from the standard input
    /// </summary>
    /// <typeparam name="TNumber"></typeparam>
    /// <returns></returns>
    public static TNumber ReadFloating<TNumber>() where TNumber : IFloatingPoint<TNumber>
    {
        return ReadNumber<TNumber>(NumberStyles.Float);
    }

    /// <summary>
    /// Reads a number of generic <see cref="INumber{TSelf}"/> using the specified style options
    /// </summary>
    /// <typeparam name="TNumber"></typeparam>
    /// <param name="style"></param>
    /// <param name="options"></param>
    /// <returns></returns>
    public static TNumber ReadNumber<TNumber>(NumberStyles style, NumericOptions? options = default)
        where TNumber : INumber<TNumber>
    {
        TNumber result;

        ReadOnlySpan<char> data = Console.ReadLine();

        while (!TNumber.TryParse(data, style, NumberFormatInfo.InvariantInfo, out result))
        {
            if (data.IsWhiteSpace())
            {
                if (options is not null)
                {
                    WriteLineError(options.OnEmpty);
                }
                else
                {
                    WriteLineError("You need to enter a value");
                }
            }
            else
            {
                if (options is not null)
                {
                    WriteLineError(options.OnInvalid);
                }
                else
                {
                    WriteLineError($"You entered an invalid value for the number");
                }
            }

            data = Console.ReadLine();
        }

        return result;
    }

    /// <summary>
    /// Reads a number of see <see cref="INumber{TSelf}"/> where the specified number is between the min and max value or else the input will fail
    /// </summary>
    /// <typeparam name="TNumber"></typeparam>
    /// <param name="minValue"></param>
    /// <param name="maxValue"></param>
    /// <param name="style"></param>
    /// <param name="options"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    public static TNumber ReadNumber<TNumber>(TNumber minValue, TNumber maxValue,
        NumberStyles style, NumericOptions options) where TNumber : INumber<TNumber>
    {
        if (minValue > maxValue)
        {
            throw new ArgumentOutOfRangeException(nameof(minValue));
        }

        TNumber value;

        while (true)
        {
            ReadOnlySpan<char> data = Console.ReadLine();

            while (!TNumber.TryParse(data, style, NumberFormatInfo.InvariantInfo, out value))
            {
                if (data.IsWhiteSpace())
                {
                    WriteLineError(options.OnEmpty);
                }
                else
                {
                    WriteLineError(options.OnInvalid);
                }

                data = Console.ReadLine();
            }

            if (value < minValue || value > maxValue)
            {
                WriteLineError(options.InRange.Formatted(minValue, maxValue));
                continue;
            }

            break;
        }

        return value;
    }
#else
    // Signed integer types
    private static readonly TryParse<sbyte> SByte = sbyte.TryParse;
    private static readonly TryParse<short> Short = short.TryParse;
    private static readonly TryParse<int> Int = int.TryParse;
    private static readonly TryParse<long> Long = long.TryParse;

    // Unsigned
    private static readonly TryParse<byte> Byte = byte.TryParse;
    private static readonly TryParse<ushort> UShort = ushort.TryParse;
    private static readonly TryParse<uint> UInt = uint.TryParse;
    private static readonly TryParse<ulong> ULong = ulong.TryParse;

    // floating point
#if NET5_0_OR_GREATER
    private static readonly TryParse<Half> Half = System.Half.TryParse;
#endif
    private static readonly TryParse<float> Float = float.TryParse;
    private static readonly TryParse<double> Double = double.TryParse;
    private static readonly TryParse<decimal> Decimal = decimal.TryParse;

    // arbitary
    private static readonly TryParse<BigInteger> Big = BigInteger.TryParse;

    internal static TInteger ReadNumber<TInteger>(in TryParse<TInteger> method, NumberStyles style, NumericOptions options)
        where TInteger : IComparable, IComparable<TInteger>, IEquatable<TInteger>, IFormattable
    {
        TInteger value;

        ReadOnlySpan<char> data = Console.ReadLine();

        while (!method(data, style, NumberFormatInfo.InvariantInfo, out value))
        {
            if (data.IsWhiteSpace())
            {
                WriteLineError(options.OnEmpty);
            }
            else
            {
                WriteLineError(options.OnInvalid);
            }

            data = Console.ReadLine();
        }

        return value;
    }

    internal static TInteger ReadNumber<TInteger>(in TryParse<TInteger> method,
        TInteger minValue, TInteger maxValue,
        NumberStyles style, NumericOptions options)
        where TInteger : IComparable, IComparable<TInteger>, IEquatable<TInteger>, IFormattable
    {
        TInteger value;

        if (minValue.IsGreaterThan(maxValue))
        {
            throw new ArgumentOutOfRangeException(nameof(minValue));
        }

        while (true)
        {
            ReadOnlySpan<char> data = Console.ReadLine();

            while (!method(data, style, NumberFormatInfo.InvariantInfo, out value))
            {
                if (data.IsWhiteSpace())
                {
                    WriteLineError(options.OnEmpty);
                }
                else
                {
                    WriteLineError(options.OnInvalid);
                }

                data = Console.ReadLine();
            }

            if (value.IsLessThan(minValue) || value.IsGreaterThan(maxValue))
            {
                WriteLineError(options.InRange.Formatted(minValue, maxValue));
                continue;
            }

            break;
        }

        return value;
    }

#endif
}
