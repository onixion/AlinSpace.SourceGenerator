using System;
using System.Collections.Generic;

namespace AlinSpace.SourceGenerator.Namespace
{
    internal class Internal : INamespace
    {
        public string Name { get; set; }

        public IList<Class.Info> Classes { get; } = new List<Class.Info>();

        public INamespace Class(Action<IClass> action)
        {
            var proxy = new Class.Internal();
            action(proxy);
            Classes.Add(proxy.Build());

            return this;
        }

        public Info Build()
        {
            return new Info()
            {
                Name = Name,
                Classes = Classes,
            };
        }
    }
}
