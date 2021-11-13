using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace AlinSpace.SourceGenerator.Method
{
    public class Info
    {
        public string Name { get; }

        public AccessModifier AccessModifier { get; }

        public string ReturnType { get; }

        public IList<Attribute.Info> Attributes { get; }

        public IList<Argument.Info> Arguments { get; }

        public Body.Info Body { get; }

        public Info(
            string name,
            AccessModifier accessModifier,
            string returnType,
            IEnumerable<Attribute.Info> attributes,
            IEnumerable<Argument.Info> arguments,
            Body.Info body)
        {
            Name = name;
            AccessModifier = accessModifier;
            ReturnType = returnType;
            Attributes = new ReadOnlyCollection<Attribute.Info>(attributes.ToList());
            Arguments = new ReadOnlyCollection<Argument.Info>(arguments.ToList());
            Body = body;
        }
    }
}
