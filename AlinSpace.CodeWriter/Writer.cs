using System.Text;

namespace AlinSpace.CodeWriter
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
                stringBuilder.Append($"namespace {@namespace.Name}{{");
                
                foreach (var @class in @namespace.Classes)
                {
                    stringBuilder.Append(@class);
                }

                stringBuilder.Append($"}}");
            }

            return stringBuilder.ToString();
        }
    }
}
