using System;

namespace AlinSpace.CodeWriter
{
    public interface IProperty
    {
        string Type { get; set; }

        string Name { get; set; }

        IProperty Getter(Action<IGetter> action);

        IProperty Setter(Action<ISetter> action);
    }
}
