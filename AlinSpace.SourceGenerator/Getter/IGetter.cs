using System;

namespace AlinSpace.SourceGenerator
{
    public interface IGetter
    {
        IGetter Body(Action<IBody> action);
    }
}
