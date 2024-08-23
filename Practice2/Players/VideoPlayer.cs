namespace Practice2.Players
{
    public class VideoPlayer : IPlayable
    {
        public string VideoName { get; set; }

        public VideoPlayer(string videoName)
        {
            VideoName = videoName;
        }

        void IPlayable.Pause()
        {
            Console.WriteLine($"Video: {VideoName} paused...");
        }

        void IPlayable.Play()
        {
            Console.WriteLine($"Video: {VideoName} started...");
        }
    }
}
