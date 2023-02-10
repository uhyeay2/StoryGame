namespace StoryGame.ConsoleUI.Workflow
{
    public abstract class ScreenPrinter
    {
        public abstract void Print(IEnumerable<string> content);

        public void ClearAndPrint(IEnumerable<string> content)
        {
            Console.Clear();

            Print(content);
        }
    }
}
