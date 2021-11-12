using System;

namespace AlinSpace.SourceGenerator
{
    public static partial class ConstructorExtensions
    {
        public static IConstructor Argument(
            this IConstructor constructor,
            string text)
        {
            constructor.Argument(p =>
            {
                p.Text = text;
            });

            return constructor;
        }
    }
}
