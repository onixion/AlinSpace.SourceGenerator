using System;
using System.Collections.Generic;

namespace AlinSpace.SourceGenerator.Method
{
    internal class Internal : IMethod
    {
        public string Name { get; set; }

        public AccessModifier AccessModifier { get; set; }

        public string ReturnType { get; set; } = Constants.Void;

        public IList<Attribute.Info> Attributes { get; } = new List<Attribute.Info>();

        public IList<Argument.Info> Arguments { get; } = new List<Argument.Info>();

        public Body.Info BodyInfo { get; set; }

        public IMethod Attribute(Action<IAttribute> action)
        {
            var proxy = new Attribute.Internal();
            action(proxy);
            Attributes.Add(proxy.Build());

            return this;
        }

        public IMethod Argument(Action<IArgument> action)
        {
            var proxy = new Argument.Internal();
            action(proxy);
            Arguments.Add(proxy.Build());

            return this;
        }

        public IMethod Body(Action<IBody> action)
        {
            var proxy = new Body.Internal();
            action(proxy);
            BodyInfo = proxy.Build();

            return this;
        }

        public Info Build()
        {
            return new Info
            {
                Name = Name,
                AccessModifier = AccessModifier,
                Attributes = Attributes,
                Arguments = Arguments,
                Body = BodyInfo,
            };
        }
    }
}
