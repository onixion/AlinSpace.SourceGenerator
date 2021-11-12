using AlinSpace.SourceGenerator.Body;
using System.Text;

namespace AlinSpace.SourceGenerator.Setter
{
    internal static class StringBuilderExtensions
    {
        public static StringBuilder AppendInfo(
            this StringBuilder stringBuilder,
            Info setter)
        {
            stringBuilder.Append($"set {{");
            stringBuilder.AppendInfo(setter.Body);
            stringBuilder.Append($"}}");

            return stringBuilder;
        }
    }
}
