using StoryGame.ConsoleUI.ConsoleScreens;
using StoryGame.ConsoleUI.Models;
using StoryGame.ConsoleUI.ScreenPrinters;

namespace StoryGame.ConsoleUI.Workflow
{
    public static class GameScreens
    {
        public const string StartingKey = "TheKeyToStartItAll";

        public const string EndingKey = "TheKeyToEndItAll";

        public static readonly Dictionary<string, ConsoleScreen> ScreenDictionary;

        static GameScreens()
        {
            var printer = new SimplePrinter();
            var centeredPrinter = new CenteredPrinter(Console.WindowWidth);

            ScreenDictionary = new()
            {
                {StartingKey, new AnyKeyToContinue(ScreenMessages.ScreenOneContent, nextScreenKey: ScreenKeys.ScreenTwo, printer) },
                {ScreenKeys.ScreenTwo, new AnyKeyToContinue(ScreenMessages.ScreenTwoContent, nextScreenKey: ScreenKeys.ScreenThree, centeredPrinter) },
                {ScreenKeys.ScreenThree, new AnyKeyToContinue(ScreenMessages.ScreenThreeContent, EndingKey, printer) },
            };
        }

        private static class ScreenKeys
        {
            public const string ScreenTwo = "SecondScreen";
            public const string ScreenThree = "ThirdScreen";
            public const string LastScreen = "LastScreen";
        }

        private static class ScreenMessages
        {
            public static readonly string[] ScreenOneContent = new[] { "", "This is the first screen.", "", "Press any key to continue!" }; 
            public static readonly string[] ScreenTwoContent = new[] { "", "This is the second screen.", "", "This one uses a CenteredPrinter" };
            public static readonly string ScreenThreeContent = "This is the last screen - back to the SimplePrinter";
        }
    }
}
