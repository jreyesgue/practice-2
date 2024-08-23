namespace Practice2.Players
{
    internal class MusicPlayer : IPlayable
    {
        public string ElementName { get; set; }

        public MusicPlayer(string songName)
        {
            ElementName = songName;
        }

        public void Pause()
        {
            Console.WriteLine($"Music: {ElementName} paused...");
        }

        public void Play()
        {
            Console.WriteLine($"Music: {ElementName} playing...");
        }
    }
}
