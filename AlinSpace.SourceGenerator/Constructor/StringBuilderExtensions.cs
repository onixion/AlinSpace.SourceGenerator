using AlinSpace.SourceGenerator.Argument;
using AlinSpace.SourceGenerator.Body;
using System.Text;

namespace AlinSpace.SourceGenerator.Constructor
{
    internal static class StringBuilderExtensions
    {
        public static StringBuilder AppendInfo(
            this StringBuilder stringBuilder,
            Info constructor)
        {
            stringBuilder.Append($"{constructor.AccessModifier.ToText()} {constructor.ClassName}(");

            bool first = true;
            foreach(var argument in constructor.Arguments)
            {
                if(first) first = false;
                else stringBuilder.Append($",");

                stringBuilder.AppendInfo(argument);
            }

            stringBuilder.Append($"){{");
            stringBuilder.AppendInfo(constructor.Body);
            stringBuilder.Append($"}}");

            return stringBuilder;
        }
    }
}
