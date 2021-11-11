using System;

namespace AlinSpace.CodeWriter
{
    public interface IClass
    {
        #region Properties 

        string Name { get; set; }

        AccessModifier AccessModifier { get; set; }

        bool IsStatic { get; set; }

        #endregion

        IClass Constructor(Action<IConstructor> action);

        IClass Method(Action<IMethod> action);

        IClass Property(Action<IProperty> action);

        IClass Member(Action<IMember> action);
    }
}
