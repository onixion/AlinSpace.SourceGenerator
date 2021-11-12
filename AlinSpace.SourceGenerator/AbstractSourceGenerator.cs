using Microsoft.CodeAnalysis;

namespace AlinSpace.SourceGenerator
{
    public abstract class AbstractSourceGenerator : ISourceGenerator
    {
        public virtual void Initialize(GeneratorInitializationContext context)
        {
        }

        public void Execute(GeneratorExecutionContext context)
        {
            var source = Source.New();
            Execute(source);

        }

        public abstract void Execute(ISource source);
    }
}
