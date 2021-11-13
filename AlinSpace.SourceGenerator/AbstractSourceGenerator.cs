using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Text;
using System.Linq;
using System.Text;

namespace AlinSpace.SourceGenerator
{
    [Generator]
    public class AbstractSourceGenerator : ISourceGenerator
    {
        public virtual void Initialize(GeneratorInitializationContext context)
        {
        }

        public void Execute(GeneratorExecutionContext context)
        {
            var syntaxTree = context.Compilation.SyntaxTrees;

            var s = new StringBuilder();   


            foreach (var node in syntaxTree)
            {
                s.AppendLine(node.FilePath.ToString());
            }

            context.AddSource("helloWorldGenerator", SourceText.From(s.ToString(), Encoding.UTF8));
        }

        //public abstract void Execute(ISource source);
    }
}
