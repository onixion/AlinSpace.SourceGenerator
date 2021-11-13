using System.Text;

namespace AlinSpace.SourceGenerator.Attribute
{
    internal static class StringBuilderExtensions
    {
        public static StringBuilder AppendInfo(
            this StringBuilder stringBuilder,
            Info attribute)
        {
            stringBuilder.Append($"[{attribute.Text}]");
            return stringBuilder;
        }
    }
}
