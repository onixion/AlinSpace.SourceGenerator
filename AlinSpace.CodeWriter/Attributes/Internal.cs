using System;
using System.Collections.Generic;

namespace AlinSpace.CodeWriter.Attributes
{
    internal class Internal : IAttributes
    {
        public string Name { get; set; }

        public IList<Attribute.Info> Attributes { get; } = new List<Attribute.Info>();

        public IAttributes Attribute(Action<IAttribute> action)
        {
            var proxy = new Attribute.Internal();
            action(proxy);
            Attributes.Add(proxy.Build());

            return this;
        }

        public Info Build()
        {
            return new Info
            {
                Name = Name,
                Attributes = Attributes,
            };
        }
    }
}
