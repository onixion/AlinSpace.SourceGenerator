using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace AlinSpace.SourceGenerator.Namespace
{
    public class Info
    {
        public string Name { get; }

        public IReadOnlyCollection<Class.Info> Classes { get; }

        public Info(
            string name,
            IEnumerable<Class.Info> classes)
        {
            Name = name;
            Classes = new ReadOnlyCollection<Class.Info>(classes.ToList());
        }
    }
}
