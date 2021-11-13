using System;
using System.Collections.Generic;

namespace AlinSpace.SourceGenerator.Namespace
{
    internal class Internal : INamespace
    {
        public string Name { get; set; }

        private readonly IList<Class.Info> classes = new List<Class.Info>();

        public INamespace Class(Action<IClass> action)
        {
            var proxy = new Class.Internal();
            action(proxy);
            classes.Add(proxy.Build());

            return this;
        }

        public Info Build()
        {
            return new Info(
                Name,
                classes);
        }
    }
}
