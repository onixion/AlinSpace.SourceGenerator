using System.Text;

namespace AlinSpace.SourceGenerator.Argument
{
    internal static class StringBuilderExtensions
    {
        public static StringBuilder AppendInfo(
            this StringBuilder stringBuilder,
            Info argument)
        {
            stringBuilder.Append($"{argument.Text}");
            return stringBuilder;
        }
    }
}
