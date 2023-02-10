using StoryGame.ConsoleUI.Models;
using StoryGame.ConsoleUI.Workflow;

namespace StoryGame.ConsoleUI.ConsoleScreens
{
    public class AnyKeyToContinue : ConsoleScreen
    {
        private readonly IEnumerable<string> _content;

        private readonly string _nextScreenKey;

        private readonly ScreenPrinter _printer;

        public AnyKeyToContinue(IEnumerable<string> content, string nextScreenKey, ScreenPrinter screenPrinter)
        {
            _content = content;
            _nextScreenKey = nextScreenKey;
            _printer = screenPrinter;
        }

        public AnyKeyToContinue(string content, string nextScreenKey, ScreenPrinter screenPrinter) 
            : this(new[] {content}, nextScreenKey, screenPrinter) { }

        public override string ProcessScreen()
        {
            _printer.ClearAndPrint(_content);

            Console.ReadKey();

            return _nextScreenKey;
        }
    }
}
