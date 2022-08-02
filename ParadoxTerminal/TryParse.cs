using System.Globalization;

namespace ParadoxTerminal;

/// <summary>
/// Delegate for the <see cref="int.TryParse(ReadOnlySpan{char}, NumberStyles, IFormatProvider?, out int)"/> as <see cref="ReadOnlySpan{T}"/> 
/// as Func delegates cannot use <see cref="ReadOnlySpan{T}"/> as a generic option
/// </summary>
/// <typeparam name="TValue"></typeparam>
/// <param name="s"></param>
/// <param name="style"></param>
/// <param name="provider"></param>
/// <param name="result"></param>
/// <returns></returns>
internal delegate bool TryParse<TValue>(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider? provider, out TValue result)
    where TValue : IComparable, IComparable<TValue>, IEquatable<TValue>, IFormattable;
