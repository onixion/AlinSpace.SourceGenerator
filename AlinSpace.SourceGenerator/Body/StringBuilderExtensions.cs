using System.Text;
using AlinSpace.SourceGenerator.Line;

namespace AlinSpace.SourceGenerator.Body
{
    internal static class StringBuilderExtensions
    {
        public static StringBuilder AppendInfo(
            this StringBuilder stringBuilder,
            Info body)
        {
            foreach(var line in body.Lines)
                stringBuilder.AppendInfo(line);

            return stringBuilder;
        }
    }
}
