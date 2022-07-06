using System.Diagnostics.CodeAnalysis;
using ParadoxTerminal.Options;

namespace ParadoxTerminal;

/// <summary>
/// Configuration used to customize the <see cref="Terminal"/>
/// </summary>
public class TerminalConfiguration
{
    private const string DefaultInRange = "You need to enter a value between {0} and {1}";

    private static NumericOptions CreateOption()
    {
        return new NumericOptions()
        {
            InRange = new(2)
            {
                Value = DefaultInRange
            }
        };
    }

    /// <summary>
    /// The default configuration to be used in <see cref="Terminal"/>
    /// </summary>
    public static TerminalConfiguration Default { get; } = new()
    {
        ErrorColor = ConsoleColor.DarkRed,
        WarningColor = ConsoleColor.Red,
        InfoColor = ConsoleColor.Green,
    };

    public TypeOptions Bool { get; } = new()
    {
        ShowErrors = true,
        OnInvalid = "You need to enter a valid boolean"
    };

    #region Integer
    public NumericOptions UInt8 { get; } = CreateOption();

    public NumericOptions Int8 { get; } = CreateOption();

    public NumericOptions UInt16 { get; } = CreateOption();

    public NumericOptions Int16 { get; } = CreateOption();

    public NumericOptions Int32 { get; } = CreateOption();

    public NumericOptions UInt32 { get; } = CreateOption();

    /// <summary>
    /// Options for reading the <see langword="long"/> type from the standard input
    /// </summary>
    /// <remarks>
    /// Applies to ReadInt64 methods
    /// </remarks>
    public NumericOptions Int64 { get; } = CreateOption();

    public NumericOptions UInt64 { get; } = CreateOption();

    public NumericOptions Arbitrary { get; } = CreateOption();

    public NumericOptions Half { get; } = CreateOption();

    public NumericOptions Single { get; } = CreateOption();

    public NumericOptions Double { get; } = CreateOption();

    public NumericOptions Decimal { get; } = CreateOption();

    #endregion

    /// <summary>
    /// Color to be used for printing errors from the terminal
    /// </summary>
    public ConsoleColor ErrorColor { get; set; }

    /// <summary>
    /// Color to be used for printing warning from the terminal
    /// </summary>
    public ConsoleColor WarningColor { get; set; }
    public ConsoleColor InfoColor { get; set; }
}
