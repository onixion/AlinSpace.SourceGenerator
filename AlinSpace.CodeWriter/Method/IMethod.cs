using System;

namespace AlinSpace.CodeWriter
{
    public interface IMethod
    {
        #region Properties

        string Name { get; set; }

        AccessModifier AccessModifier { get; set; }

        #endregion

        IAttributes Attributes(Action<IAttributes> action);

        IMethod Body(Action<IBody> action);
    }
}
