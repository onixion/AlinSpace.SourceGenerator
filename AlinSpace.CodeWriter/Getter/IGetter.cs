using System;

namespace AlinSpace.CodeWriter
{
    public interface IGetter
    {
        IGetter Body(Action<IBody> action);
    }
}
