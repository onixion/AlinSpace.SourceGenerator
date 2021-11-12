using AlinSpace.SourceGenerator.Namespace;
using AlinSpace.SourceGenerator.Using;
using System.Text;

namespace AlinSpace.SourceGenerator
{
    public class Writer
    {
        private Build build;

        public Writer(Build build)
        {
            this.build = build;
        }

        public string GenerateSourceCode()
        {
            var stringBuilder = new StringBuilder();

            foreach(var @using in build.Usings)
            {
                stringBuilder.AppendInfo(@using);
            }

            foreach (var @namespace in build.Namespaces)
            {
                stringBuilder.AppendInfo(@namespace);
            }

            return stringBuilder.ToString();
        }
    }
}
