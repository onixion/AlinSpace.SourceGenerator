using System;
using System.Collections.Generic;

namespace AlinSpace.SourceGenerator.Body
{
    internal class Internal : IBody
    {
        private readonly IList<Line.Info> lines = new List<Line.Info>();

        public IBody Line(Action<ILine> action)
        {
            var proxy = new Line.Internal();
            action(proxy);
            lines.Add(proxy.Build());

            return this;
        }

        public Info Build()
        {
            return new Info(lines);
        }
    }
}
