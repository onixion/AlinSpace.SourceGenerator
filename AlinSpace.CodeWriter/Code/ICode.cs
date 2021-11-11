using System;

namespace AlinSpace.CodeWriter
{
    public interface ICode
    {
        ICode Using(Action<IUsing> action);

        ICode Namespace(Action<INamespace> action);

        Build Build();
    }
}
