using System;

namespace AlinSpace.SourceGenerator
{
    public interface IClass
    {
        string Name { get; set; }

        AccessModifier AccessModifier { get; set; }

        bool IsStatic { get; set; }

        IClass Constructor(Action<IConstructor> action);

        IClass Method(Action<IMethod> action);

        IClass Property(Action<IProperty> action);

        IClass Member(Action<IMember> action);
    }
}
