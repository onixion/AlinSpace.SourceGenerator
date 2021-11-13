namespace AlinSpace.SourceGenerator.Property
{
    public class Info
    {
        public AccessModifier AccessModifier { get; }

        public string Type { get; set; }

        public string Name { get; }

        public Getter.Info Getter { get; }

        public Setter.Info Setter { get; }

        public Info(
            AccessModifier accessModifier,
            string type,
            string name,
            Getter.Info getter,
            Setter.Info setter)
        {
            AccessModifier = accessModifier;
            Type = type;
            Name = name;
            Getter = getter;
            Setter = setter;
        }
    }
}
