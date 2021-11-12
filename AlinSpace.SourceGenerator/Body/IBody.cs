using System;

namespace AlinSpace.SourceGenerator
{
    public interface IBody
    {
        IBody Line(Action<ILine> action);
    }
}
