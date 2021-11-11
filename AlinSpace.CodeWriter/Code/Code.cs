using System;
using System.Collections.Generic;

namespace AlinSpace.CodeWriter
{
    public class Code : ICode
    {
        public IList<Using.Info> Usings { get; } = new List<Using.Info>();

        public IList<Namespace.Info> Namespaces { get; } = new List<Namespace.Info>();

        public static Code New()
        {
            return new Code();
        }

        public ICode Using(Action<IUsing> action)
        {
            var proxy = new Using.Using();
            action(proxy);
            Usings.Add(proxy.Build());

            return this;
        }

        public ICode Namespace(Action<INamespace> action)
        {
            var proxy = new Namespace.Namespace();
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
