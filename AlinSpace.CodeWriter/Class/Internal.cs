using System;
using System.Collections.Generic;

namespace AlinSpace.CodeWriter.Class
{
    internal class Internal : IClass
    {
        public string Name { get; set; }

        public AccessModifier AccessModifier { get; set; }

        public bool IsStatic { get; set; }

        public IList<Property.Info> Properties { get; } = new List<Property.Info>();

        public IList<Method.Info> Methods { get; } = new List<Method.Info>();

        public IClass Constructor(Action<IConstructor> action)
        {
            return this;
        }

        public IClass Method(Action<IMethod> action)
        {
            var proxy = new Method.Internal();
            action(proxy);
            Methods.Add(proxy.Build());

            return this;
        }

        public IClass Property(Action<IProperty> action)
        {
            var proxy = new Property.Internal();
            action(proxy);
            Properties.Add(proxy.Build());

            return this;
        }

        public IClass Member(Action<IMember> action)
        {
            return this;
        }

        public Info Build()
        {
            return new Info();
        }
    }
}
