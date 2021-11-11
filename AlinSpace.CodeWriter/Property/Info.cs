namespace AlinSpace.CodeWriter.Property
{
    public class Info
    {
        public string Type { get; set; }

        public string Name { get; set; }

        public Getter.Info Getter { get; set; }

        public Setter.Info Setter { get; set; }
    }
}
