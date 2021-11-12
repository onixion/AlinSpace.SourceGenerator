using System.Text;

namespace AlinSpace.SourceGenerator.Line
{
    internal static class StringBuilderExtensions
    {
        public static StringBuilder AppendInfo(
            this StringBuilder stringBuilder,
            Info line)
        {
            stringBuilder.Append($"{line.Text}");
            return stringBuilder;
        }
    }
}
