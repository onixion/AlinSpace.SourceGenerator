using System;

namespace AlinSpace.CodeWriter
{
    public interface INamespace
    {
        string Name { get; set; }

        INamespace Class(Action<IClass> action);
    }
}
