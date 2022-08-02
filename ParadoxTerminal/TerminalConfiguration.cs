using System.Diagnostics.CodeAnalysis;
using System.Numerics;
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

    /// <summary>
    /// Type options for reading <see cref="bool"/>
    /// </summary>
    public TypeOptions Bool { get; } = new()
    {
        ShowErrors = true,
        OnInvalid = "You need to enter a valid boolean"
    };

    #region Integer

    /// <summary>
    /// Type options for reading <see cref="byte"/>
    /// </summary>
    public NumericOptions UInt8 { get; } = CreateOption();

    /// <summary>
    /// Type options for reading <see cref="sbyte"/>
    /// </summary>
    public NumericOptions Int8 { get; } = CreateOption();

    /// <summary>
    /// Type options for reading <see cref="ushort"/>
    /// </summary>
    public NumericOptions UInt16 { get; } = CreateOption();

    /// <summary>
    /// Type options for reading <see cref="short"/>
    /// </summary>
    public NumericOptions Int16 { get; } = CreateOption();

    /// <summary>
    /// Type options for reading <see cref="int"/>
    /// </summary>
    public NumericOptions Int32 { get; } = CreateOption();

    /// <summary>
    /// Type options for reading <see cref="uint"/>
    /// </summary>
    public NumericOptions UInt32 { get; } = CreateOption();

    /// <summary>
    /// Type options for reading <see cref="long"/>
    /// </summary>
    public NumericOptions Int64 { get; } = CreateOption();

    /// <summary>
    /// Type options for reading <see cref="ulong"/>
    /// </summary>
    public NumericOptions UInt64 { get; } = CreateOption();

#if NET7_0_OR_GREATER
    /// <summary>
    /// Type options for reading <see cref="System.Int128"/>
    /// </summary>
    public NumericOptions Int128 { get; } = CreateOption();

    /// <summary>
    /// Type options for reading <see cref="System.UInt128"/>
    /// </summary>
    public NumericOptions UInt128 { get; } = CreateOption();
#endif

    /// <summary>
    /// Type options for reading <see cref="BigInteger"/>
    /// </summary>
    public NumericOptions Arbitrary { get; } = CreateOption();

#if NET5_0_OR_GREATER
    /// <summary>
    /// Type options for reading <see cref="System.Half"/>
    /// </summary>
    public NumericOptions Half { get; } = CreateOption();
#endif

    /// <summary>
    /// Type options for reading <see cref="float"/>
    /// </summary>
    public NumericOptions Single { get; } = CreateOption();
    
    /// <summary>
    /// Type options for reading <see cref="double"/> 
    /// </summary>
    public NumericOptions Double { get; } = CreateOption();

    /// <summary>
    /// Type options for reading <see cref="decimal"/>
    /// </summary>
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

    /// <summary>
    /// Color to be used for printing information to the console
    /// </summary>
    public ConsoleColor InfoColor { get; set; }
}
