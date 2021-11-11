using System;

namespace AlinSpace.CodeWriter
{
    public interface IBody
    {
        IBody Line(Action<ILine> action);
    }
}
