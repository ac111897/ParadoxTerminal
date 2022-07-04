using System.Diagnostics.CodeAnalysis;

namespace ParadoxTerminal;

public static partial class Terminal
{
    private const string YesString = "Yes";
    private const string NoString = "No";

    /// <summary>
    /// Reads a <see cref="bool"/> from the standard input
    /// </summary>
    /// <param name="showErrorMessage">Whether an error message should be displayed on failure</param>
    /// <param name="options">Bool input options</param>
    /// <returns><see cref="bool"/> from the standard input</returns>
    public static bool ReadBool(bool? showErrorMessage = null, BoolStyles options = BoolStyles.AcceptLowerBool)
    {
        showErrorMessage ??= Configuration.ShowMessageOnFailure;

        return options switch // TODO: Match all styles to proper bit flags
        {
            BoolStyles.AllowTrailing => ReadExactBoolean(showErrorMessage.Value, true),
            BoolStyles.AcceptLowerBool => ReadExactBoolean(showErrorMessage.Value, false, StringComparison.OrdinalIgnoreCase),
            BoolStyles.AllowTrailing | BoolStyles.AcceptLowerBool => ReadExactBoolean(showErrorMessage.Value, true, StringComparison.OrdinalIgnoreCase),
            BoolStyles.AcceptNumeric => ReadExactBoolean(showErrorMessage.Value, false, StringComparison.Ordinal, true),
            BoolStyles.AllowTrailing | BoolStyles.AcceptNumeric => ReadExactBoolean(showErrorMessage.Value, true, StringComparison.Ordinal, true),
            BoolStyles.AllowTrailing | BoolStyles.AcceptNumeric | BoolStyles.AcceptLowerBool => ReadExactBoolean(showErrorMessage.Value, true, StringComparison.OrdinalIgnoreCase, true),
            BoolStyles.AcceptYesAndNo => ReadExactBoolean(showErrorMessage.Value, false, StringComparison.OrdinalIgnoreCase),
            BoolStyles.AcceptLowerBool | BoolStyles.AcceptYesAndNo => ReadExactBoolean(showErrorMessage.Value, false, StringComparison.OrdinalIgnoreCase, false, true),
            BoolStyles.All => ReadExactBoolean(showErrorMessage.Value, true, StringComparison.OrdinalIgnoreCase, true, true),
            _ => ReadExactBoolean(showErrorMessage.Value),
        };
    }

    private static bool ReadExactBoolean(bool showError, 
        bool trim = false, 
        StringComparison comparison = StringComparison.Ordinal,
        bool allowNumeric = false,
        bool yesAndNo = false)
    {
        while (true)
        {
            ReadOnlySpan<char> input = Console.In.ReadLine();

            if (trim)
            {
                input = input.Trim();
            }

            if (input.IsEmpty || input.IsWhiteSpace())
            {
                if (showError || Configuration.ShowMessageOnFailure)
                {
                    WriteLineError(Configuration.NeedsValue);
                }
                continue;
            }

            if (TryCompare(input, comparison, allowNumeric, yesAndNo, out bool? value))
            {
                return value.Value;
            }
            else
            {
                WriteLineError("You need to enter a boolean value");
                continue;
            }
        }
    }
    public static bool TryCompare(ReadOnlySpan<char> input, 
        StringComparison compare,
        bool allowNumeric,
        bool allowYesAndNo,
        [NotNullWhen(true)] out bool? value)
    {
        if (input.CompareTo(bool.TrueString, compare) == 0)
        {
            value = true;
            return true;
        }
        else if (input.CompareTo(bool.FalseString, compare) == 0)
        {
            value = false;
            return true;
        }

        if (allowYesAndNo)
        {
            if (input.CompareTo(YesString, compare) == 0)
            {
                value = true;
                return false;
            }
            else if (input.CompareTo(NoString, compare) == 0)
            {
                value = false;
                return true;
            }
        }

        if (allowNumeric)
        {
            if (input.CompareTo("0", compare) == 0)
            {
                value = false;
                return true;
            }
            else if (input.CompareTo("1", compare) == 0)
            {
                value = true;
                return true;
            }
        }

        value = null;
        return false;
    }
}
