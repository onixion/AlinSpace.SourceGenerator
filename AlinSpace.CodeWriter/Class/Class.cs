using System;
using System.Collections.Generic;

namespace AlinSpace.CodeWriter.Class
{
    internal class Class : IClass
    {
        public string Name { get; set; }

        public AccessModifier AccessModifier { get; set; }

        public bool IsStatic { get; set; }

        public IList<Method.Info> Methods { get; } = new List<Method.Info>();


        public IClass Constructor(Action<IConstructor> action)
        {
            return this;
        }

        public IClass Method(Action<IMethod> action)
        {
            var proxy = new Method.Method();
            action(proxy);
            Methods.Add(proxy.Build());

            return this;
        }

        public IClass Property(Action<IProperty> action)
        {
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
