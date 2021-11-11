using System.Collections.Generic;

namespace AlinSpace.CodeWriter.Class
{
    public class Info
    {
        public string Name { get; set; }

        public AccessModifier AccessModifier { get; set; }

        public IList<Method.Info> Methods { get; set; }
    }
}
