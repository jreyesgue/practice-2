namespace Practice2.Utils
{
    public static class Converter
    {
        public static int[] StringToIntArray(string str)
        {
            return str
                .Split(',', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }
    }
}
