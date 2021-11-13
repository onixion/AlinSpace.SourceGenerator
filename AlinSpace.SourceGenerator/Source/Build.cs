using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace AlinSpace.SourceGenerator
{
    public class Build
    {
        public IReadOnlyCollection<Using.Info> Usings { get; }

        public IReadOnlyCollection<Namespace.Info> Namespaces { get; }

        public Build(
            IEnumerable<Using.Info> usings,
            IEnumerable<Namespace.Info> namespaces)
        {
            Usings = new ReadOnlyCollection<Using.Info>(usings.ToList());
            Namespaces = new ReadOnlyCollection<Namespace.Info>(Namespaces.ToList());
        }
    }
}
