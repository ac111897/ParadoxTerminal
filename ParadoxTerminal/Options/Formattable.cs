namespace ParadoxTerminal.Options;

/// <summary>
/// A formattable string used for making strings to must have amount of formatters
/// </summary>
public class Formattable
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Formattable"/> class
    /// </summary>
    /// <param name="formatters"></param>
    public Formattable(byte formatters)
    {
        _formatters = formatters;
    }

    private readonly byte _formatters;

    /// <summary>
    /// Whether the class is formattable
    /// </summary>
    public bool IsFormattable = false;

#nullable disable

    private string _formattable;

    /// <summary>
    /// How many placeholders the caller has to provide
    /// </summary>
    public byte PlaceHolders => _formatters;

    /// <summary>
    /// The raw string value to be provided
    /// </summary>
    public string Value
    {
        get => _formattable;

        set
        {
            for (byte i = 0; i < _formatters; i++)
            {
                if (!value.Contains($"{i}"))
                {
                    throw new InvalidOperationException($"The string you are assigning needs {_formatters} placeholders");
                }
            }

            _formattable = value;
        }
    }

#nullable restore

    /// <summary>
    /// Returns the string with the formatted values, throws <see cref="InvalidOperationException"/> if it has incorrect amount of placeholders
    /// </summary>
    /// <param name="values">Placeholder values to provide</param>
    /// <exception cref="InvalidOperationException">Thrown if incorrect number is provided</exception>
    public string Formatted(params object?[] values)
    {
        if (values.Length != _formatters)
        {
            throw new InvalidOperationException($"Array must have {PlaceHolders} placeholders");
        }

        return string.Format(Value, values);
    }
}
