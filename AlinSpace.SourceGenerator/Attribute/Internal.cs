namespace AlinSpace.SourceGenerator.Attribute
{
    internal class Internal : IAttribute
    {
        public string Text { get; set; }

        public Info Build()
        {
            return new Info(Text);
        }
    }
}
