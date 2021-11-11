using System;
using System.Collections.Generic;

namespace AlinSpace.CodeWriter.Arguments
{
    internal class Internal : IArguments
    {
        public IList<Argument.Info> Arguments { get; } = new List<Argument.Info>();

        public IArguments Argument(Action<IArgument> action)
        {
            var proxy = new Argument.Internal();
            action(proxy);
            Arguments.Add(proxy.Build());

            return this; 
        }

        public Info Build()
        {
            return new Info
            {
                Arguments = Arguments,
            };
        }
    }
}
