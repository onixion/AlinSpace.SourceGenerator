using System;

namespace AlinSpace.SourceGenerator
{
    public interface IMethod
    {
        string Name { get; set; }

        AccessModifier AccessModifier { get; set; }

        string ReturnType { get; set; }

        IMethod Attribute(Action<IAttribute> action);

        IMethod Argument(Action<IArgument> action);

        IMethod Body(Action<IBody> action);
    }
}
