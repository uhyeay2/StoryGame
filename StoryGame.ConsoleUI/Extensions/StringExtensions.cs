namespace StoryGame.ConsoleUI.Extensions
{
    public static class StringExtensions
    {
        public static string CenterText(this string text, int targetLength)
        {
            if(string.IsNullOrWhiteSpace(text))
            {
                return new string(' ', targetLength);
            }

            if(text.Length > targetLength )
            {
                throw new ArgumentOutOfRangeException(nameof(text));
            }

            var centerPoint = targetLength / 2;

            var leftPadding = centerPoint - (text.Length / 2);

            var targetSizeAfterLeftPadding = leftPadding + text.Length;

            return text.PadLeft(targetSizeAfterLeftPadding).PadRight(targetLength);
        }
    }
}
