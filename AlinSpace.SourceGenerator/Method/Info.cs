using System.Collections.Generic;

namespace AlinSpace.SourceGenerator.Method
{
    public class Info
    {
        public string Name { get; set; }

        public AccessModifier AccessModifier { get; set; }

        public string ReturnType { get; set; }

        public IList<Attribute.Info> Attributes { get; set; }

        public IList<Argument.Info> Arguments { get; set; }

        public Body.Info Body { get; set; }
    }
}
