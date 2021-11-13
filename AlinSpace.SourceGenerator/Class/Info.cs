using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace AlinSpace.SourceGenerator.Class
{
    public class Info
    {
        public string Name { get; }

        public AccessModifier AccessModifier { get; }

        public IReadOnlyCollection<Member.Info> Members { get; }

        public IReadOnlyCollection<Property.Info> Properties { get; }

        public IReadOnlyCollection<Constructor.Info> Constructors { get; }

        public IReadOnlyCollection<Method.Info> Methods { get; }

        public Info(
            string name,
            AccessModifier accessModifier,
            IEnumerable<Member.Info> members,
            IEnumerable<Property.Info> properties,
            IEnumerable<Constructor.Info> constructors,
            IEnumerable<Method.Info> methods)
        {
            Name = name;
            AccessModifier = accessModifier;
            Members = new ReadOnlyCollection<Member.Info>(members.ToList());
            Properties = new ReadOnlyCollection<Property.Info>(properties.ToList());
            Constructors = new ReadOnlyCollection<Constructor.Info>(constructors.ToList());
            Methods = new ReadOnlyCollection<Method.Info>(methods.ToList());
        }
    }
}
