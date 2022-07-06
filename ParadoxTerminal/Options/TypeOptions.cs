namespace ParadoxTerminal.Options;

/// <summary>
/// Type options for most types in the terminal
/// </summary>
public class TypeOptions
{
    /// <summary>
    /// Whether <see cref="Terminal"/> should display error messages when using <see cref="Terminal.ReadBool(BoolStyles)"/>
    /// </summary>
    public bool ShowErrors { get; set; } = true;

    /// <summary>
    /// On empty/null value provided
    /// </summary>
    public string OnEmpty { get; set; } = "You need to enter a value";

#nullable disable
    /// <summary>
    /// On invalid parse option
    /// </summary>
    public string OnInvalid { get; set; }
}
