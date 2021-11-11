using System;

namespace AlinSpace.CodeWriter
{
    static class AccessModifierExtensions
    {
        public static string ToText(this AccessModifier accessModifier)
        {
            switch(accessModifier)
            {
                case AccessModifier.Internal:
                    return "internal";

                case AccessModifier.Public:
                    return "public";

                case AccessModifier.Private:
                    return "private";

                case AccessModifier.Protected:
                    return "protected";

                default:
                    throw new ArgumentException(nameof(accessModifier));
            }
        }
    }
}
