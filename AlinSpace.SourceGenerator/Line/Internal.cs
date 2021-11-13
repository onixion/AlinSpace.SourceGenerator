namespace AlinSpace.SourceGenerator.Line
{
    internal class Internal : ILine
    {
        public string Text { get; set; }

        public Info Build()
        {
            return new Info(Text);
        }
    }
}
