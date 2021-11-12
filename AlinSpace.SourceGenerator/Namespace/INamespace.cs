using System;

namespace AlinSpace.SourceGenerator
{
    public interface INamespace
    {
        string Name { get; set; }

        INamespace Class(Action<IClass> action);
    }
}
