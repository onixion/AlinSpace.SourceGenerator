using AlinSpace.SourceGenerator.Constructor;
using AlinSpace.SourceGenerator.Member;
using AlinSpace.SourceGenerator.Method;
using AlinSpace.SourceGenerator.Property;
using System.Text;

namespace AlinSpace.SourceGenerator.Class
{
    internal static class StringBuilderExtensions
    {
        public static StringBuilder AppendInfo(
            this StringBuilder stringBuilder,
            Info @class)
        {
            stringBuilder.Append($"{@class.AccessModifier.ToText()} class {@class.Name}{{");

            foreach (var member in @class.Members)
            {
                stringBuilder.AppendInfo(member);
            }

            foreach (var property in @class.Properties)
            {
                stringBuilder.AppendInfo(property);
            }

            foreach (var constructor in @class.Constructors)
            {
                stringBuilder.AppendInfo(constructor);
            }

            foreach (var method in @class.Methods)
            {
                stringBuilder.AppendInfo(method);
            }

            stringBuilder.Append($"}}");

            return stringBuilder;
        }
    }
}
