using System.Collections.Generic;

namespace AlinSpace.SourceGenerator
{
    public class Build
    {
        public IList<Using.Info> Usings { get; set; }

        public IList<Namespace.Info> Namespaces { get; set; }
    }
}
