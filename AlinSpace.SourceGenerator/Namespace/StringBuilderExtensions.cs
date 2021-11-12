using System.Text;
using AlinSpace.SourceGenerator.Class;

namespace AlinSpace.SourceGenerator.Namespace
{
    internal static class StringBuilderExtensions
    {
        public static StringBuilder AppendInfo(
            this StringBuilder stringBuilder,
            Info @namespace)
        {
            stringBuilder.Append($"namespace {@namespace.Name}{{");

            foreach (var @class in @namespace.Classes)
            {
                stringBuilder.AppendInfo(@class);
            }

            stringBuilder.Append($"}}");

            return stringBuilder;
        }
    }
}
