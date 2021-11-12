using System;

namespace AlinSpace.SourceGenerator
{
    public interface ISetter
    {
        ISetter Body(Action<IBody> action);
    }
}
