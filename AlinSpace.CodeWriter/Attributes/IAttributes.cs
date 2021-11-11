using System;

namespace AlinSpace.CodeWriter
{
    public interface IAttributes
    {
        string Name { get; set; }

        IAttributes Attribute(Action<IAttribute> action);
    }
}
