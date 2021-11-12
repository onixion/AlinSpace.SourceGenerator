namespace AlinSpace.SourceGenerator.Property
{
    public class Info
    {
        public AccessModifier AccessModifier { get; set; }

        public string Type { get; set; }

        public string Name { get; set; }

        public Getter.Info Getter { get; set; }

        public Setter.Info Setter { get; set; }
    }
}
