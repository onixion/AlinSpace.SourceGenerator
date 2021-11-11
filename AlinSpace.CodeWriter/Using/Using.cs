namespace AlinSpace.CodeWriter.Using
{
    internal class Using : IUsing
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
