public static class StringHelper
{
    public static string Prefix(string str, char prefix, int length)
    {
        return str.PadLeft(length, prefix);
    }

    public static string StripPrefix(string str, char prefix)
    {
        return str.TrimStart(new Char[] { prefix });
    }
}
