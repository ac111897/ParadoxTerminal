namespace ParadoxTerminal.Showcase;

public class Program
{
    public static void Main(string[] args)
    {
        Terminal.WriteLine("Paradox Terminal Showcase");

        bool test = Terminal.ReadBool(options: BoolStyles.AcceptNumeric);

        Console.WriteLine(test);
    }
}
