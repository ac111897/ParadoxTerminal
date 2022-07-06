namespace ParadoxTerminal.Options;

public class NumericOptions : TypeOptions
{
    /// <summary>
    /// The in range that the number has to be
    /// </summary>
    public Formattable InRange { get; set; } = new(2);
}
