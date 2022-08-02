using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

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
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => _instance ?? TerminalConfiguration.Default;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _instance = value;
        }
    }

    /// <summary>
    /// <see cref="Console.Title"/> wrapper
    /// </summary>
    public static string Title
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (!RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                throw new PlatformNotSupportedException("This operation is only supported on windows");
            }

            return Console.Title;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set => Console.Title = value;
    }

    /// <summary>
    /// Writes the text representation of the span, followed by the current line terminator to the standard output stream 
    /// </summary>
    /// <param name="buffer"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void WriteLine(ReadOnlySpan<char> buffer)
    {
        Console.Out.WriteLine(buffer);
    }

    /// <summary>
    /// Writes each string to the standard ouput, seperated by the current line terminator
    /// </summary>
    /// <param name="lines"></param>
    public static void WriteLines(ReadOnlySpan<string> lines)
    {
        if (lines.IsEmpty)
        {
            return;
        }

        for (int i = 0; i < lines.Length; i++)
        {
            Console.Out.WriteLine(lines[i]);
        }
    }

    /// <summary>
    /// Asynchronously writes a line terminator to the standard output stream
    /// </summary>
    /// <returns>A task that represents the asynchronous write operation</returns>
    public static Task WriteLineAsync()
    {
        return Console.Out.WriteLineAsync();
    }

    /// <summary>
    /// Asynchronously writes the text representation of a character memory region to the standard ouput stream
    /// </summary>
    /// <param name="buffer"></param>
    /// <returns>A task that represents the asynchronous write operation</returns>
    public static Task WriteLineAsync(ReadOnlyMemory<char> buffer)
    {
        return Console.Out.WriteLineAsync(buffer);
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
