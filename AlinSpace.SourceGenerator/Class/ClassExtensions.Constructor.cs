using System;

namespace AlinSpace.SourceGenerator
{
    public static partial class ClassExtensions
    {
        public static IClass ConstructorPublic(
            this IClass @class,
            Action<IConstructor> action)
        {
            @class.Constructor(p =>
            {
                p.AccessModifier = AccessModifier.Public;
                action(p);
            });

            return @class;
        }
    }
}
