namespace ParadoxTerminal;

public static partial class Terminal
{
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
    /// Simple a wrapper over a <see cref="TextReader.ReadLineAsync()"/> for convenience
    /// </remarks>
    public static Task<string?> ReadLineAsync()
    {
        return Console.In.ReadLineAsync();
    }

#if NET7_0_OR_GREATER
    /// <summary>
    /// Reads a type that is parsed by a span from the standard input
    /// </summary>
    /// <typeparam name="TValue"></typeparam>
    /// <param name="provider"></param>
    /// <returns></returns>
    public static TValue Read<TValue>(IFormatProvider? provider = null) where TValue : ISpanParsable<TValue>
    {
        TValue result;

        while (!TValue.TryParse(Console.In.ReadLine(), provider, out result))
        {
            Console.WriteLine($"Failed to read data");
        }

        return result;
    }
#endif
}
