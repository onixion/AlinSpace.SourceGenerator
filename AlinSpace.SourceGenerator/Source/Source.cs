using System;
using System.Collections.Generic;

namespace AlinSpace.SourceGenerator
{
    public class Source : ISource
    {
        public IList<Using.Info> Usings { get; } = new List<Using.Info>();

        public IList<Namespace.Info> Namespaces { get; } = new List<Namespace.Info>();

        public static Source New()
        {
            return new Source();
        }

        public ISource Using(Action<IUsing> action)
        {
            var proxy = new Using.Internal();
            action(proxy);
            Usings.Add(proxy.Build());

            return this;
        }

        public ISource Namespace(Action<INamespace> action)
        {
            var proxy = new Namespace.Internal();
            action(proxy);
            Namespaces.Add(proxy.Build());

            return this;
        }

        public Build Build()
        {
            return new Build
            {
                Usings = Usings,
                Namespaces = Namespaces,
            };
        }
    }
}
