using System;
using System.Collections.Generic;

namespace AlinSpace.SourceGenerator.Method
{
    internal class Internal : IMethod
    {
        public string Name { get; set; }

        public AccessModifier AccessModifier { get; set; }

        public string ReturnType { get; set; } = Constants.Void;

        private readonly IList<Attribute.Info> attributes = new List<Attribute.Info>();

        public IMethod Attribute(Action<IAttribute> action)
        {
            var proxy = new Attribute.Internal();
            action(proxy);
            attributes.Add(proxy.Build());
            return this;
        }

        private readonly IList<Argument.Info> arguments = new List<Argument.Info>();

        public IMethod Argument(Action<IArgument> action)
        {
            var proxy = new Argument.Internal();
            action(proxy);
            arguments.Add(proxy.Build());
            return this;
        }

        private Body.Info body;

        public IMethod Body(Action<IBody> action)
        {
            var proxy = new Body.Internal();
            action(proxy);
            body = proxy.Build();
            return this;
        }

        public Info Build()
        {
            return new Info(
                Name,
                AccessModifier,
                ReturnType,
                attributes,
                arguments,
                body);
        }
    }
}
