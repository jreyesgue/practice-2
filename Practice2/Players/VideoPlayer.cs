namespace Practice2.Players
{
    public class VideoPlayer : IPlayable
    {
        public string ElementName { get; set; }

        public VideoPlayer(string videoName)
        {
            ElementName = videoName;
        }

        void IPlayable.Pause()
        {
            Console.WriteLine($"Video: {ElementName} paused...");
        }

        void IPlayable.Play()
        {
            Console.WriteLine($"Video: {ElementName} started...");
        }
    }
}
