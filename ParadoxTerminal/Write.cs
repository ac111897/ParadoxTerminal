namespace ParadoxTerminal;

public static partial class Terminal
{
    /// <summary>
    /// Writes the specified value to the standard output
    /// </summary>
    /// <param name="buffer"></param>
    public static void Write(ReadOnlySpan<char> buffer)
    {
        Console.Out.Write(buffer);
    }
}
