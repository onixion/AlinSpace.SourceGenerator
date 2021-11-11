using System;
using System.Collections.Generic;

namespace AlinSpace.CodeWriter.Body
{
    internal class Internal : IBody
    {
        public IList<Line.Info> Lines { get; set; }

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
