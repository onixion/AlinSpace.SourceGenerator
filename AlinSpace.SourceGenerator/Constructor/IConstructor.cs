using System;

namespace AlinSpace.SourceGenerator
{
    public interface IConstructor
    {
        AccessModifier AccessModifier { get; set; }

        IConstructor Argument(Action<IArgument> action);

        IConstructor Body(Action<IBody> action);
    }
}
