using AlinSpace.SourceGenerator.Namespace;
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
                stringBuilder.Append($"using {@using.Name};");
            }

            foreach (var @namespace in build.Namespaces)
            {
                stringBuilder.AppendInfo(@namespace);
            }

            return stringBuilder.ToString();
        }
    }
}
