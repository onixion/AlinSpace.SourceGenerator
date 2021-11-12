using System.Text;
using AlinSpace.SourceGenerator.Argument;
using AlinSpace.SourceGenerator.Body;

namespace AlinSpace.SourceGenerator.Method
{
    internal static class StringBuilderExtensions
    {
        public static StringBuilder AppendInfo(
            this StringBuilder stringBuilder,
            Info method)
        {
            stringBuilder.Append($"{method.AccessModifier.ToText()} {method.Name}(");

            bool first = true;
            foreach (var argument in method.Arguments)
            {
                if (first) first = false;
                else stringBuilder.Append($",");

                stringBuilder.AppendInfo(argument);
            }

            stringBuilder.Append($"){{");
            stringBuilder.AppendInfo(method.Body);
            stringBuilder.Append($"}}");

            return stringBuilder;
        }
    }
}
