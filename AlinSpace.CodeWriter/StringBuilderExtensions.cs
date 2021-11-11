using System;
using System.Text;

namespace AlinSpace.CodeWriter
{
    static class StringBuilderExtensions
    {
        public static StringBuilder Append(
            this StringBuilder builder,
            CodeFormat format,
            Action<StringBuilder> defaultAppend,
            Action<StringBuilder> compactAppend = null)
        {
            if (format.Compact && compactAppend != null)
            {
                compactAppend(builder);
            }
            else
            {
                defaultAppend(builder);
            }

            return builder;
        }
    }
}
