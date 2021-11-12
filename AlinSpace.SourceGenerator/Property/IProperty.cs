using System;

namespace AlinSpace.SourceGenerator
{
    public interface IProperty
    {
        AccessModifier AccessModifier { get; set; }

        string Type { get; set; }

        string Name { get; set; }

        IProperty Getter(Action<IGetter> action);

        IProperty Setter(Action<ISetter> action);
    }
}
