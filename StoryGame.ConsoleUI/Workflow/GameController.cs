using StoryGame.ConsoleUI.Models;

namespace StoryGame.ConsoleUI.Workflow
{
    public class GameController
    {
        private readonly Dictionary<string, ConsoleScreen> _screens;

        public GameController(Dictionary<string, ConsoleScreen> screens)
        {
            _screens = screens;
        }

        public void Start(string startingKey, string endingKey)
        {
            var screenKey = startingKey;

            while (screenKey != endingKey)
            {
                var screen = _screens[screenKey];
                screenKey = screen.ProcessScreen();
            }
        }

    }
}
