namespace ParadoxTerminal;

/// <summary>
/// Bool style options for the terminal
/// </summary>
[Flags]
public enum BoolStyles
{
    /// <summary>
    /// No options for <see cref="BoolStyles"/>, <see cref="bool.TrueString"/> and <see cref="bool.FalseString"/> are only valid
    /// </summary>
    None = 0,

    /// <summary>
    /// If the input string is allowed extra spaces at the end
    /// </summary>
    AllowTrailing = 1 << 0,
    /// <summary>
    /// Default options, and allows for <see cref="bool.TrueString"/> and <see cref="bool.FalseString"/> to be lowercase
    /// </summary>
    AcceptLowerBool = 1 << 1,
    /// <summary>
    /// Accept numeric boolean like 0 and 1 as literals
    /// </summary>
    AcceptNumeric = 1 << 2,

    /// <summary>
    /// Accepts "yes" and "no" as valid boolean constants
    /// </summary>
    AcceptYesAndNo = 1 << 3,

    /// <summary>
    /// Indicates that all options are valid
    /// </summary>
    All = ~None
}
