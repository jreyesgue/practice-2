namespace Practice2.Utils
{
    public static class ConsoleReader
    {
        public static int GetOption()
        {
            Console.Write("\nSelect an option: ");

            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
