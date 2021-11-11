using System;

namespace AlinSpace.CodeWriter
{
    public interface ISetter
    {
        IGetter Body(Action<IBody> action);
    }
}
