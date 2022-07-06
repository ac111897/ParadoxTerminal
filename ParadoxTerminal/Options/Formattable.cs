namespace ParadoxTerminal.Options;

public class Formattable
{
    public Formattable(byte formatters)
    {
        _formatters = formatters;
    }

    private readonly byte _formatters;

    public bool IsFormattable = false;

#nullable disable

    private string _formattable;
    public byte PlaceHolders => _formatters;

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
    public string Formatted(params object?[] values)
    {
        if (values.Length != _formatters)
        {
            throw new InvalidOperationException($"Array must have {PlaceHolders} placeholders");
        }

        return string.Format(Value, values);
    }
}
