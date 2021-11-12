using System.Text;
using AlinSpace.SourceGenerator.Body;

namespace AlinSpace.SourceGenerator.Getter
{
    internal static class StringBuilderExtensions
    {
        public static StringBuilder AppendInfo(
            this StringBuilder stringBuilder,
            Info getter)
        {
            stringBuilder.Append($"get {{");
            stringBuilder.AppendInfo(getter.Body);
            stringBuilder.Append($"}}");

            return stringBuilder;
        }
    }
}
