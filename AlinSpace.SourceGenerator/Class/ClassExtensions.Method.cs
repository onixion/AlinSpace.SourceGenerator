using System;

namespace AlinSpace.SourceGenerator
{
    public static partial class ClassExtensions
    {
        public static IClass Method(
            this IClass @class, 
            string name, 
            Action<IMethod> action)
        {
            @class.Method(p =>
            {
                p.Name = name;
                action(p);
            });

            return @class;
        }

        public static IClass MethodPublic(
            this IClass @class,
            string name,
            Action<IMethod> action)
        {
            @class.Method(p =>
            {
                p.Name = name;
                p.AccessModifier = AccessModifier.Public;
                action(p);
            });

            return @class;
        }
    }
}
