namespace Practice2.Players
{
    public interface IPlayable
    {
        string ElementName { get; set; }

        void Play();
        void Pause();
    }
}
