namespace AlinSpace.SourceGenerator
{
    public static partial class MethodExtensions
    {
        public static IMethod Argument(
            this IMethod method,
            string text)
        {
            method.Argument(p =>
            {
                p.Text = text;
            });

            return method;
        }
    }
}
