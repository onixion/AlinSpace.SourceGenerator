namespace AlinSpace.CodeWriter
{
    public static class ArgumentsExtensions
    {
        public static IArguments Argument(
            this IArguments arguments,
            string text)
        {
            return arguments.Argument(p =>
            {
                p.Text = text;
            });
        }
    }
}
