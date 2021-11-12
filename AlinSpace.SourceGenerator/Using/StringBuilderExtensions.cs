using System.Text;

namespace AlinSpace.SourceGenerator.Using
{
    internal static class StringBuilderExtensions
    {
        public static StringBuilder AppendInfo(
            this StringBuilder stringBuilder,
            Info @using)
        {
            stringBuilder.Append($"using {@using.Name};");
            return stringBuilder;
        }
    }
}
