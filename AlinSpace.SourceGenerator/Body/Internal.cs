using System;
using System.Collections.Generic;

namespace AlinSpace.SourceGenerator.Body
{
    internal class Internal : IBody
    {
        public IList<Line.Info> Lines { get; } = new List<Line.Info>();

        public IBody Line(Action<ILine> action)
        {
            var proxy = new Line.Internal();
            action(proxy);
            Lines.Add(proxy.Build());

            return this;
        }

        public Info Build()
        {
            return new Info
            {
                Lines = Lines,
            };
        }
    }
}
