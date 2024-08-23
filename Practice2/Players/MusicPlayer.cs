namespace Practice2.Players
{
    internal class MusicPlayer : IPlayable
    {
        public string SongName { get; set; }

        public MusicPlayer(string songName)
        {
            SongName = songName;
        }

        public void Pause()
        {
            Console.WriteLine($"Music: {SongName} paused...");
        }

        public void Play()
        {
            Console.WriteLine($"Music: {SongName} playing...");
        }
    }
}
