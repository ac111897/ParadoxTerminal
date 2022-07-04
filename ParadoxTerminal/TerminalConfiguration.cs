using System.Diagnostics.CodeAnalysis;

namespace ParadoxTerminal;

/// <summary>
/// Configuration used to customize the <see cref="Terminal"/>
/// </summary>
public class TerminalConfiguration
{
    /// <summary>
    /// The default configuration to be used in <see cref="Terminal"/>
    /// </summary>
    public static TerminalConfiguration Default { get; } = new()
    {
        ErrorColor = ConsoleColor.DarkRed,
        WarningColor = ConsoleColor.Red,
        InfoColor = ConsoleColor.Green,
        OutOfRange = "Input must be between {0} and {1}",
        NeedsValue = "Input was empty, try again",
        ShowMessageOnFailure = true,
    };

    /// <summary>
    /// Color to be used for printing errors from the terminal
    /// </summary>
    public ConsoleColor ErrorColor { get; set; }

    /// <summary>
    /// Color to be used for printing warning from the terminal
    /// </summary>
    public ConsoleColor WarningColor { get; set; }
    public ConsoleColor InfoColor { get; set; }

    /// <summary>
    /// Whether an error message should be printed to the terminal when a input error occurs
    /// </summary>
    public bool ShowMessageOnFailure { get; set; }

    private string? backingFieldOutOfRange;

    /// <summary>
    /// Message to be displayed when trying to read a value that is out of range
    /// </summary>
    [MaybeNull]
    public string OutOfRange
    {
        get => backingFieldOutOfRange;
        set
        {
            if (!value.Contains("{0}") || !value.Contains("{1}"))
            {
                throw new InvalidOperationException("Out of range message requires {0} and {1} to be located somewhere in the string");
            }

            backingFieldOutOfRange = value;
        }
    }

    private string? backingFieldNeedsValue;

    /// <summary>
    /// Message to be displayed when the user input is null or empty
    /// </summary>
    [MaybeNull]
    public string NeedsValue
    {
        get => backingFieldNeedsValue;
        set
        {
            backingFieldNeedsValue = value;
        }
    }
}
