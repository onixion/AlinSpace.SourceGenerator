using System;
using System.Collections.Generic;

namespace AlinSpace.SourceGenerator.Class
{
    internal class Internal : IClass
    {
        public string Name { get; set; }

        public AccessModifier AccessModifier { get; set; }

        public bool IsStatic { get; set; }

        public IList<Member.Info> Members { get; } = new List<Member.Info>();

        public IList<Property.Info> Properties { get; } = new List<Property.Info>();

        public IList<Constructor.Info> Constructors { get; } = new List<Constructor.Info>();

        public IList<Method.Info> Methods { get; } = new List<Method.Info>();

        public IClass Member(Action<IMember> action)
        {
            var proxy = new Member.Internal();
            action(proxy);
            Members.Add(proxy.Build());

            return this;
        }

        public IClass Property(Action<IProperty> action)
        {
            var proxy = new Property.Internal();
            action(proxy);
            Properties.Add(proxy.Build());

            return this;
        }

        public IClass Constructor(Action<IConstructor> action)
        {
            var proxy = new Constructor.Internal();
            action(proxy);
            Constructors.Add(proxy.Build(this));

            return this;
        }

        public IClass Method(Action<IMethod> action)
        {
            var proxy = new Method.Internal();
            action(proxy);
            Methods.Add(proxy.Build());

            return this;
        }

        public Info Build()
        {
            return new Info
            {
                Name = Name,
                AccessModifier = AccessModifier,
                Members = Members,
                Properties = Properties,
                Constructors = Constructors,
                Methods = Methods,
            };
        }
    }
}
