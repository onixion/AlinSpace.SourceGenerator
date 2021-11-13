namespace AlinSpace.SourceGenerator.Argument
{
    internal class Internal : IArgument
    {
        public string Text { get; set; }

        public Info Build()
        {
            return new Info(Text);
        }
    }
}
