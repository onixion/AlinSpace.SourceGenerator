namespace AlinSpace.CodeWriter
{
    public static class BodyExtensions
    {
        public static IBody Line(this IBody body, string line)
        {
            body.Line(p => p.Text = line);
            return body;
        }
    }
}
