using System.Collections.Generic;

namespace AlinSpace.SourceGenerator.Namespace
{
    public class Info
    {
        public string Name { get; set; }

        public IList<Class.Info> Classes { get; set; }
    }
}
