using System;

namespace AlinSpace.SourceGenerator
{
    public interface ISource
    {
        ISource Using(Action<IUsing> action);

        ISource Namespace(Action<INamespace> action);

        Build Build();
    }
}
