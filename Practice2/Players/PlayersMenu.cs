using Practice2.Utils;

namespace Practice2.Players
{
    public class PlayersMenu
    {
        private PlayerManager _playerManager;

        public PlayersMenu()
        {
            _playerManager = new PlayerManager();
        }

        public void StartMenu()
        {
            bool finish = false;

            do
            {
                DisplayMenu();

                switch (ConsoleReader.GetOption())
                {
                    case 1:
                        CreateMusicPlayer();
                        break;
                    case 2:
                        CreateVideoPlayer();
                        break;
                    case 3:
                        DeletePlayer();
                        break;
                    case 4:
                        Console.WriteLine();
                        _playerManager.StartAllPlayers();
                        break;
                    case 5:
                        Console.WriteLine();
                        _playerManager.StopAllPlayers();
                        break;
                    case 6:
                        Console.WriteLine("\nReturning to main menu...\n");
                        finish = true;
                        break;
                    default:
                        Console.WriteLine("\nInvalid option. Try Again.");
                        break;
                }
            } while (!finish);
        }

        private void CreateMusicPlayer()
        {
            string playerSong = ConsoleReader.GetStringParam("\nEnter the song to play: ");

            _playerManager.AddPlayer(new MusicPlayer(playerSong));
        }

        private void CreateVideoPlayer()
        {
            string playerVideo = ConsoleReader.GetStringParam("\nEnter the video to play: ");

            _playerManager.AddPlayer(new VideoPlayer(playerVideo));
        }

        private void DeletePlayer()
        {
            string playerName = ConsoleReader.GetStringParam("\nEnter the player's name: ");

            _playerManager.RemovePlayer(playerName);
        }

        private static void DisplayMenu()
        {
            Console.WriteLine("\n--- Players Menu ---\n");
            Console.WriteLine("1. Add music player.");
            Console.WriteLine("2. Add video player.");
            Console.WriteLine("3. Remove player.");
            Console.WriteLine("4. Start players.");
            Console.WriteLine("5. Stop players.");
            Console.WriteLine("6. Exit.");
        }
    }
}
