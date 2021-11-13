using System;
using System.Collections.Generic;

namespace AlinSpace.SourceGenerator.Constructor
{
    internal class Internal : IConstructor
    {
        public AccessModifier AccessModifier { get; set; }

        private readonly IList<Argument.Info> arguments = new List<Argument.Info>();

        public IConstructor Argument(Action<IArgument> action)
        {
            var proxy = new Argument.Internal();
            action(proxy);
            arguments.Add(proxy.Build());

            return this;
        }

        private Body.Info body;

        public IConstructor Body(Action<IBody> action)
        {
            var proxy = new Body.Internal();
            action(proxy);
            body = proxy.Build();

            return this;
        }

        public Info Build(IClass @class)
        {
            return new Info(
                @class.Name,
                AccessModifier,
                arguments,
                body);
        }
    }
}
