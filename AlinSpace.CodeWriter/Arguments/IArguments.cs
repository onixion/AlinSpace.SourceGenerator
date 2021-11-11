using System;

namespace AlinSpace.CodeWriter
{
    public interface IArguments
    {
        IArguments Argument(Action<IArgument> action);
    }
}
