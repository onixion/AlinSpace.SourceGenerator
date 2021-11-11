using System.Collections.Generic;

namespace AlinSpace.CodeWriter
{
    public class Build
    {
        public IList<Using.Info> Usings { get; set; }

        public IList<Namespace.Info> Namespaces { get; set; }
    }
}
