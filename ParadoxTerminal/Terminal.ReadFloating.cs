using System.Globalization;

namespace ParadoxTerminal;

public static partial class Terminal
{
    public static Half ReadHalf(NumberStyles style = NumberStyles.Float)
    {
        return ReadNumericInternal(in Half, style, Configuration.Half);
    }
    public static Half ReadHalf(Half min, Half max, NumberStyles style = NumberStyles.Float)
    {
        return ReadNumericInternal(min, max, in Half, style, Configuration.Half);
    }
    public static float ReadSingle(NumberStyles style = NumberStyles.Float)
    {
        return ReadNumericInternal(in Float, style, Configuration.Single);
    }
    public static float ReadSingle(float min, float max, NumberStyles style = NumberStyles.Float)
    {
        return ReadNumericInternal(min, max, in Float, style, Configuration.Single);
    }
    public static double ReadDouble(NumberStyles style = NumberStyles.Float)
    {
        return ReadNumericInternal(in Double, style, Configuration.Double);
    }
    public static double ReadDouble(double min, double max, NumberStyles style = NumberStyles.Float)
    {
        return ReadNumericInternal(min, max, in Double, style, Configuration.Double);
    }
    public static decimal ReadDecimal(NumberStyles style = NumberStyles.Float)
    {
        return ReadNumericInternal(in Decimal, style, Configuration.Decimal);
    }

    public static decimal ReadDecimal(decimal min, decimal max, NumberStyles style = NumberStyles.Float)
    {
        return ReadNumericInternal(min, max, in Decimal, style, Configuration.Decimal);
    }
}
