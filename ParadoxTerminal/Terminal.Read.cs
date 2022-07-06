using System.Globalization;
using System.Numerics;
using ParadoxTerminal.Numeric;
using ParadoxTerminal.Options;

namespace ParadoxTerminal;

public static partial class Terminal
{
    #region Numeric Reading
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
    private static readonly TryParse<Half> Half = System.Half.TryParse;
    private static readonly TryParse<float> Float = float.TryParse;
    private static readonly TryParse<double> Double = double.TryParse;
    private static readonly TryParse<decimal> Decimal = decimal.TryParse;

    // arbitary
    private static readonly TryParse<BigInteger> Big = BigInteger.TryParse;
    #endregion

    /// <summary>
    /// Reads a line of characters from the standard input and returns the data as a string
    /// </summary>
    /// <remarks>
    /// Simply a wrapper over <see cref="Console.ReadLine"/> for convenience
    /// </remarks>
    public static string? ReadLine()
    {
        return Console.ReadLine();
    }

    /// <summary>
    /// Reads a line of characters from the terminal asynchronously and returns the data as a string
    /// </summary>
    /// <remarks>
    /// Simple a wrapper over a <see cref="TextReader.ReadLineAsync"/> for convenience
    /// </remarks>
    public static Task<string?> ReadLineAsync()
    {
        return Console.In.ReadLineAsync();
    }

    internal static TInteger ReadNumericInternal<TInteger>(in TryParse<TInteger> method, NumberStyles style, NumericOptions options)
        where TInteger : IComparable, IComparable<TInteger>, IEquatable<TInteger>, ISpanFormattable, IFormattable
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

    internal static TInteger ReadNumericInternal<TInteger>(
        TInteger minValue, TInteger maxValue,
        in TryParse<TInteger> method, NumberStyles style, NumericOptions options)
        where TInteger : IComparable, IComparable<TInteger>, IEquatable<TInteger>, ISpanFormattable, IFormattable
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
}
