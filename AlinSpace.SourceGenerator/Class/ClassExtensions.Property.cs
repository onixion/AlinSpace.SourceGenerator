using System;

namespace AlinSpace.SourceGenerator
{
    public static partial class ClassExtensions
    {
        public static IClass PropertyPublic(
            this IClass @class,
            Action<IProperty> action)
        {
            @class.Property(p =>
            {
                p.AccessModifier = AccessModifier.Public;
                action(p);
            });

            return @class;
        }
    }
}
