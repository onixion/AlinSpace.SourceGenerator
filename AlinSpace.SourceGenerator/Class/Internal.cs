using System;
using System.Collections.Generic;

namespace AlinSpace.SourceGenerator.Class
{
    internal class Internal : IClass
    {
        public string Name { get; set; }

        public AccessModifier AccessModifier { get; set; }

        public bool IsStatic { get; set; }

        private readonly IList<Member.Info> members = new List<Member.Info>();

        public IClass Member(Action<IMember> action)
        {
            var proxy = new Member.Internal();
            action(proxy);
            members.Add(proxy.Build());

            return this;
        }

        private readonly IList<Property.Info> properties = new List<Property.Info>();

        public IClass Property(Action<IProperty> action)
        {
            var proxy = new Property.Internal();
            action(proxy);
            properties.Add(proxy.Build());

            return this;
        }

        private readonly IList<Constructor.Info> constructors = new List<Constructor.Info>();

        public IClass Constructor(Action<IConstructor> action)
        {
            var proxy = new Constructor.Internal();
            action(proxy);
            constructors.Add(proxy.Build(this));

            return this;
        }

        private readonly IList<Method.Info> methods = new List<Method.Info>();

        public IClass Method(Action<IMethod> action)
        {
            var proxy = new Method.Internal();
            action(proxy);
            methods.Add(proxy.Build());

            return this;
        }

        public Info Build()
        {
            return new Info(
                Name,
                AccessModifier,
                members,
                properties,
                constructors,
                methods);
        }
    }
}
