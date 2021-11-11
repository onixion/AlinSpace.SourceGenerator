using System.Text;

namespace AlinSpace.CodeWriter.Class
{
    internal static class StringBuilderExtensions
    {
        public static StringBuilder Append(
            this StringBuilder stringBuilder,
            Info @class)
        {
            stringBuilder.Append($"{@class.AccessModifier.ToText()} class {@class.Name}{{");

            foreach (var property in @class.Methods)
            {
                stringBuilder.Append(property);
            }

            foreach (var method in @class.Methods)
            {
                stringBuilder.Append(method);
            }

            stringBuilder.Append($"}}");

            return stringBuilder;
        }
    }
}
