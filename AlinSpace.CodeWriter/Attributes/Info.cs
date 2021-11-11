using System.Collections.Generic;

namespace AlinSpace.CodeWriter.Attributes
{
    public class Info
    {
        public string Name { get; set; }

        public IList<Attribute.Info> Attributes { get; set; }
    }
}
