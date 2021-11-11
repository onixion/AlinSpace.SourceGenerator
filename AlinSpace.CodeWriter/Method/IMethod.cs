using System;

namespace AlinSpace.CodeWriter
{
    public interface IMethod
    {
        #region Properties

        string Name { get; set; }

        AccessModifier AccessModifier { get; set; }

        string ReturnType { get; set; }

        #endregion

        IMethod Attributes(Action<IAttributes> action);

        IMethod Arguments(Action<IArguments> action);

        IMethod Body(Action<IBody> action);
    }
}
