using System;
using System.Collections.Generic;

namespace AlinSpace.CodeWriter.Namespace
{
    internal class Namespace : INamespace
    {
        public string Name { get; set; }

        public IList<Class.Info> Classes { get; } = new List<Class.Info>();

        public INamespace Class(Action<IClass> action)
        {
            var proxy = new Class.Class();
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
