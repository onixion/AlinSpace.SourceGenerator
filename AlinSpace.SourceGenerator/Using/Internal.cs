namespace AlinSpace.SourceGenerator.Using
{
    internal class Internal : IUsing
    {
        public string Name { get; set; }

        public Info Build()
        {
            return new Info()
            {
                Name = Name,
            };
        }
    }
}
