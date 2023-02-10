using StoryGame.ConsoleUI.Extensions;
using StoryGame.ConsoleUI.Workflow;

namespace StoryGame.ConsoleUI.ScreenPrinters
{
    internal class CenteredPrinter : ScreenPrinter
    {
        private readonly int _width;

        public CenteredPrinter(int width)
        {
            _width = width;
        }

        public override void Print(IEnumerable<string> content)
        {
            foreach (var line in content)
            {
                Console.WriteLine(line.CenterText(_width));
            }
        }
    }
}
