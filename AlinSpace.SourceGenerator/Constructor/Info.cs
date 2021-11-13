using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace AlinSpace.SourceGenerator.Constructor
{
    public class Info
    {
        public string ClassName { get; }

        public AccessModifier AccessModifier { get; }

        public IReadOnlyCollection<Argument.Info> Arguments { get; }

        public Body.Info Body { get; }

        public Info(
            string className,
            AccessModifier accessModifier,
            IEnumerable<Argument.Info> arguments,
            Body.Info body)
        {
            ClassName = className;
            AccessModifier = accessModifier;
            Arguments = new ReadOnlyCollection<Argument.Info>(arguments.ToList());
            Body = body;
        }
    }
}
