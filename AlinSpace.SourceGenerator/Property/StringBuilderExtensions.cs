using System.Text;
using AlinSpace.SourceGenerator.Getter;
using AlinSpace.SourceGenerator.Setter;

namespace AlinSpace.SourceGenerator.Property
{
    internal static class StringBuilderExtensions
    {
        public static StringBuilder AppendInfo(
            this StringBuilder stringBuilder,
            Info property)
        {

            stringBuilder.Append($"{property.AccessModifier.ToText()} {property.Type} {property.Name}{{");
            
            if(property.Getter != null)
                stringBuilder.AppendInfo(property.Getter);

            if(property.Setter != null)
                stringBuilder.AppendInfo(property.Setter);

            stringBuilder.Append($"}}");

            return stringBuilder;
        }
    }
}
