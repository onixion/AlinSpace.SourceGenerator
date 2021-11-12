namespace AlinSpace.SourceGenerator.Member
{
    internal class Internal : IMember
    {
        public string Text { get; set; }

        public Info Build()
        {
            return new Info
            {
                Text = Text,
            };
        }
    }
}
