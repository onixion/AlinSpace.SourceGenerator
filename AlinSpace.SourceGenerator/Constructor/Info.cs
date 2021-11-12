using System.Collections.Generic;

namespace AlinSpace.SourceGenerator.Constructor
{
    public class Info
    {
        public string ClassName { get; set; }

        public AccessModifier AccessModifier { get; set; }

        public IList<Argument.Info> Arguments { get; set; }

        public Body.Info Body { get; set; }
    }
}
