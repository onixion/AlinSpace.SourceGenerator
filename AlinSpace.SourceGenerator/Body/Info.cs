using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace AlinSpace.SourceGenerator.Body
{
    public class Info
    {
        public IReadOnlyCollection<Line.Info> Lines { get; }

        public Info(IEnumerable<Line.Info> lines)
        {
            Lines = new ReadOnlyCollection<Line.Info>(lines.ToList());
        }
    }
}
