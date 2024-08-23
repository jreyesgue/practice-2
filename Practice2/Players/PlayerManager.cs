namespace Practice2.Players
{
    public class PlayerManager
    {
        private readonly List<IPlayable> _players;

        public PlayerManager()
        {
            _players = new List<IPlayable>();
        }

        public void AddPlayer(IPlayable player)
        {
            _players.Add(player);
        }

        public void RemovePlayer(IPlayable player)
        {
            _players.Remove(player);
        }

        public void StartAllPlayers()
        {
            _players.ForEach(player => player.Play());
        }

        public void StopAllPlayers()
        {
            _players.ForEach(player => player.Pause());
        }
    }
}
