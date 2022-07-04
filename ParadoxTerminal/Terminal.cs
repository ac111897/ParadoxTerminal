namespace ParadoxTerminal;

/// <summary>
/// An improved version of the <see cref="Console"/> class for ease of access
/// </summary>
public static partial class Terminal
{
    private static TerminalConfiguration _instance = TerminalConfiguration.Default;

    /// <summary>
    /// Configuration for the terminal, set properties if you want to, or give the config a complete new value, if it is null it will return the default config
    /// </summary>
    public static TerminalConfiguration Configuration
    {
        get => _instance ?? TerminalConfiguration.Default;
        set
        {
            _instance = value;
        }
    }

    /// <summary>
    /// Writes the text representation of the span, followed by the current line terminator to the standard output stream 
    /// </summary>
    /// <param name="buffer"></param>
    public static void WriteLine(ReadOnlySpan<char> buffer)
    {
        Console.Out.WriteLine(buffer);
    }

    /// <summary>
    /// Writes the text representation of the span with error formatting, followed by the current line terminator to the standard output stream
    /// </summary>
    /// <param name="buffer"></param>
    public static void WriteLineError(ReadOnlySpan<char> buffer)
    {
        Console.ForegroundColor = Configuration.ErrorColor;
        Console.Out.WriteLine(buffer);
        Console.ResetColor();
    }
}
