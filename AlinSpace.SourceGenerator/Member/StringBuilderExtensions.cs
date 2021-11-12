using System.Text;

namespace AlinSpace.SourceGenerator.Member
{
    internal static class StringBuilderExtensions
    {
        public static StringBuilder AppendInfo(
            this StringBuilder stringBuilder,
            Info member)
        {
            stringBuilder.Append($"{member.Text};");

            return stringBuilder;
        }
    }
}
