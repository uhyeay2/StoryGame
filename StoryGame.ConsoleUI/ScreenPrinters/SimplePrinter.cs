using StoryGame.ConsoleUI.Workflow;

namespace StoryGame.ConsoleUI.ScreenPrinters
{
    public class SimplePrinter : ScreenPrinter
    {
        public override void Print(IEnumerable<string> content)
        {
            foreach (var line in content)
            {
                Console.WriteLine(line);
            }
        }
    }
}
