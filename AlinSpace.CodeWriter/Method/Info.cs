namespace AlinSpace.CodeWriter.Method
{
    public class Info
    {
        public string Name { get; set; }

        public AccessModifier AccessModifier { get; set; }

        public string ReturnType { get; set; }

        public Body.Info Body { get; set; }
    }
}
