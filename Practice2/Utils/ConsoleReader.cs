namespace Practice2.Utils
{
    public static class ConsoleReader
    {
        public static int GetOption()
        {
            Console.Write("\nSelect an option: ");

            return Convert.ToInt32(Console.ReadLine());
        }

        public static string GetStringParam(string message)
        {
            Console.Write(message);

            return Console.ReadLine() ?? string.Empty;
        }

        public static int GetIntParam(string message)
        {
            Console.Write(message);

            return Convert.ToInt32(Console.ReadLine());
        }

        public static double GetDoubleParam(string message)
        {
            Console.Write(message);

            return Convert.ToDouble(Console.ReadLine());
        }

        public static bool GetBoolParam(string message)
        {
            Console.Write(message);

            return Convert.ToBoolean(Console.ReadLine());
        }
    }
}
