using System;
using System.Collections.Generic;

namespace AlinSpace.SourceGenerator.Constructor
{
    internal class Internal : IConstructor
    {
        public AccessModifier AccessModifier { get; set; }

        public IList<Argument.Info> Arguments { get; } = new List<Argument.Info>();

        public Body.Info BodyInfo { get; set; }

        public IConstructor Argument(Action<IArgument> action)
        {
            var proxy = new Argument.Internal();
            action(proxy);
            Arguments.Add(proxy.Build());

            return this;
        }

        public IConstructor Body(Action<IBody> action)
        {
            var proxy = new Body.Internal();
            action(proxy);
            BodyInfo = proxy.Build();

            return this;
        }

        public Info Build(IClass @class)
        {
            return new Info
            {
                ClassName = @class.Name,
                AccessModifier = AccessModifier,
                Arguments = Arguments,
                Body = BodyInfo,
            };
        }
    }
}
