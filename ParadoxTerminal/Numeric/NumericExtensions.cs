namespace ParadoxTerminal.Numeric;

internal static class NumericExtensions
{
    public static bool IsGreaterThan<T>(this T value, T other) where T : IComparable<T>
    {
        return value.CompareTo(other) > 0;
    }

    public static bool IsLessThan<T>(this T value, T other) where T : IComparable<T>
    {
        return value.CompareTo(other) < 0;
    }
}
